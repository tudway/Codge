﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Codge.BasicModel.Templates.CS.Templates.XmlSerialisers
{
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using Codge.DataModel;
    using Codge.Generator.Common;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class Composite : T4TemplateAction<TypeBase>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using Codge.BasicModel.CS.Serialisation;\r\nusing System.Xml;\r\nusing Types.");
            
            #line 11 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.Namespace.GetFullName(".")));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\nnamespace Serialisers.");
            
            #line 13 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.Namespace.GetFullName(".")));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\tpublic class ");
            
            #line 15 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.Name));
            
            #line default
            #line hidden
            this.Write(" : IXmlSerialiser\r\n\t{\r\n\r\n        public void Serialize(XmlWriter writer, object o" +
                    ", SerialisationContext context)\r\n        {\r\n            var obj = (");
            
            #line 20 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.TypesQName()));
            
            #line default
            #line hidden
            this.Write(")o;\r\n\r\n");
            
            #line 22 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"

					foreach(var field in Type.Fields)
					{
						string fieldName = ModelBehaviour.GetMemberName(field);
						if(field.IsCollection)
						{
							if(field.Type.IsBuiltIn() || field.Type.IsPrimitive())
							{

            
            #line default
            #line hidden
            this.Write("\t\t\tUtils.SerialiseBuiltInCollection(writer, \"");
            
            #line 31 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write("\", obj.");
            
            #line 31 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(", context);\r\n");
            
            #line 32 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
				
							}
                            else if(field.Type.IsEnum())
                            {

            
            #line default
            #line hidden
            this.Write("\t\t\tUtils.SerialiseEnumCollectionAsString(writer, \"");
            
            #line 37 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write("\", obj.");
            
            #line 37 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 37 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Type.Name));
            
            #line default
            #line hidden
            this.Write("Converter.ConvertToString, context);\r\n");
            
            #line 38 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
				
                            }
							else
							{

            
            #line default
            #line hidden
            this.Write("\t\t\tUtils.SerialiseCollection(writer, \"");
            
            #line 43 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write("\", obj.");
            
            #line 43 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(", context);\r\n");
            
            #line 44 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"

							}
						}
						else if(field.IsContent())
						{
                            if(field.IsCData())
                            {

            
            #line default
            #line hidden
            this.Write("            if(obj.");
            
            #line 52 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(" != null)\r\n\t\t\t    writer.WriteCData(obj.");
            
            #line 53 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(".ToString());\r\n");
            
            #line 54 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
				
                            }
                            else if(field.Type.IsEnum())
                            {

            
            #line default
            #line hidden
            this.Write("            if(obj.");
            
            #line 59 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(" != null)\r\n\t\t\t    writer.WriteValue(");
            
            #line 60 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Type.Name));
            
            #line default
            #line hidden
            this.Write("Converter.ConvertToString(obj.");
            
            #line 60 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write("));\r\n");
            
            #line 61 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"

                            }
                            else
                            {

            
            #line default
            #line hidden
            this.Write("            if(obj.");
            
            #line 66 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(" != null)\r\n\t\t\t    writer.WriteValue(obj.");
            
            #line 67 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(".ToString());\r\n");
            
            #line 68 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
				
                            }
						}
						else if(field.IsAttribute())
						{

            
            #line default
            #line hidden
            this.Write("            if(obj.");
            
            #line 74 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(" != null)\r\n                writer.WriteAttributeString(\"");
            
            #line 75 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write("\", obj.");
            
            #line 75 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(".ToString());\r\n");
            
            #line 76 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
				
						}
						else
						{
							if(field.Type.IsComposite())
							{
                                if(field.IsOptional())
                                {

            
            #line default
            #line hidden
            this.Write("\t\t\tUtils.SerialiseIfHasValue(writer, \"");
            
            #line 85 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write("\", obj.");
            
            #line 85 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(", context);\r\n");
            
            #line 86 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"

                                }
                                else
                                {

            
            #line default
            #line hidden
            this.Write("\t\t\tUtils.Serialise(writer, \"");
            
            #line 91 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write("\", obj.");
            
            #line 91 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(", context);\r\n");
            
            #line 92 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"

                                }
							}
                            else if(field.Type.IsEnum())
                            {
                                if(field.IsOptional())
                                {

            
            #line default
            #line hidden
            this.Write("\t\t\tUtils.SerialiseEnumAsStringIfHasValue(writer, \"");
            
            #line 100 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write("\", obj.");
            
            #line 100 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 100 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Type.Name));
            
            #line default
            #line hidden
            this.Write("Converter.ConvertToString, context);\r\n");
            
            #line 101 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"

                                }
                                else
                                {

            
            #line default
            #line hidden
            this.Write("\t\t\tUtils.SerialiseEnumAsString(writer, \"");
            
            #line 106 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write("\", obj.");
            
            #line 106 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 106 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Type.Name));
            
            #line default
            #line hidden
            this.Write("Converter.ConvertToString, context);\r\n");
            
            #line 107 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"

                                }

                            }
                            else
							{
                                string cdata = field.IsCData() ? "CData" : string.Empty;
                                if(field.IsOptional())
                                {

            
            #line default
            #line hidden
            this.Write("\t\t\tUtils.Serialise");
            
            #line 117 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(cdata));
            
            #line default
            #line hidden
            this.Write("IfHasValue(writer, \"");
            
            #line 117 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write("\", obj.");
            
            #line 117 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(", context);\r\n");
            
            #line 118 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"

                                }
                                else
                                {

            
            #line default
            #line hidden
            this.Write("\t\t\tUtils.Serialise");
            
            #line 123 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(cdata));
            
            #line default
            #line hidden
            this.Write("Value(writer, \"");
            
            #line 123 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write("\", obj.");
            
            #line 123 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(", context);\r\n");
            
            #line 124 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"

                                }
							}
                            
						}
					}

            
            #line default
            #line hidden
            this.Write("\t\t}\r\n\r\n\t}\r\n}\r\n\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 137 "C:\Work\Projects\codge_\Src\Models\Basic\CS\Codge.BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"

	public CompositeType Type{get; private set;}

	public Composite(TypeBase type, ModelBehaviour modelBehaviour)
        : base(modelBehaviour)
	{
		Type = type as CompositeType;
	}

	public override bool IsApplicable()
	{
		return Type!=null;
	}

	public override PathAndContent Execute(Context context)
	{
		return new PathAndContent(new ItemInformation(Type.QName(), "Serialisers.cs"), TransformText());
	}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
