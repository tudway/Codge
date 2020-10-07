﻿using Codge.DataModel;
using Codge.DataModel.Framework;
using Codge.Generator.Presentations;
using CommandLine;
using Common.Logging;
using System.Linq;


namespace Codge.Generator.Console
{
    class Options
    {
        [Option('m', "model", Required = true, HelpText = "Path to a model file (xml or xsd)")]
        public string Model { get; set; }

        [Option('n', "modelName", Required = false, HelpText = "Name of the model.", DefaultValue = "TODO")]
        public string ModelName { get; set; }

        [Option('o', "outputDir", Required = false, HelpText = "Path to a output directory.", DefaultValue = @"../../../Generated/CS")]
        public string OutputDir { get; set; }
    }

    class Program
    {
        private static ILog _logger = LogManager.GetLogger("");


        //-m "%scriptDir%\Codge.Generator.Test\TestStore\XsdLoader\LoadXsd\Test.xsd" -o "%scriptDir%/Generated/CS_xsd" -n XsdBasedModel
        static void Main(string[] args)
        {
            var options = new Options();
            if (CommandLine.Parser.Default.ParseArgumentsStrict(args, options))
            {
                var model = LoadModel(options.Model, options.ModelName);

                ProcessTemplates(LoadConfig(options.OutputDir),
                                 model,
                                 _logger);
            }
        }

        static void ProcessTemplates(GeneratorConfig config, Model model, ILog logger)
        {
            var generator = new Codge.Generator.Generator(config, logger);
            generator.Generate(model);

            logger.Info("--------------------");
            logger.Info("Files evaluated: " + (generator.Context.Tracker.FilesUpdated.Count() + generator.Context.Tracker.FilesSkipped.Count()));
            logger.Info("Files updated: " + generator.Context.Tracker.FilesUpdated.Count());
            logger.Info("--------------------");
        }


        static Model LoadModel(string path, string modelName)
        {
            System.Console.WriteLine("Loading model [" + path + "]");

            var model = new ModelLoader(_logger).LoadModel(path, modelName);

            var typeSystem = new TypeSystem();
            var compiler = new ModelProcessor();
            return compiler.Compile(typeSystem, model);
        }


        static GeneratorConfig LoadConfig(string path)
        {
            var config = new GeneratorConfig(path, new BasicModel.Templates.CS.TaskFactory(_logger));

            //config.AddTypeTask(new OutputTask<TypeDescriptor>(new TypeTask(CreateTaskInput(@"D:\work\2012\ConsoleApplication1\Composite.stg"))));
            //config.AddTypeTask(new OutputTask<TypeDescriptor>(new TypeTask(CreateTaskInput(@"D:\work\2012\ConsoleApplication1\Primitive.stg"))));

            return config;

        }
    }
}
