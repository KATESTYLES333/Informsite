#pragma checksum "D:\Q84\InformSite\InformSite\Views\Projects\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f08a4496399d46695022299c844a26c5c4000451"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Details), @"mvc.1.0.view", @"/Views/Projects/Details.cshtml")]
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
#line 1 "D:\Q84\InformSite\InformSite\Views\_ViewImports.cshtml"
using InformSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Q84\InformSite\InformSite\Views\Projects\Details.cshtml"
using InformSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f08a4496399d46695022299c844a26c5c4000451", @"/Views/Projects/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6733bc56f887d19f96e582e210c70257af8576ee", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Projects_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Q84\InformSite\InformSite\Views\Projects\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Команда ");
#nullable restore
#line 12 "D:\Q84\InformSite\InformSite\Views\Projects\Details.cshtml"
           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <hr />\r\n    <dl>\r\n        <dt>Название</dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 18 "D:\Q84\InformSite\InformSite\Views\Projects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>Игроки</dt>\r\n\r\n        <dd>\r\n            <ul>\r\n");
#nullable restore
#line 25 "D:\Q84\InformSite\InformSite\Views\Projects\Details.cshtml"
                 foreach (Project project in Model.Projects)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 27 "D:\Q84\InformSite\InformSite\Views\Projects\Details.cshtml"
                   Write(project.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 27 "D:\Q84\InformSite\InformSite\Views\Projects\Details.cshtml"
                                  Write(project.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</li>\r\n");
#nullable restore
#line 28 "D:\Q84\InformSite\InformSite\Views\Projects\Details.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Category> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591