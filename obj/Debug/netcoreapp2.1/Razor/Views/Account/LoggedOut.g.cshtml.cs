#pragma checksum "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Account\LoggedOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2e770681e8092dc2b750e9b4f41c011774568ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_LoggedOut), @"mvc.1.0.view", @"/Views/Account/LoggedOut.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/LoggedOut.cshtml", typeof(AspNetCore.Views_Account_LoggedOut))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\_ViewImports.cshtml"
using MXP.IdentityServer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2e770681e8092dc2b750e9b4f41c011774568ff", @"/Views/Account/LoggedOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acccf017d37f95cccdf4a8ec7a0a22cd05228b14", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_LoggedOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MXP.IdentityServer.Controllers.Account.LoggedOutViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signout-redirect.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Account\LoggedOut.cshtml"
  
    // set this so the layout rendering sees an anonymous user
    ViewData["signed-out"] = true;

#line default
#line hidden
            BeginContext(168, 277, true);
            WriteLiteral(@"<div class=""content-box col-sm-4 col-md-5"">
    <div class=""header"">
        Logout
    </div>
    <div class=""row"">
        <div class=""col-12"">
            <p>You are now logged out.</p>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-12"">
");
            EndContext();
#line 17 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Account\LoggedOut.cshtml"
             if (Model.PostLogoutRedirectUri != null)
            {

#line default
#line hidden
            BeginContext(515, 86, true);
            WriteLiteral("                <div>\r\n                    Click <a class=\"PostLogoutRedirectUri link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 601, "\"", 636, 1);
#line 20 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Account\LoggedOut.cshtml"
WriteAttributeValue("", 608, Model.PostLogoutRedirectUri, 608, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(637, 54, true);
            WriteLiteral(">here</a> to return to the\r\n                    <span>");
            EndContext();
            BeginContext(692, 16, false);
#line 21 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Account\LoggedOut.cshtml"
                     Write(Model.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(708, 46, true);
            WriteLiteral("</span> application.\r\n                </div>\r\n");
            EndContext();
#line 23 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Account\LoggedOut.cshtml"
            }

#line default
#line hidden
            BeginContext(769, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 24 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Account\LoggedOut.cshtml"
             if (Model.SignOutIframeUrl != null)
            {

#line default
#line hidden
            BeginContext(834, 60, true);
            WriteLiteral("                <iframe width=\"0\" height=\"0\" class=\"signout\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 894, "\"", 923, 1);
#line 26 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Account\LoggedOut.cshtml"
WriteAttributeValue("", 900, Model.SignOutIframeUrl, 900, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(924, 12, true);
            WriteLiteral("></iframe>\r\n");
            EndContext();
#line 27 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Account\LoggedOut.cshtml"
            }

#line default
#line hidden
            BeginContext(951, 35, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1008, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 33 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Account\LoggedOut.cshtml"
     if (Model.AutomaticRedirectAfterSignOut)
    {

#line default
#line hidden
                BeginContext(1061, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(1069, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ac5dbcffffb4cdaa7b08e310b1425bf", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1117, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 36 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Account\LoggedOut.cshtml"
    }

#line default
#line hidden
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MXP.IdentityServer.Controllers.Account.LoggedOutViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
