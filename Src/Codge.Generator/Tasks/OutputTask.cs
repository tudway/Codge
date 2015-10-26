﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Logging;
using Qart.Core.Validation;
using Qart.Core.Io;


namespace Codge.Generator.Tasks
{
    public class OutputTask<T> : ITask<T>
    {
        public ILog Logger { get; private set; }

        IOutputAction<T> Action;
        public OutputTask(IOutputAction<T> action, ILog logger)
        {
            Action = action;
            Logger = logger;
        }

        public bool IsApplicable()
        {
            return Action.IsApplicable();
        }

        public void Execute(Context context)
        {
            var pathAndContent = Action.Execute(context);
            Require.NotNullOrEmpty(pathAndContent.Path);

            string path = context.GetAbsolutePath(pathAndContent.Path);

            if (File.Exists(path) && File.ReadAllText(path) == pathAndContent.Content)
            {//same content 
                context.Tracker.OnFileSkipped(pathAndContent.Path);
            }
            else
            {//did not exist or has changed
                FileUtils.WriteAllText(path, pathAndContent.Content);
                context.Tracker.OnFileUpdated(pathAndContent.Path);
            }
        }
    }
}
