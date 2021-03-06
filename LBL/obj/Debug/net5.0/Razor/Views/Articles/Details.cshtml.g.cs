#pragma checksum "D:\Programming\LBL_Project\LBL\LBL\Views\Articles\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bf5e6e8e3423cd005a3d28c60c6d5495c56cc91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articles_Details), @"mvc.1.0.view", @"/Views/Articles/Details.cshtml")]
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
#line 1 "D:\Programming\LBL_Project\LBL\LBL\Views\_ViewImports.cshtml"
using LBL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programming\LBL_Project\LBL\LBL\Views\_ViewImports.cshtml"
using LBL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Programming\LBL_Project\LBL\LBL\Views\_ViewImports.cshtml"
using LBL.Models.Teams;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Programming\LBL_Project\LBL\LBL\Views\_ViewImports.cshtml"
using LBL.Models.Article;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Programming\LBL_Project\LBL\LBL\Views\_ViewImports.cshtml"
using LBL.Models.Columnists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Programming\LBL_Project\LBL\LBL\Views\_ViewImports.cshtml"
using LBL.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Programming\LBL_Project\LBL\LBL\Views\_ViewImports.cshtml"
using LBL.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Programming\LBL_Project\LBL\LBL\Views\_ViewImports.cshtml"
using LBL.Services.Articles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Programming\LBL_Project\LBL\LBL\Views\_ViewImports.cshtml"
using LBL.Services.Teams.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Programming\LBL_Project\LBL\LBL\Views\_ViewImports.cshtml"
using LBL.Services.Columnists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Programming\LBL_Project\LBL\LBL\Views\_ViewImports.cshtml"
using LBL.Infrastructure.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Programming\LBL_Project\LBL\LBL\Views\Articles\Details.cshtml"
using System.Web.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bf5e6e8e3423cd005a3d28c60c6d5495c56cc91", @"/Views/Articles/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f402e3260ed7529333983b41ca6f7f6f5d6be09", @"/Views/_ViewImports.cshtml")]
    public class Views_Articles_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LBL.Services.Articles.ArticleDetailsServiceModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Programming\LBL_Project\LBL\LBL\Views\Articles\Details.cshtml"
   ViewData["Title"] = Model.Title; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row justify-content-center text-center col-12 mb-5\">\r\n    <h1>");
#nullable restore
#line 7 "D:\Programming\LBL_Project\LBL\LBL\Views\Articles\Details.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n\r\n<div>\r\n    <p>\r\n");
            WriteLiteral("        <span style=\"white-space: pre-wrap\">");
#nullable restore
#line 13 "D:\Programming\LBL_Project\LBL\LBL\Views\Articles\Details.cshtml"
                                       Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("    </p>\r\n\r\n    <p>Author: <b>\r\n");
#nullable restore
#line 18 "D:\Programming\LBL_Project\LBL\LBL\Views\Articles\Details.cshtml"
     foreach (var name in Model.AuthorNames)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Programming\LBL_Project\LBL\LBL\Views\Articles\Details.cshtml"
    Write(name.FirstName + " " + name.LastName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Programming\LBL_Project\LBL\LBL\Views\Articles\Details.cshtml"
                                               
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n    </p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LBL.Services.Articles.ArticleDetailsServiceModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
