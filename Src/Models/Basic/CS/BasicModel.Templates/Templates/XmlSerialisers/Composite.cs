﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace BasicModel.Templates.CS.Templates.XmlSerialisers
{
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using Codge.DataModel;
    using Codge.Generator;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class Composite : T4TemplateAction<TypeBase>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using BasicModel.CS.Serialisation;\r\nusing System.Xml;\r\nusing Types.");
            
            #line 11 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.Namespace.GetFullName(".")));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\nnamespace Serialisers.");
            
            #line 13 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.Namespace.GetFullName(".")));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\tpublic class ");
            
            #line 15 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.Name));
            
            #line default
            #line hidden
            this.Write(" : IXmlSerialiser\r\n\t{\r\n\r\n        public void Serialize(XmlWriter writer, object o" +
                    ", SerialisationContext context)\r\n        {\r\n            var obj = (");
            
            #line 20 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.QName()));
            
            #line default
            #line hidden
            this.Write(")o;\r\n\r\n");
            
            #line 22 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"

					foreach(var field in Type.Fields)
					{
						string fieldName = Type.GetMemberName(field);
						if(field.IsCollection)
						{
							if(field.Type.IsBuiltIn())
							{

            
            #line default
            #line hidden
            this.Write("\t\t\tUtils.SerialiseBuiltInCollection(writer, \"");
            
            #line 31 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write("\", obj.");
            
            #line 31 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(", context);\r\n");
            
            #line 32 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
				
							}
                            else if(field.Type.IsEnum())
                            {

            
            #line default
            #line hidden
            this.Write("\t\t\tUtils.SerialiseEnumCollectionAsString(writer, \"");
            
            #line 37 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write("\", obj.");
            
            #line 37 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 37 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Type.Name));
            
            #line default
            #line hidden
            this.Write("Converter.ConvertToString, context);\r\n");
            
            #line 38 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
				
                            }
							else
							{

            
            #line default
            #line hidden
            this.Write("\t\t\tUtils.SerialiseCollection(writer, \"");
            
            #line 43 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write("\", obj.");
            
            #line 43 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(", context);\r\n");
            
            #line 44 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
				
							}
						}
						else if(field.IsContent())
						{

            
            #line default
            #line hidden
            this.Write("            if(obj.");
            
            #line 50 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(" != null)\r\n\t\t\t    writer.WriteValue(obj.");
            
            #line 51 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(".ToString());\r\n");
            
            #line 52 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
				
						}
						else if(field.IsAttribute())
						{

            
            #line default
            #line hidden
            this.Write("            if(obj.");
            
            #line 57 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(" != null)\r\n                writer.WriteAttributeString(\"");
            
            #line 58 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write("\", obj.");
            
            #line 58 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(".ToString());\r\n");
            
            #line 59 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
				
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
            
            #line 68 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write("\", obj.");
            
            #line 68 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(", context);\r\n");
            
            #line 69 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"

                                }
                                else
                                {

            
            #line default
            #line hidden
            this.Write("\t\t\tUtils.Serialise(writer, \"");
            
            #line 74 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write("\", obj.");
            
            #line 74 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(", context);\r\n");
            
            #line 75 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"

                                }
							}
                            else if(field.Type.IsEnum())
                            {
                                if(field.IsOptional())
                                {

            
            #line default
            #line hidden
            this.Write("\t\t\tUtils.SerialiseEnumAsStringIfHasValue(writer, \"");
            
            #line 83 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write("\", obj.");
            
            #line 83 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 83 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Type.Name));
            
            #line default
            #line hidden
            this.Write("Converter.ConvertToString, context);\r\n");
            
            #line 84 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"

                                }
                                else
                                {

            
            #line default
            #line hidden
            this.Write("\t\t\tUtils.SerialiseEnumAsString(writer, \"");
            
            #line 89 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write("\", obj.");
            
            #line 89 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 89 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Type.Name));
            
            #line default
            #line hidden
            this.Write("Converter.ConvertToString, context);\r\n");
            
            #line 90 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"

                                }

                            }
                            else
							{
                                if(field.IsOptional())
                                {

            
            #line default
            #line hidden
            this.Write("\t\t\tUtils.SerialiseIfHasValue(writer, \"");
            
            #line 99 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write("\", obj.");
            
            #line 99 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(", context);\r\n");
            
            #line 100 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"

                                }
                                else
                                {

            
            #line default
            #line hidden
            this.Write("\t\t\tUtils.SerialiseValue(writer, \"");
            
            #line 105 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write("\", obj.");
            
            #line 105 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(fieldName));
            
            #line default
            #line hidden
            this.Write(", context);\r\n");
            
            #line 106 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"

                                }
							}
                            
						}
					}

            
            #line default
            #line hidden
            this.Write("\t\t}\r\n\r\n\t}\r\n}\r\n\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 119 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\XmlSerialisers\Composite.tt"

	public CompositeType Type{get; private set;}

	public Composite(TypeBase type)
	{
		Type = type as CompositeType;
	}

	public override bool IsApplicable()
	{
		return Type!=null;
	}

	public override PathAndContent Execute(Context context)
	{
		return new PathAndContent(Utils.GetOutputPath(Type, "Serialisers", "cs"), TransformText());
	}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
