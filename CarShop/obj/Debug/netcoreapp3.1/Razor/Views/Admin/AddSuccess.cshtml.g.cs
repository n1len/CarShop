#pragma checksum "C:\Git\CarShop\CarShop\Views\Admin\AddSuccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b0b5b49642b294e61068434e113c00a2d03862c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AddSuccess), @"mvc.1.0.view", @"/Views/Admin/AddSuccess.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b0b5b49642b294e61068434e113c00a2d03862c", @"/Views/Admin/AddSuccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe4c0d735d051fba12fbf7807849e7c1ea31600c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AddSuccess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Git\CarShop\CarShop\Views\Admin\AddSuccess.cshtml"
  
    ViewData["Title"] = "Машина добавлена";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Git\CarShop\CarShop\Views\Admin\AddSuccess.cshtml"
 if (User.Identity.IsAuthenticated)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Git\CarShop\CarShop\Views\Admin\AddSuccess.cshtml"
     if (User.Identity.Name == "admin")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""container"">
            <div class=""row"">
                <div class=""col"">
                    <div class=""card shadow-sm"">
                        <div class=""card-body"">
                            <h6 class=""card-text text-center"">Добавлена машина новая машина</h6>
                        </div>
                    </div>
                </div>
            </div>
        </div>
");
#nullable restore
#line 22 "C:\Git\CarShop\CarShop\Views\Admin\AddSuccess.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Git\CarShop\CarShop\Views\Admin\AddSuccess.cshtml"
     
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<object> Html { get; private set; }
    }
}
#pragma warning restore 1591
