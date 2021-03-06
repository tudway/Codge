﻿using Codge.DataModel.Descriptors;
using Codge.DataModel.Descriptors.Serialisation;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace Codge.DataModel.Framework
{
    public class ModelMergeTypeSystemEventHandler
            : NamespaceTracingTypeSystemEventHandler<NamespaceDescriptor>
            , IAtomicNodeEnventHandler<PrimitiveTypeDescriptor>
            , IAtomicNodeEnventHandler<CompositeTypeDescriptor>
            , IAtomicNodeEnventHandler<EnumerationTypeDescriptor>
    {
        private readonly ILogger _logger;

        public ModelMergeTypeSystemEventHandler(NamespaceDescriptor ns, ILogger logger)
            : base(ns, (n, descriptor) => n.GetOrCreateNamespace(descriptor.Name))
        {
            _logger = logger;
        }


        public void Handle(PrimitiveTypeDescriptor primitive)
        {
            var lhsType = Namespace.Types.FindByName(primitive.Name);
            if (lhsType == null)
            {
                Namespace.CreatePrimitiveType(primitive.Name);
            }
        }

        private int GetInsertPosition(List<FieldDescriptor> lhsFields, IList<FieldDescriptor> rhsFields, int rhsFieldPos)
        {
            var fieldToLookFor = rhsFields[rhsFieldPos];
            int pos = lhsFields.FindIndex(_ => _.Name == fieldToLookFor.Name);
            if (pos == -1)
            {
                if (++rhsFieldPos >= rhsFields.Count)
                {
                    return lhsFields.Count;
                }
                return GetInsertPosition(lhsFields, rhsFields, rhsFieldPos);
            }
            return pos;
        }

        public void Handle(CompositeTypeDescriptor composite)
        {
            var lhsType = Namespace.Types.FindByName(composite.Name) as CompositeTypeDescriptor;
            if (lhsType == null)
            {
                lhsType = Namespace.CreateCompositeType(composite.Name);
            }

            var rhsFields = composite.Fields.ToList();
            int fieldIndex = -1;
            foreach (var field in rhsFields)
            {
                ++fieldIndex;

                var lhsField = lhsType.Fields.FirstOrDefault(_ => _.Name == field.Name);
                if (lhsField == null)
                {//TODO optimise
                    int insertionPos = GetInsertPosition(lhsType.Fields.ToList(), rhsFields, fieldIndex);
                    lhsField = lhsType.AddField(field.Name, field.TypeName, field.IsCollection, insertionPos);
                }

                if (lhsField.IsCollection != field.IsCollection || lhsField.TypeName != field.TypeName)
                    _logger.LogWarning("different field definitions lhs:[{lhs}], rhs:[{rhs}]", lhsField.ToXml(), field.ToXml());

                field.AttachedData.Where(_ => !lhsField.AttachedData.Keys.Contains(_.Key)).ToList().ForEach(_ => lhsField.AttachedData.Add(_));
            }
        }


        public void Handle(EnumerationTypeDescriptor enumeration)
        {
            var lhsType = Namespace.Types.FindByName(enumeration.Name) as EnumerationTypeDescriptor;
            if (lhsType == null)
            {
                lhsType = Namespace.CreateEnumerationType(enumeration.Name);
            }

            //TODO preserve position?
            foreach (var item in enumeration.Items)
            {
                var lhsItem = lhsType.Items.FirstOrDefault(_ => _.Name == item.Name);
                if (lhsItem == null)
                {
                    if (item.Value.HasValue)
                        lhsType.AddItem(item.Name, item.Value.Value);
                    else
                        lhsType.AddItem(item.Name);
                }
                else
                {
                    _logger.LogWarning("different item definitions lhs:[{lhs}], rhs:[{rhs}]", lhsItem.ToXml(), item.ToXml());
                }
            }
        }
    }

}
