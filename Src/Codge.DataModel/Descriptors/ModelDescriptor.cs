﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codge.DataModel.Descriptors
{
    public class ModelDescriptor
    {
        public string Name{get; private set;}
        public NamespaceDescriptor RootNamespace { get; private set; }

        public ModelDescriptor(string modelName, string rootNamespace)
            : this(modelName, new NamespaceDescriptor(rootNamespace))
        {
            //TODO check "."
        }

        public ModelDescriptor(string modelName, NamespaceDescriptor rootNamespace)
        {
            Name = modelName;
            //TODO check "."
            RootNamespace = rootNamespace;
        }

    }
}
