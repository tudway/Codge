﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace BasicModel.Templates.CS.Templates.Types
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
    
    #line 1 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\Types\Composite.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class Composite : T4TemplateAction<TypeBase>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n\r\nnamespace Types.");
            
            #line 11 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\Types\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.Namespace.GetFullName(".")));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\tpublic class ");
            
            #line 13 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\Types\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.Name));
            
            #line default
            #line hidden
            this.Write("\r\n\t{\r\n\t\tpublic ");
            
            #line 15 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\Types\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 15 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\Types\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.GetCtorParamters()));
            
            #line default
            #line hidden
            this.Write(")\r\n\t\t{\r\n");
            
            #line 17 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\Types\Composite.tt"
				
					foreach(var field in Type.Fields)
					{

            
            #line default
            #line hidden
            this.Write("\t\t\t");
            
            #line 21 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\Types\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.GetMemberName(field)));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 21 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\Types\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.GetParameterName()));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 22 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\Types\Composite.tt"
				
					}

            
            #line default
            #line hidden
            this.Write("\t\t}\r\n\r\n\r\n");
            
            #line 28 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\Types\Composite.tt"
				
					foreach(var field in Type.Fields)
					{

            
            #line default
            #line hidden
            this.Write("\t\tpublic\t");
            
            #line 32 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\Types\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.GetNativeType()));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 32 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\Types\Composite.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type.GetMemberName(field)));
            
            #line default
            #line hidden
            this.Write(" {get; private set;}\r\n");
            
            #line 33 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\Types\Composite.tt"
				
					}

            
            #line default
            #line hidden
            this.Write("\t}\r\n}\r\n\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 40 "D:\work\Codge\Src\Models\Basic\CS\BasicModel.Templates\Templates\Types\Composite.tt"

	

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
		return new PathAndContent(Utils.GetOutputPath(Type, "Types", "cs"), TransformText());
	}


        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
