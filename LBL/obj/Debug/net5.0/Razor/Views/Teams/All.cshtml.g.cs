#pragma checksum "D:\Programming\LBL_Project2\LBL\LBL\Views\Teams\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e093c2684f6e0da507ca3b6bff0156ff15a9d281"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teams_All), @"mvc.1.0.view", @"/Views/Teams/All.cshtml")]
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
#line 1 "D:\Programming\LBL_Project2\LBL\LBL\Views\_ViewImports.cshtml"
using LBL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programming\LBL_Project2\LBL\LBL\Views\_ViewImports.cshtml"
using LBL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Programming\LBL_Project2\LBL\LBL\Views\_ViewImports.cshtml"
using LBL.Models.Teams;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Programming\LBL_Project2\LBL\LBL\Views\_ViewImports.cshtml"
using LBL.Models.Article;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Programming\LBL_Project2\LBL\LBL\Views\_ViewImports.cshtml"
using LBL.Models.Columnists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Programming\LBL_Project2\LBL\LBL\Views\_ViewImports.cshtml"
using LBL.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Programming\LBL_Project2\LBL\LBL\Views\_ViewImports.cshtml"
using LBL.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Programming\LBL_Project2\LBL\LBL\Views\_ViewImports.cshtml"
using LBL.Services.Articles;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e093c2684f6e0da507ca3b6bff0156ff15a9d281", @"/Views/Teams/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90716c5094858e2233e50af7e0dc69695400852c", @"/Views/_ViewImports.cshtml")]
    public class Views_Teams_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LBL.Data.Models.TeamListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Teams", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none; color:black;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\Programming\LBL_Project2\LBL\LBL\Views\Teams\All.cshtml"
  
    ViewData["Title"] = "All teams";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row justify-content-center"">
    <div class=""dropdown"">
        <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            Dropdown button
        </button>
        <div class=""dropdown-menu"">
            <h6 class=""dropdown-header"">Dropdown header</h6>
            <a class=""dropdown-item"" href=""#""><img src=""LBL_logo2.png"" />Action</a>
            <a class=""dropdown-item"" href=""#"">Another action</a>
        </div>
    </div>

</div>
<div class=""row justify-content-center"">

");
#nullable restore
#line 22 "D:\Programming\LBL_Project2\LBL\LBL\Views\Teams\All.cshtml"
     foreach (var team in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e093c2684f6e0da507ca3b6bff0156ff15a9d2816078", async() => {
                WriteLiteral(@"
            <div class=""row m-2"" style=""background: linear-gradient(45deg,#1ea8c1, #952c07); "">
                <div class=""card"" style=""width: 18rem; height:22rem"">
                    <div style=""height:85%"">
                        <img class=""card-img-top mw-50""");
                BeginWriteAttribute("src", " src=\"", 1125, "\"", 1144, 1);
#nullable restore
#line 28 "D:\Programming\LBL_Project2\LBL\LBL\Views\Teams\All.cshtml"
WriteAttributeValue("", 1131, team.LogoURL, 1131, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1145, "\"", 1177, 4);
                WriteAttributeValue("", 1151, "[", 1151, 1, true);
#nullable restore
#line 28 "D:\Programming\LBL_Project2\LBL\LBL\Views\Teams\All.cshtml"
WriteAttributeValue("", 1152, team.Tag, 1152, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1161, "]", 1161, 1, true);
#nullable restore
#line 28 "D:\Programming\LBL_Project2\LBL\LBL\Views\Teams\All.cshtml"
WriteAttributeValue(" ", 1162, team.FullName, 1163, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    </div>\n                    <div class=\"card-body align-text-bottom text-center\" style=\"height:15%\">\n                        <p class=\"card-text \"><b>[");
#nullable restore
#line 31 "D:\Programming\LBL_Project2\LBL\LBL\Views\Teams\All.cshtml"
                                             Write(team.Tag);

#line default
#line hidden
#nullable disable
                WriteLiteral("]</b> ");
#nullable restore
#line 31 "D:\Programming\LBL_Project2\LBL\LBL\Views\Teams\All.cshtml"
                                                            Write(team.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                    </div>\n                </div>\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "D:\Programming\LBL_Project2\LBL\LBL\Views\Teams\All.cshtml"
                                                         WriteLiteral(team.Id);

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
            WriteLiteral("\n");
#nullable restore
#line 36 "D:\Programming\LBL_Project2\LBL\LBL\Views\Teams\All.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LBL.Data.Models.TeamListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
