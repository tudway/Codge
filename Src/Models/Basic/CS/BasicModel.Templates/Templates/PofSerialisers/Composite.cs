﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace BasicModel.Templates.CS.Templates.PofSerialisers
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
    
    #line 1 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\PofSerialisers\Composite.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class Composite : T4TemplateAction<TypeBase>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using Tangosol.IO.Pof;\r\n\r\nnamespace Serialisers.");
            
            #line 11 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\PofSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.Namespace.GetFullName(".")));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\tpublic class ");
            
            #line 13 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\PofSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.Name));
            
            #line default
            #line hidden
            this.Write(" : IPofSerializer\r\n\t{\r\n\r\n\t\tobject IPofSerializer.Deserialize(IPofReader reader)\r\n" +
                    "        {\r\n\t\t\tvar result = new Types.");
            
            #line 18 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\PofSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.GetFullName(".")));
            
            #line default
            #line hidden
            this.Write("(\r\n");
            
            #line 19 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\PofSerialisers\Composite.tt"

					bool bFirst = true;
					foreach(var field in Type.Fields)
					{

            
            #line default
            #line hidden
            this.Write("\t\t\t\t");
            
            #line 24 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\PofSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(bFirst ? " " : ","));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 24 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\PofSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Type.QName()));
            
            #line default
            #line hidden
            this.Write(")reader.Read");
            
            #line 24 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\PofSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.CoherenceType()));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 24 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\PofSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Id));
            
            #line default
            #line hidden
            this.Write(")\r\n");
            
            #line 25 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\PofSerialisers\Composite.tt"
				
						bFirst = false;
					}

            
            #line default
            #line hidden
            this.Write("\t\t\t\t);\r\n\t\t\treader.ReadRemainder();\r\n\t\t\treturn result;\r\n        }\r\n\r\n        void " +
                    "IPofSerializer.Serialize(IPofWriter writer, object o)\r\n        {\r\n            va" +
                    "r obj = (");
            
            #line 36 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\PofSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.QName()));
            
            #line default
            #line hidden
            this.Write(")o;\r\n\r\n");
            
            #line 38 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\PofSerialisers\Composite.tt"

					foreach(var field in Type.Fields)
					{

            
            #line default
            #line hidden
            this.Write("\t\t\twriter.Write");
            
            #line 42 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\PofSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.CoherenceType()));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 42 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\PofSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Id));
            
            #line default
            #line hidden
            this.Write(", obj.");
            
            #line 42 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\PofSerialisers\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 43 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\PofSerialisers\Composite.tt"
				
					}

            
            #line default
            #line hidden
            this.Write("\t\t\twriter.WriteRemainder(null);\r\n\t\t}\r\n\r\n\t}\r\n}\r\n\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 53 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\PofSerialisers\Composite.tt"

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
