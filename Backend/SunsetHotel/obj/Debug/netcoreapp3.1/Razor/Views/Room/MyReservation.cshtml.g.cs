#pragma checksum "C:\Users\Kanan Qarazada\Desktop\SunsetHotel\SunsetHotel\Views\Room\MyReservation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93bad4d740715fe4870522e43eaf4d0214a395d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Room_MyReservation), @"mvc.1.0.view", @"/Views/Room/MyReservation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93bad4d740715fe4870522e43eaf4d0214a395d3", @"/Views/Room/MyReservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14189537d00d9e46897aa2ebcdf268809c9bf631", @"/Views/_ViewImports.cshtml")]
    public class Views_Room_MyReservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/gallery_img1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Kanan Qarazada\Desktop\SunsetHotel\SunsetHotel\Views\Room\MyReservation.cshtml"
  
    ViewData["Title"] = "MyReservation";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- CONTENT
  ================================================== -->

<section class=""section__reservation"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-sm-12 col-md-12 col-xs-12"">
                <p class=""subheading"">Booking details</p>

                <div class=""booking__details-body for-reservation"">

                    <div>
                        <h2 class=""section__heading"">Selected room</h2>
                    </div>
                    <figure class=""room__details"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "93bad4d740715fe4870522e43eaf4d0214a395d35175", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                    </figure> <!-- / .room__details -->
                    <ul class=""details-info"">
                        <li>
                            <label>Check in</label>
                            <p>2017-04-09</p>
                        </li>
                        <li>
                            <label>Check out</label>
                            <p>2017-04-18</p>
                        </li>
                        <li>
                            <label>Adults</label>
                            <p>2 Person</p>
                        </li>
                        <li class=""total-price"">
                            <label>Total price</label>
                            <p>$ 515</p>
                        </li>
                        <li>
                            <label>Children</label>
                            <p>1 Chind</p>
                        </li>
                        <li>
                            <label>Nights</label>
                  ");
            WriteLiteral(@"          <p>9 Nights</p>
                        </li>
                        <li>
                            <label>Services</label>
                            <p>$ 65</p>
                        </li>
                        <li class=""badge-list-item"">
                            <label>Status</label>
                            <!-- <span class=""badge-own status-secondary"">Pending</span> -->
                            <!-- <span class=""badge-own status-success"">Accepted</span> -->
                            <span class=""badge-own status-error"">Rejected</span>
                        </li>
                    </ul>
                </div> <!-- .booking__details-body -->
                <div class=""booking__details-body for-reservation"">

                    <div>
                        <h2 class=""section__heading"">Selected room</h2>
                    </div>
                    <figure class=""room__details"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "93bad4d740715fe4870522e43eaf4d0214a395d38419", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                    </figure> <!-- / .room__details -->
                    <ul class=""details-info"">
                        <li>
                            <label>Check in</label>
                            <p>2017-04-09</p>
                        </li>
                        <li>
                            <label>Check out</label>
                            <p>2017-04-18</p>
                        </li>
                        <li>
                            <label>Adults</label>
                            <p>2 Person</p>
                        </li>
                        <li class=""total-price"">
                            <label>Total price</label>
                            <p>$ 515</p>
                        </li>
                        <li>
                            <label>Children</label>
                            <p>1 Chind</p>
                        </li>
                        <li>
                            <label>Nights</label>
                  ");
            WriteLiteral(@"          <p>9 Nights</p>
                        </li>
                        <li>
                            <label>Services</label>
                            <p>$ 65</p>
                        </li>
                        <li class=""badge-list-item"">
                            <label>Status</label>
                            <!-- <span class=""badge-own status-secondary"">Pending</span> -->
                            <span class=""badge-own status-success"">Accepted</span>
                            <!-- <span class=""badge-own status-error"">Rejected</span> -->
                        </li>


                    </ul>
                </div> <!-- .booking__details-body -->
                <div class=""booking__details-body for-reservation"">

                    <div>
                        <h2 class=""section__heading"">Selected room</h2>
                    </div>
                    <figure class=""room__details"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "93bad4d740715fe4870522e43eaf4d0214a395d311667", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                    </figure> <!-- / .room__details -->
                    <ul class=""details-info"">
                        <li>
                            <label>Check in</label>
                            <p>2017-04-09</p>
                        </li>
                        <li>
                            <label>Check out</label>
                            <p>2017-04-18</p>
                        </li>
                        <li>
                            <label>Adults</label>
                            <p>2 Person</p>
                        </li>
                        <li class=""total-price"">
                            <label>Total price</label>
                            <p>$ 515</p>
                        </li>
                        <li>
                            <label>Children</label>
                            <p>1 Chind</p>
                        </li>
                        <li>
                            <label>Nights</label>
                  ");
            WriteLiteral(@"          <p>9 Nights</p>
                        </li>
                        <li>
                            <label>Services</label>
                            <p>$ 65</p>
                        </li>
                        <li class=""badge-list-item"">
                            <label>Status</label>
                            <span class=""badge-own status-secondary"">Pending</span>
                            <!-- <span class=""badge-own status-success"">Accepted</span> -->
                            <!-- <span class=""badge-own status-error"">Rejected</span> -->
                        </li>


                    </ul>
                </div> <!-- .booking__details-body -->
            </div>

        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-12 pagination-part"" style=""justify-content: center;"">
            <nav aria-label=""Page navigation"">
                <ul class=""pagination"">
                    <li>
                        <a href=""#"" aria-label=""P");
            WriteLiteral(@"revious"">
                            <span aria-hidden=""true"">&laquo;</span>
                        </a>
                    </li>
                    <li><a href=""#"">1</a></li>
                    <li class=""active""><a href=""#"">2</a></li>
                    <li><a href=""#"">3</a></li>
                    <li><a href=""#"">4</a></li>
                    <li>
                        <a href=""#"" aria-label=""Next"">
                            <span aria-hidden=""true"">&raquo;</span>
                        </a>
                    </li>
                </ul>
            </nav>

        </div>
    </div> <!-- / .row -->
</section>

");
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
