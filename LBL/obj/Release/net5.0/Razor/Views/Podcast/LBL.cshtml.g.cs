#pragma checksum "D:\Programming\LBL_Project\LBL\LBL\Views\Podcast\LBL.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "416dc01a0f49bb62e2157d6d45b3d821b8343358"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Podcast_LBL), @"mvc.1.0.view", @"/Views/Podcast/LBL.cshtml")]
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
using LBL.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"416dc01a0f49bb62e2157d6d45b3d821b8343358", @"/Views/Podcast/LBL.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67ec12ea5456206a17a5e19cf1a94fed43fd8fce", @"/Views/_ViewImports.cshtml")]
    public class Views_Podcast_LBL : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Programming\LBL_Project\LBL\LBL\Views\Podcast\LBL.cshtml"
  
ViewData["Title"] = "Podcast";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row align-items-center text-center col-12"">
    <div class=""text-center"">
        <h1>Follow our official podcast</h1>
    </div>
    <iframe src=""https://open.spotify.com/embed-podcast/show/6SQX8ycr77olL9LesaOCEn"" width=""100%"" height=""232"" frameborder=""0"" allowtransparency=""true"" allow=""encrypted-media""></iframe>
</div>");
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
