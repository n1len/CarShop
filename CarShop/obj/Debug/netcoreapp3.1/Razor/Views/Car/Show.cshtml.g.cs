#pragma checksum "C:\Git\CarShop\CarShop\Views\Car\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "166a3f7183d8676f192b425c89833d2b427d3d45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Show), @"mvc.1.0.view", @"/Views/Car/Show.cshtml")]
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
#line 1 "C:\Git\CarShop\CarShop\Views\_ViewImports.cshtml"
using CarShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Git\CarShop\CarShop\Views\_ViewImports.cshtml"
using CarShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"166a3f7183d8676f192b425c89833d2b427d3d45", @"/Views/Car/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe4c0d735d051fba12fbf7807849e7c1ea31600c", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarShop.Infrastructure.Models.Car>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ml-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Git\CarShop\CarShop\Views\Car\Show.cshtml"
  
    ViewData["Title"] = Model.Brand;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"card shadow-sm\">\r\n        <div class=\"card-body\">\r\n            <div>\r\n                <h4 class=\"card-text\"><strong>");
#nullable restore
#line 12 "C:\Git\CarShop\CarShop\Views\Car\Show.cshtml"
                                         Write(Model.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "C:\Git\CarShop\CarShop\Views\Car\Show.cshtml"
                                                      Write(Model.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> ");
#nullable restore
#line 12 "C:\Git\CarShop\CarShop\Views\Car\Show.cshtml"
                                                                            Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <p>\r\n                    Цена: ");
#nullable restore
#line 14 "C:\Git\CarShop\CarShop\Views\Car\Show.cshtml"
                     Write(Model.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "166a3f7183d8676f192b425c89833d2b427d3d456260", async() => {
                WriteLiteral("\r\n                        <button class=\"btn btn-danger btn-sm\" type=\"submit\">Добавить в корзину</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Git\CarShop\CarShop\Views\Car\Show.cshtml"
                                                                WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </p>
            </div>

            <h5 class=""card-text""><strong>Технические характеристики</strong></h5>
            <div class=""row border-bottom"">
                <div class=""col"">
                    <p class=""float-left"">Марка</p>
                    <p class=""float-right""><i>");
#nullable restore
#line 25 "C:\Git\CarShop\CarShop\Views\Car\Show.cshtml"
                                         Write(Model.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n                </div>\r\n                <div class=\"col\">\r\n                    <p class=\"float-left\">Модель</p>\r\n                    <p class=\"float-right\"><i>");
#nullable restore
#line 29 "C:\Git\CarShop\CarShop\Views\Car\Show.cshtml"
                                         Write(Model.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n                </div>\r\n            </div>\r\n            <div class=\"row border-bottom mt-3\">\r\n                <div class=\"col\">\r\n                    <p class=\"float-left\">Год</p>\r\n                    <p class=\"float-right\"><i>");
#nullable restore
#line 35 "C:\Git\CarShop\CarShop\Views\Car\Show.cshtml"
                                         Write(Model.Year.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n                </div>\r\n                <div class=\"col\">\r\n                    <p class=\"float-left\">Пробег</p>\r\n                    <p class=\"float-right\"><i>");
#nullable restore
#line 39 "C:\Git\CarShop\CarShop\Views\Car\Show.cshtml"
                                         Write(Model.Mileage.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("км</i></p>\r\n                </div>\r\n            </div>\r\n            <div class=\"row border-bottom mt-3\">\r\n                <div class=\"col\">\r\n                    <p class=\"float-left\">Тип двигателя</p>\r\n                    <p class=\"float-right\"><i>");
#nullable restore
#line 45 "C:\Git\CarShop\CarShop\Views\Car\Show.cshtml"
                                         Write(Model.EngineType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n                </div>\r\n                <div class=\"col\">\r\n                    <p class=\"float-left\">Объём двигателя</p>\r\n                    <p class=\"float-right\"><i>");
#nullable restore
#line 49 "C:\Git\CarShop\CarShop\Views\Car\Show.cshtml"
                                         Write(Model.EngineVolume.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n                </div>\r\n            </div>\r\n            <div class=\"row border-bottom mt-3\">\r\n                <div class=\"col\">\r\n                    <p class=\"float-left\">Тип кузова</p>\r\n                    <p class=\"float-right\"><i>");
#nullable restore
#line 55 "C:\Git\CarShop\CarShop\Views\Car\Show.cshtml"
                                         Write(Model.BodyType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n                </div>\r\n                <div class=\"col\">\r\n                    <p class=\"float-left\">Цвет</p>\r\n                    <p class=\"float-right\"><i>");
#nullable restore
#line 59 "C:\Git\CarShop\CarShop\Views\Car\Show.cshtml"
                                         Write(Model.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n                </div>\r\n            </div>\r\n            <div class=\"row border-bottom mt-3\">\r\n                <div class=\"col\">\r\n                    <p class=\"float-left\">КПП</p>\r\n                    <p class=\"float-right\"><i>");
#nullable restore
#line 65 "C:\Git\CarShop\CarShop\Views\Car\Show.cshtml"
                                         Write(Model.GearBox);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n                </div>\r\n                <div class=\"col\">\r\n                    <p class=\"float-left\">Привод</p>\r\n                    <p class=\"float-right\"><i>");
#nullable restore
#line 69 "C:\Git\CarShop\CarShop\Views\Car\Show.cshtml"
                                         Write(Model.DriveUnit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n                </div>\r\n            </div>\r\n            <h5 class=\"card-text mt-3\">Описание</h5>\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    <p>");
#nullable restore
#line 75 "C:\Git\CarShop\CarShop\Views\Car\Show.cshtml"
                  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 78 "C:\Git\CarShop\CarShop\Views\Car\Show.cshtml"
             if (User.Identity.IsAuthenticated)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Git\CarShop\CarShop\Views\Car\Show.cshtml"
                 if (User.Identity.Name == "admin")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"float-right\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3387, "\"", 3445, 1);
#nullable restore
#line 83 "C:\Git\CarShop\CarShop\Views\Car\Show.cshtml"
WriteAttributeValue("", 3394, Url.Action("Delete", "Admin", new {id = Model.Id}), 3394, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <button class=\"btn btn-danger my-2 my-sm-0\" type=\"submit\">Удалить</button>\r\n                        </a>\r\n                    </div>\r\n");
#nullable restore
#line 87 "C:\Git\CarShop\CarShop\Views\Car\Show.cshtml"
                    
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Git\CarShop\CarShop\Views\Car\Show.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"float-left\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "166a3f7183d8676f192b425c89833d2b427d3d4515296", async() => {
                WriteLiteral("\r\n                    <button class=\"btn btn-danger\">На главную страницу</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarShop.Infrastructure.Models.Car> Html { get; private set; }
    }
}
#pragma warning restore 1591
