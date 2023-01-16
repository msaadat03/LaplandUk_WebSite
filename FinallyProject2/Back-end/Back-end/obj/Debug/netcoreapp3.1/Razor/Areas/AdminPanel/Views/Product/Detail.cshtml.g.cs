#pragma checksum "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Areas\AdminPanel\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6c7d52dbb4b3b2b2b04cb6ffdc62f98a7ecf089"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Product_Detail), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Product/Detail.cshtml")]
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
#line 1 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Areas\AdminPanel\Views\_ViewImports.cshtml"
using Back_end.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Areas\AdminPanel\Views\_ViewImports.cshtml"
using Back_end.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Areas\AdminPanel\Views\_ViewImports.cshtml"
using Back_end.ViewModels.ProductViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Areas\AdminPanel\Views\_ViewImports.cshtml"
using Back_end.ViewModels.CategoryViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Areas\AdminPanel\Views\_ViewImports.cshtml"
using Back_end.ViewModels.SubCategoryViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6c7d52dbb4b3b2b2b04cb6ffdc62f98a7ecf089", @"/Areas/AdminPanel/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b0b3d2750f1e583773de4c42d02328ab3c53420", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius: 5px; width: 150px; height: 200px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""container"">
    <div class=""col-lg-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Product detail</h4>
                <div class=""table-responsive pt-3"">
                    <table class=""table table-bordered my-3"">
                        <thead>
                            <tr>
                                <th>
                                    Image
                                </th>
                                <th>
                                    Name
                                </th>
                                <th>
                                    Description
                                </th>
                                <th>
                                    Price
                                </th>
                                <th>
                                    Category
                                </th>
                           ");
            WriteLiteral(" </tr>\r\n                        </thead>\r\n                        <tbody>\r\n                            <tr>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b6c7d52dbb4b3b2b2b04cb6ffdc62f98a7ecf0896035", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1298, "~/assets/images/shop/products/", 1298, 30, true);
#nullable restore
#line 32 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Areas\AdminPanel\Views\Product\Detail.cshtml"
AddHtmlAttributeValue("", 1328, Model.Images.Where(m => m.IsMain).FirstOrDefault()?.Name, 1328, 57, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                                <td style=\"font-size: 25px;\">\r\n                                    ");
#nullable restore
#line 35 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Areas\AdminPanel\Views\Product\Detail.cshtml"
                               Write(Html.Raw(Model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td style=\"font-size: 18px;\">\r\n                                    ");
#nullable restore
#line 38 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Areas\AdminPanel\Views\Product\Detail.cshtml"
                               Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 41 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Areas\AdminPanel\Views\Product\Detail.cshtml"
                               Write(Html.Raw(Model.Price.ToString("N2")));

#line default
#line hidden
#nullable disable
            WriteLiteral("$\r\n                                </td>\r\n                                <td style=\"font-size: 18px;\">\r\n                                    ");
#nullable restore
#line 44 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Areas\AdminPanel\Views\Product\Detail.cshtml"
                               Write(Html.Raw(Model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <table class=""table table-bordered my-3"">
                        <thead>
                            <tr>
                                <th>
                                    Images
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>
");
#nullable restore
#line 60 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Areas\AdminPanel\Views\Product\Detail.cshtml"
                                     foreach (var image in Model.Images)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b6c7d52dbb4b3b2b2b04cb6ffdc62f98a7ecf08910491", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2833, "~/assets/images/shop/products/", 2833, 30, true);
#nullable restore
#line 62 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Areas\AdminPanel\Views\Product\Detail.cshtml"
AddHtmlAttributeValue("", 2863, image.Name, 2863, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 63 "C:\Users\Emil Abdullayev\Desktop\Sada2\FinallyProject2\Back-end\Back-end\Areas\AdminPanel\Views\Product\Detail.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
