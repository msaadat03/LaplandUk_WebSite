#pragma checksum "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Views\Tickets\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ac0f64bdb4aa9847dd42430d79f4b0c503bb009"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tickets_Index), @"mvc.1.0.view", @"/Views/Tickets/Index.cshtml")]
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
#line 1 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Views\_ViewImports.cshtml"
using Back_end;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Views\_ViewImports.cshtml"
using Back_end.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Views\_ViewImports.cshtml"
using Back_end.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Views\_ViewImports.cshtml"
using Back_end.ViewModels.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Views\_ViewImports.cshtml"
using Back_end.ViewModels.BasketViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ac0f64bdb4aa9847dd42430d79f4b0c503bb009", @"/Views/Tickets/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58bb5d90be4ea630ced87dbb11c8972f2149f78e", @"/Views/_ViewImports.cshtml")]
    public class Views_Tickets_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TicketsVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Views\Tickets\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(" <main>\r\n        <section id=\"tickets-title\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-12\">\r\n                        <div class=\"upper-title\">\r\n                            <p>");
#nullable restore
#line 12 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Views\Tickets\Index.cshtml"
                          Write(Model.TicketsTitles.UpperTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br>\r\n                        </div>\r\n\r\n                        <div class=\"title\">\r\n                            <h1>");
#nullable restore
#line 16 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Views\Tickets\Index.cshtml"
                           Write(Model.TicketsTitles.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        </div><br><br>\r\n\r\n                        <div class=\"content\">\r\n                            <p>");
#nullable restore
#line 20 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Views\Tickets\Index.cshtml"
                          Write(Model.TicketsTitles.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <section id=""tickets-card"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""cards"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8ac0f64bdb4aa9847dd42430d79f4b0c503bb0096137", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1046, "~/assets/images/tickets/", 1046, 24, true);
#nullable restore
#line 32 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Views\Tickets\Index.cshtml"
AddHtmlAttributeValue("", 1070, Model.TicketAbouts.Images, 1070, 26, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"upper-title\">\r\n                                <h1>");
#nullable restore
#line 34 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Views\Tickets\Index.cshtml"
                               Write(Model.TicketAbouts.UpperTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            </div>\r\n                            <div class=\"content\">\r\n                                <h2>");
#nullable restore
#line 37 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Views\Tickets\Index.cshtml"
                               Write(Model.TicketAbouts.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                <p>");
#nullable restore
#line 38 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Views\Tickets\Index.cshtml"
                              Write(Model.TicketAbouts.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </div>
                        </div>
                        <div class=""tickets-body"">

                        </div>
                    </div>
                </div>
            </div>
        </section>

        <section id=""faqs"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""booking-faqs"">
                            <h1>2023 Booking FAQs</h1>
                            <div class=""booking-about"">
                                <p>Here you'll find the answers you need for any questions about making a booking.
                                    For our full FAQs, please visit here.</p>
                            </div>

                        </div>
                    </div>

                    <div class=""col-12"">
                        <div class=""ticket-includes"">
");
#nullable restore
#line 65 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Views\Tickets\Index.cshtml"
                             foreach (var item in Model.Faqsses)
                           {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h2>");
#nullable restore
#line 67 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Views\Tickets\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <p>");
#nullable restore
#line 68 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Views\Tickets\Index.cshtml"
                          Write(Html.Raw(item.Desc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 69 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Views\Tickets\Index.cshtml"
                               
                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("                           \r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n    </main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TicketsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
