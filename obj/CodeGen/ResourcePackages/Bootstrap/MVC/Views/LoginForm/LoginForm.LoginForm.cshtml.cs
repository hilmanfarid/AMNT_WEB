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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.LoginForm
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
    
    #line 4 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap/MVC/Views/LoginForm/LoginForm.LoginForm.cshtml")]
    public partial class LoginForm_LoginForm : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.LoginForm.LoginFormViewModel>
    {
        public LoginForm_LoginForm()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

WriteLiteral("\n");

            
            #line 9 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top"));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 10 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/jquery.validate/1.8.1/jquery.validate.js",  "top"));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 11 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/mvc/4.0/jquery.validate.unobtrusive.min.js", "top"));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 13 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
  
    var isTwoCols = (Model.ExternalProviders != null && Model.ExternalProviders.Count() > 0) ? "col-md-6" : "";

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 621), Tuple.Create("\"", 657)
            
            #line 17 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
, Tuple.Create(Tuple.Create("", 629), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 629), false)
, Tuple.Create(Tuple.Create(" ", 644), Tuple.Create("row", 645), true)
, Tuple.Create(Tuple.Create(" ", 648), Tuple.Create("sf-m-xxs", 649), true)
);

WriteLiteral(">\n");

            
            #line 18 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    
            
            #line default
            #line hidden
            
            #line 18 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
     if (Telerik.Sitefinity.Security.SecurityManager.GetCurrentUserId() == Guid.Empty || SystemManager.IsInlineEditingMode || SystemManager.IsDesignMode)
    {
        using (Html.BeginFormSitefinity(@Request.Url.Query, null, null, FormMethod.Post, null, true))
        {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteAttribute("class", Tuple.Create(" class=\"", 944), Tuple.Create("\"", 962)
            
            #line 22 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
, Tuple.Create(Tuple.Create("", 952), Tuple.Create<System.Object, System.Int32>(isTwoCols
            
            #line default
            #line hidden
, 952), false)
);

WriteLiteral(">\n");

WriteLiteral("         ");

            
            #line 23 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
WriteLiteral("\n\t\t \t\t \n            <h3>");

            
            #line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
           Write(Html.Resource("LoginFormLogInLegendHeader"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n\t\t\t\n");

            
            #line 27 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
            
            
            #line default
            #line hidden
            
            #line 27 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
             if (Request.Url.Query.Contains("err=true") || Model.LoginError)
            {            

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(">\n");

WriteLiteral("\t\t\t\t\t");

            
            #line 30 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
               Write(Html.Resource("IncorrectCredentialsMessage"));

            
            #line default
            #line hidden
WriteLiteral("\n\t\t\t\t</div>                \n");

            
            #line 32 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n                <label>\n");

WriteLiteral("                    ");

            
            #line 36 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
               Write(Html.Resource("UserName"));

            
            #line default
            #line hidden
WriteLiteral("\n                </label>\n\n");

WriteLiteral("                ");

            
            #line 39 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
           Write(Html.TextBoxFor(u => u.UserName, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 40 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                
            
            #line default
            #line hidden
            
            #line 40 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                 if(Html.ValidationMessage("UserName")!=null)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"has-error\"");

WriteLiteral(">\n                        <span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral(">");

            
            #line 43 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                            Write(Html.ValidationMessage("UserName"));

            
            #line default
            #line hidden
WriteLiteral("</span>\n                    </div>\n");

            
            #line 45 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                }  

            
            #line default
            #line hidden
WriteLiteral("\n            </div>\n\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n                <label>\n");

WriteLiteral("                    ");

            
            #line 51 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
               Write(Html.Resource("Password"));

            
            #line default
            #line hidden
WriteLiteral("\n                </label>\n\n");

WriteLiteral("                ");

            
            #line 54 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
           Write(Html.PasswordFor(u => u.Password, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 55 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                
            
            #line default
            #line hidden
            
            #line 55 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                 if(Html.ValidationMessage("Password") != null)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"has-error\"");

WriteLiteral(">\n                        <span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral(">");

            
            #line 58 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                            Write(Html.ValidationMessage("Password"));

            
            #line default
            #line hidden
WriteLiteral("</span>\n                    </div>\n");

            
            #line 60 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                }  

            
            #line default
            #line hidden
WriteLiteral("\n            </div>\n\n");

            
            #line 64 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
            
            
            #line default
            #line hidden
            
            #line 64 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
             if (Model.ShowRememberMe || Model.ShowForgotPasswordLink)
            {
            var isPulledRight = Model.ShowRememberMe ? "" : "pull-right";


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteAttribute("class", Tuple.Create(" class=\"", 2495), Tuple.Create("\"", 2532)
, Tuple.Create(Tuple.Create("", 2503), Tuple.Create("form-group", 2503), true)
, Tuple.Create(Tuple.Create(" ", 2513), Tuple.Create("row", 2514), true)
            
            #line 68 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
, Tuple.Create(Tuple.Create(" ", 2517), Tuple.Create<System.Object, System.Int32>(isPulledRight
            
            #line default
            #line hidden
, 2518), false)
);

WriteLiteral(">\n");

            
            #line 69 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                
            
            #line default
            #line hidden
            
            #line 69 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                 if (Model.ShowRememberMe)
                {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"checkbox col-md-6 sf-m-xxs\"");

WriteLiteral(">\n                    <label>\n");

WriteLiteral("                        ");

            
            #line 73 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                   Write(Html.CheckBoxFor(u => u.RememberMe));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                        ");

            
            #line 74 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                   Write(Html.Resource("RememberMe"));

            
            #line default
            #line hidden
WriteLiteral("\n                    </label>\n                </div>\n");

            
            #line 77 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 78 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                 if (Model.ShowForgotPasswordLink)
                {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"text-right sf-pr-l\"");

WriteLiteral(">\n");

WriteLiteral("                    ");

            
            #line 81 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
               Write(Html.ActionLink(Html.Resource("ForgottenPasword"), "ForgotPassword"));

            
            #line default
            #line hidden
WriteLiteral("\n                </div>\n");

            
            #line 83 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\n");

            
            #line 85 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\n\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n\t\t\t\t<button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 88 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                         Write(Html.Resource("LoginFormLogInButton"));

            
            #line default
            #line hidden
WriteLiteral("</button>\n\t\t\t</div>\n\n");

            
            #line 91 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
            
            
            #line default
            #line hidden
            
            #line 91 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
             if (Model.ShowRegistrationLink)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"sf-registration-link\"");

WriteLiteral(">\n                    <div>");

            
            #line 94 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                    Write(Html.Resource("NotRegisteredYet"));

            
            #line default
            #line hidden
WriteLiteral("</div>\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3486), Tuple.Create("\"", 3515)
            
            #line 95 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
, Tuple.Create(Tuple.Create("", 3493), Tuple.Create<System.Object, System.Int32>(Model.RegisterPageUrl
            
            #line default
            #line hidden
, 3493), false)
);

WriteLiteral(">");

            
            #line 95 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                Write(Html.Resource("LoginFormRegisterNow"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n                </div>\n");

            
            #line 97 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            </div>\n");

            
            #line 99 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
        
            if (Model.ExternalProviders != null && Model.ExternalProviders.Count() > 0)
            {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">                \n                <h3>");

            
            #line 103 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
               Write(Html.Resource("UseAccountIn"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n\n");

            
            #line 105 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                
            
            #line default
            #line hidden
            
            #line 105 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                 foreach (var provider in Model.ExternalProviders)
                { 
                    var classToBeAdd = "btn btn-default btn-lg btn-block " + @provider.Value;                 
                    
            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" class=\"sf-mb-xs\"");

WriteLiteral(">\n");

WriteLiteral("                        ");

            
            #line 109 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                   Write(Html.ActionLink(provider.Key, "LoginExternalProvider", new { model = provider.Key }, new { @class = classToBeAdd }));

            
            #line default
            #line hidden
WriteLiteral("\n                    </div>\n");

            
            #line 111 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\n");

            
            #line 113 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
            }
		
        }
    }
    
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <p>");

            
            #line 120 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
      Write(Html.Resource("AlreadyLoggedIn"));

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 121 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\n\n");

            
            #line 124 "..\..\ResourcePackages\Bootstrap\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/LoginForm/login-form.js"), "bottom"));

            
            #line default
            #line hidden
WriteLiteral("\n");

        }
    }
}
#pragma warning restore 1591
