#pragma checksum "D:\Programming\LBL_Project\LBL\LBL\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd872697c673d5fa910b53fc9fca4be96614db20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd872697c673d5fa910b53fc9fca4be96614db20", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90716c5094858e2233e50af7e0dc69695400852c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Programming\LBL_Project\LBL\LBL\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
    <div class=""container"">
        <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
            <ol class=""carousel-indicators"">
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
            </ol>
            <div class=""carousel-inner"">
                <div class=""carousel-item active"">
                    <img class=""d-block w-100"" src=""https://cdn.wallpapersafari.com/33/48/tZ7FsX.jpg"" alt=""What is League of Legends"">
                    <div class=""carousel-caption d-none d-md-block"">
                        <h5>What is League of Legends</h5>
                        <p>...</p>
     ");
            WriteLiteral(@"               </div>
                </div>
                <div class=""carousel-item"">
                    <img class=""d-block w-100"" src=""https://esportsjunkie.com/wp-content/uploads/2019/11/League-of-Legends-Roster-LCS-2020.png"" alt=""League of Legends eSports"">
                    <div class=""carousel-caption d-none d-md-block"">
                        <h5>League of Legends Professional play</h5>
                        <p>...</p>
                    </div>
                </div>
                <div class=""carousel-item"">
                    <img class=""d-block w-100"" src=""https://i.imgur.com/H8fGYQA.png"" alt=""Korea of the Balkans"">
                    <div class=""carousel-caption d-none d-md-block"">
                        <h5>Bulgarians in LoL</h5>
                        <p>...</p>
                    </div>
                </div>
            </div>
            <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                <span class=""carousel-cont");
            WriteLiteral(@"rol-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>
    </div>
</div>
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
