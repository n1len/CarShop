#pragma checksum "D:\Everything for work\My projects\111\CarShop\CarShop\Views\Search\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7de0161aad00a324b22d949b7fe713cdafe129c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Index), @"mvc.1.0.view", @"/Views/Search/Index.cshtml")]
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
#line 1 "D:\Everything for work\My projects\111\CarShop\CarShop\Views\_ViewImports.cshtml"
using CarShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Everything for work\My projects\111\CarShop\CarShop\Views\_ViewImports.cshtml"
using CarShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7de0161aad00a324b22d949b7fe713cdafe129c7", @"/Views/Search/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe4c0d735d051fba12fbf7807849e7c1ea31600c", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarShop.Infrastructure.Models.Car>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdvancedSearch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\Everything for work\My projects\111\CarShop\CarShop\Views\Search\Index.cshtml"
  
    ViewData["Title"] = "Результаты поиска";
    Layout = "_AccountLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "D:\Everything for work\My projects\111\CarShop\CarShop\Views\Search\Index.cshtml"
 if (!Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">\r\n        <b><i>По Вашему запросу ничего не найдено.</i></b>\r\n    </div>\r\n    <div class=\"text-center mt-2\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7de0161aad00a324b22d949b7fe713cdafe129c74722", async() => {
                WriteLiteral("\r\n            <button class=\"btn btn-danger\">В расширеный поиск</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 19 "D:\Everything for work\My projects\111\CarShop\CarShop\Views\Search\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
        <div class=""row"">
            <div class=""col"">
                <div class=""card shadow-sm"">
                    <div class=""card-body"">
                        <div class=""d-flex justify-content-center mt-1 ml-4"">
                            <div class=""row"">
");
#nullable restore
#line 29 "D:\Everything for work\My projects\111\CarShop\CarShop\Views\Search\Index.cshtml"
                                  
                                    foreach (var car in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"col-sm-auto mt-2 mb-4 ml-sm-2\">\r\n                                            <h5>");
#nullable restore
#line 33 "D:\Everything for work\My projects\111\CarShop\CarShop\Views\Search\Index.cshtml"
                                           Write(car.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "D:\Everything for work\My projects\111\CarShop\CarShop\Views\Search\Index.cshtml"
                                                      Write(car.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            <p>\r\n                                                ");
#nullable restore
#line 35 "D:\Everything for work\My projects\111\CarShop\CarShop\Views\Search\Index.cshtml"
                                           Write(car.BodyType);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 35 "D:\Everything for work\My projects\111\CarShop\CarShop\Views\Search\Index.cshtml"
                                                          Write(car.Year.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 35 "D:\Everything for work\My projects\111\CarShop\CarShop\Views\Search\Index.cshtml"
                                                                                Write(car.EngineType);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 35 "D:\Everything for work\My projects\111\CarShop\CarShop\Views\Search\Index.cshtml"
                                                                                                Write(car.EngineVolume.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 35 "D:\Everything for work\My projects\111\CarShop\CarShop\Views\Search\Index.cshtml"
                                                                                                                                   Write(car.Mileage.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("км\r\n                                                <br />\r\n                                                ");
#nullable restore
#line 37 "D:\Everything for work\My projects\111\CarShop\CarShop\Views\Search\Index.cshtml"
                                           Write(car.DriveUnit);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 37 "D:\Everything for work\My projects\111\CarShop\CarShop\Views\Search\Index.cshtml"
                                                           Write(car.GearBox);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 37 "D:\Everything for work\My projects\111\CarShop\CarShop\Views\Search\Index.cshtml"
                                                                         Write(car.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                <br />\r\n                                                <strong>");
#nullable restore
#line 39 "D:\Everything for work\My projects\111\CarShop\CarShop\Views\Search\Index.cshtml"
                                                   Write(car.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                                            </p>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 1702, "\"", 1754, 1);
#nullable restore
#line 41 "D:\Everything for work\My projects\111\CarShop\CarShop\Views\Search\Index.cshtml"
WriteAttributeValue("", 1709, Url.Action("Show", "Car", new {id = car.Id}), 1709, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <button class=\"btn btn-outline-success my-2 my-sm-0\" type=\"submit\">Подробнее</button>\r\n                                            </a>\r\n                                        </div>\r\n");
#nullable restore
#line 45 "D:\Everything for work\My projects\111\CarShop\CarShop\Views\Search\Index.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"mt-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7de0161aad00a324b22d949b7fe713cdafe129c711982", async() => {
                WriteLiteral("\r\n            <button class=\"btn btn-danger\">В расширеный поиск</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 59 "D:\Everything for work\My projects\111\CarShop\CarShop\Views\Search\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CarShop.Infrastructure.Models.Car>> Html { get; private set; }
    }
}
#pragma warning restore 1591