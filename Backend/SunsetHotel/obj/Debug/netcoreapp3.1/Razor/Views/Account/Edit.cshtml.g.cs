#pragma checksum "C:\Users\Kanan Qarazada\Desktop\SunsetHotel\SunsetHotel\Views\Account\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fb42f6c5ff3803a3680b0fb10c91c8832469391"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Edit), @"mvc.1.0.view", @"/Views/Account/Edit.cshtml")]
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
#line 1 "C:\Users\Kanan Qarazada\Desktop\SunsetHotel\SunsetHotel\Views\_ViewImports.cshtml"
using SunsetHotel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fb42f6c5ff3803a3680b0fb10c91c8832469391", @"/Views/Account/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14189537d00d9e46897aa2ebcdf268809c9bf631", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formsendemail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contacts__form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Kanan Qarazada\Desktop\SunsetHotel\SunsetHotel\Views\Account\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""section__contacts-alt"" style=""background-image: url(../assets/img/slide_bg_1.jpg);"">
    <div class=""container"">
        <div class="" row"">
            <div style=""width: 70%; margin:auto;"">
                <div class=""section-contacts__form_body"">
                    <p class=""section-contacts__title"">Edit personal info</p>

                    <!-- Alert message -->
                    <div class=""alert"" id=""form_message"" role=""alert""></div>

                    <!-- Form -->
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fb42f6c5ff3803a3680b0fb10c91c88324693914527", async() => {
                WriteLiteral(@"

                        <!-- Email -->
                        <div class=""form-group"">
                            <label for=""username"" class=""sr-only"">Username</label>
                            <input type=""text"" name=""email"" class=""form-control"" id=""username""
                                   placeholder=""Enter your username"" required>
                            <span class=""help-block""></span>
                        </div>

                        <div class=""form-group"">
                            <label for=""username"" class=""sr-only"">Phone</label>
                            <input");
                BeginWriteAttribute("type", " type=\"", 1237, "\"", 1244, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""email"" class=""form-control"" id=""username""
                                   placeholder=""Enter your phone number"" required>
                            <span class=""help-block""></span>
                        </div>

                        <div class=""form-group"">
                            <label for=""username"" class=""sr-only"">Country</label>
                            <input type=""text"" name=""email"" class=""form-control"" id=""username""
                                   placeholder=""Enter your country"" required>
                            <span class=""help-block""></span>
                        </div>
                        <div class=""form-group"">
                            <label for=""username"" class=""sr-only"">City</label>
                            <input type=""text"" name=""email"" class=""form-control"" id=""username""
                                   placeholder=""Enter your city"" required>
                            <span class=""help-block""></span>
                        </di");
                WriteLiteral(@"v>

                        <div class=""form-group"">
                            <label for=""newpass"" class=""sr-only"">New password</label>
                            <input type=""password"" name=""name"" class=""form-control"" id=""newpass""
                                   placeholder=""Enter your new password"" required>
                            <span class=""help-block""></span>
                        </div>

                        <div class=""form-group"">
                            <label for=""repass"" class=""sr-only"">Repeat password</label>
                            <input type=""password"" name=""name"" class=""form-control"" id=""repass""
                                   placeholder=""Repeat new password"" required>
                            <span class=""help-block""></span>
                        </div>

                        <div class=""form-group"">
                            <label for=""password"" class=""sr-only"">Password</label>
                            <input type=""password"" name=""");
                WriteLiteral(@"name"" class=""form-control"" id=""password""
                                   placeholder=""Enter your current password"" required>
                            <span class=""help-block""></span>
                        </div>


                        <!-- Submit -->
                        <button type=""submit"" class=""btn btn-default"">
                            Save
                        </button>

                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <!-- .contacts__form -->\r\n\r\n                </div> <!-- / .section-contacts__form_body -->\r\n            </div>\r\n        </div> <!-- / .row -->\r\n    </div> <!-- / .container -->\r\n</section> <!-- / .section__contacts-alt -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
