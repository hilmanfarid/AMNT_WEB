#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.NavigationField
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 3 "..\..MVC\Views\NavigationField\Read.ProgressBar.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\NavigationField\Read.ProgressBar.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/NavigationField/Read.ProgressBar.cshtml")]
    public partial class Read_ProgressBar : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.NavigationField.NavigationFieldViewModel>
    {
        public Read_ProgressBar()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 6 "..\..MVC\Views\NavigationField\Read.ProgressBar.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 7 "..\..MVC\Views\NavigationField\Read.ProgressBar.cshtml"
Write(Html.StyleSheet(Url.WidgetContent("assets/dist/css/sf-form-nav.min.css"), "head", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 332), Tuple.Create("\"", 355)
            
            #line 10 "..\..MVC\Views\NavigationField\Read.ProgressBar.cshtml"
, Tuple.Create(Tuple.Create("", 340), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 340), false)
);

WriteLiteral(" data-sf-role=\"navigation-field-container\"");

WriteLiteral(">\n\n    <div");

WriteLiteral(" class=\"progress\"");

WriteLiteral(">\n        <div");

WriteLiteral(" class=\"progress-bar\"");

WriteLiteral(" data-sf-role=\"progress-bar\"");

WriteLiteral("></div>\n    </div>\n\n    <span");

WriteLiteral(" class=\"sf-Progress-percent\"");

WriteLiteral(" data-sf-role=\"progress-percent\"");

WriteLiteral("> </span>\n\n    <ul");

WriteLiteral(" class=\"sf-Progress-page-title\"");

WriteLiteral(">\n");

            
            #line 19 "..\..MVC\Views\NavigationField\Read.ProgressBar.cshtml"
        
            
            #line default
            #line hidden
            
            #line 19 "..\..MVC\Views\NavigationField\Read.ProgressBar.cshtml"
         foreach (var page in Model.Pages)
        {

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral("  data-sf-navigation-index=\"");

            
            #line 21 "..\..MVC\Views\NavigationField\Read.ProgressBar.cshtml"
                                      Write(page.Index);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n");

WriteLiteral("                ");

            
            #line 22 "..\..MVC\Views\NavigationField\Read.ProgressBar.cshtml"
           Write(Html.Raw(page.Title));

            
            #line default
            #line hidden
WriteLiteral("\n            </li>\n");

            
            #line 24 "..\..MVC\Views\NavigationField\Read.ProgressBar.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\n\n\n</div>\n\n");

            
            #line 30 "..\..MVC\Views\NavigationField\Read.ProgressBar.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/NavigationField/navigation-field.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\n");

        }
    }
}
#pragma warning restore 1591