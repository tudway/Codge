﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codge.DataModel.Descriptors;

namespace Codge.DataModel
{
    public class NamespaceTracingTypeSystemEventHandler<T>
    : ICompositeNodeEventHandler<NamespaceDescriptor>
    {
        private readonly Stack<T> _namespaces;
        private Func<T, NamespaceDescriptor, T> _converter;
        public NamespaceTracingTypeSystemEventHandler(T ns, Func<T, NamespaceDescriptor,T> converter)
        {
            _namespaces = new Stack<T>();
            _namespaces.Push(ns);
            _converter = converter;
        }

        public void OnEnter(NamespaceDescriptor node)
        {
            _namespaces.Push(_converter(Namespace, node));
        }

        public void OnLeave(NamespaceDescriptor node)
        {
            _namespaces.Pop();
        }

        protected T Namespace { get { return _namespaces.Peek(); } }
    }



    public class ModelCompiler
    {
        public Model Compile(TypeSystem typeSystem, ModelDescriptor model)
        {
            var ns = typeSystem.GetOrCreateNamespace(model.RootNamespace.Name);

            var compiledModel = new Model(ns);

            //first pass - create type stubs
            TypeSystemWalker.Walk(model.RootNamespace, new TypeSystemCompileHandlerFirstPass(compiledModel.Namespace));

            //second pass - fill composite types with fields
            TypeSystemWalker.Walk(model.RootNamespace, new TypeSystemCompileHandlerSecondPass(compiledModel.Namespace));

            return compiledModel;
        }

        static int id = 3000;
        private static int GetId(string name)
        {
            return id++;//TODO
        }

        public class TypeSystemCompileHandlerFirstPass
            : NamespaceTracingTypeSystemEventHandler<Namespace>
            , IAtomicNodeEnventHandler<PrimitiveTypeDescriptor>
            , IAtomicNodeEnventHandler<CompositeTypeDescriptor>
            , IAtomicNodeEnventHandler<EnumerationTypeDescriptor>
        {
            public TypeSystemCompileHandlerFirstPass(Namespace ns)
                : base(ns, (n, descriptor) => n.GetOrCreateNamespace(descriptor.Name))
            {
            }


            public void Handle(PrimitiveTypeDescriptor primitive)
            {
                Namespace.CreatePrimitiveType(GetId(primitive.Name), primitive.Name);
            }

            public void Handle(CompositeTypeDescriptor composite)
            {
                Namespace.CreateCompositeType(GetId(composite.Name), composite.Name);
            }

            public void Handle(EnumerationTypeDescriptor enumeration)
            {
                var descriptor = Namespace.CreateEnumerationType(GetId(enumeration.Name), enumeration.Name);
                foreach (var item in enumeration.Items)
                {
                    if (item.Value.HasValue)
                        descriptor.AddItem(item.Name, item.Value.Value);
                    else
                        descriptor.AddItem(item.Name);
                }
            }
        }

        public class TypeSystemCompileHandlerSecondPass
            : NamespaceTracingTypeSystemEventHandler<Namespace>
            , IAtomicNodeEnventHandler<CompositeTypeDescriptor>
        {
            public TypeSystemCompileHandlerSecondPass(Namespace ns)
                : base(ns, (n, descriptor) => n.GetOrCreateNamespace(descriptor.Name))
            {
            }

            public void Handle(CompositeTypeDescriptor composite)
            {
                var descriptor = Namespace.GetType<CompositeType>(composite.Name);
                foreach (var field in composite.Fields)
                {
                    var fieldType = Namespace.findTypeByPartialName(field.TypeName);
                    if (fieldType == null)
                    {
                        throw new Exception("Field [" + field.Name + "] is of unknown type [" + field.TypeName + "]");
                    }

                    if (field.IsCollection)
                        descriptor.AddCollectionField(field.Name, fieldType, field.AttachedData);
                    else
                        descriptor.AddField(field.Name, fieldType, field.AttachedData);
                }
            }
        }

    }
}
