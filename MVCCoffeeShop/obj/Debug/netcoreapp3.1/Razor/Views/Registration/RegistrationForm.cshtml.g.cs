#pragma checksum "C:\Users\kyleg\source\repos\MVCCoffeeShop\MVCCoffeeShop\Views\Registration\RegistrationForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "589c35c9af9e23005f3c3008a6cab59e1c8ed893"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registration_RegistrationForm), @"mvc.1.0.view", @"/Views/Registration/RegistrationForm.cshtml")]
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
#nullable restore
#line 1 "C:\Users\kyleg\source\repos\MVCCoffeeShop\MVCCoffeeShop\Views\_ViewImports.cshtml"
using MVCCoffeeShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kyleg\source\repos\MVCCoffeeShop\MVCCoffeeShop\Views\_ViewImports.cshtml"
using MVCCoffeeShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"589c35c9af9e23005f3c3008a6cab59e1c8ed893", @"/Views/Registration/RegistrationForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66fc9a3a3ea220384b574b6002d438fbe74d2f71", @"/Views/_ViewImports.cshtml")]
    public class Views_Registration_RegistrationForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("../Registration/DisplayUser"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\kyleg\source\repos\MVCCoffeeShop\MVCCoffeeShop\Views\Registration\RegistrationForm.cshtml"
  
    ViewData["Title"] = "RegistrationForm";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<h1>User Registration Form</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "589c35c9af9e23005f3c3008a6cab59e1c8ed8934327", async() => {
                WriteLiteral("\r\n    <div class=\"d-flex justify-content-left\">\r\n\r\n        <input class=\"p-2\" type=\"text\" name=\"UserName\"");
                BeginWriteAttribute("value", " value=\"", 278, "\"", 301, 1);
#nullable restore
#line 14 "C:\Users\kyleg\source\repos\MVCCoffeeShop\MVCCoffeeShop\Views\Registration\RegistrationForm.cshtml"
WriteAttributeValue("", 286, Model.UserName, 286, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Name\" required />\r\n\r\n        <input class=\"p-2\" type=\"text\" name=\"Email\"");
                BeginWriteAttribute("value", " value=\"", 388, "\"", 408, 1);
#nullable restore
#line 16 "C:\Users\kyleg\source\repos\MVCCoffeeShop\MVCCoffeeShop\Views\Registration\RegistrationForm.cshtml"
WriteAttributeValue("", 396, Model.Email, 396, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Email\"\r\n               required");
                BeginWriteAttribute("pattern", " pattern=\"", 454, "\"", 517, 3);
                WriteAttributeValue("", 464, "^[a-zA-Z0-9._+-]+", 464, 17, true);
#nullable restore
#line 17 "C:\Users\kyleg\source\repos\MVCCoffeeShop\MVCCoffeeShop\Views\Registration\RegistrationForm.cshtml"
WriteAttributeValue("", 481, "@", 481, 6, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 487, "[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,4}$", 487, 30, true);
                EndWriteAttribute();
                WriteLiteral("\r\n               oninvalid=\"this.setCustomValidity(\'Please enter a valid email\')\"\r\n               oninput=\"this.setCustomValidity(\'\')\" />\r\n\r\n        <input class=\"p-2\" type=\"password\" name=\"Password\"");
                BeginWriteAttribute("value", " value=\"", 717, "\"", 725, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Password""
               required pattern=""^(?=.*\d).{8,}$""
               oninvalid=""this.setCustomValidity('Password must be at least 8 characters long and include at least one numeric digit.')""
               oninput=""this.setCustomValidity('')"" />
        <br /> <br />

        <input class=""btn btn-primary"" type=""submit"" />
    </div>

");
#nullable restore
#line 30 "C:\Users\kyleg\source\repos\MVCCoffeeShop\MVCCoffeeShop\Views\Registration\RegistrationForm.cshtml"
     if (Model.UserName != null || Model.Email != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"alert alert-danger\" style=\"margin-top:5px\">\r\n            <table>\r\n                <tr>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\kyleg\source\repos\MVCCoffeeShop\MVCCoffeeShop\Views\Registration\RegistrationForm.cshtml"
                   Write(Html.ValidationMessageFor(m => m.UserName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "C:\Users\kyleg\source\repos\MVCCoffeeShop\MVCCoffeeShop\Views\Registration\RegistrationForm.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "C:\Users\kyleg\source\repos\MVCCoffeeShop\MVCCoffeeShop\Views\Registration\RegistrationForm.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n            </table>\r\n        </div>\r\n");
#nullable restore
#line 41 "C:\Users\kyleg\source\repos\MVCCoffeeShop\MVCCoffeeShop\Views\Registration\RegistrationForm.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
