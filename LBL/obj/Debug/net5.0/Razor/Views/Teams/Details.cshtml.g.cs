#pragma checksum "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fd902122e89b7cae1f76de51037e613e0092ffa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teams_Details), @"mvc.1.0.view", @"/Views/Teams/Details.cshtml")]
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
#line 1 "G:\MinecraftMods\LBL_Project\LBL\Views\_ViewImports.cshtml"
using LBL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\MinecraftMods\LBL_Project\LBL\Views\_ViewImports.cshtml"
using LBL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\MinecraftMods\LBL_Project\LBL\Views\_ViewImports.cshtml"
using LBL.Models.Teams;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\MinecraftMods\LBL_Project\LBL\Views\_ViewImports.cshtml"
using LBL.Models.Article;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\MinecraftMods\LBL_Project\LBL\Views\_ViewImports.cshtml"
using LBL.Models.Columnists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\MinecraftMods\LBL_Project\LBL\Views\_ViewImports.cshtml"
using LBL.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\MinecraftMods\LBL_Project\LBL\Views\_ViewImports.cshtml"
using LBL.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\MinecraftMods\LBL_Project\LBL\Views\_ViewImports.cshtml"
using LBL.Services.Articles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\MinecraftMods\LBL_Project\LBL\Views\_ViewImports.cshtml"
using LBL.Services.Teams.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\MinecraftMods\LBL_Project\LBL\Views\_ViewImports.cshtml"
using LBL.Services.Columnists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "G:\MinecraftMods\LBL_Project\LBL\Views\_ViewImports.cshtml"
using LBL.Infrastructure.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fd902122e89b7cae1f76de51037e613e0092ffa", @"/Views/Teams/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"525767af5681ad781345a233ad65d0009e95561c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Teams_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeamDetailsServiceModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Teams", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
  
    ViewBag.Title = Model.TeamFullName;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row justify-content-center\">\r\n    <h2>\r\n        [");
#nullable restore
#line 9 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
    Write(Model.TeamTagName);

#line default
#line hidden
#nullable disable
            WriteLiteral("] ");
#nullable restore
#line 9 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
                        Write(Model.TeamFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 11 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
     if(User.IsAdmin()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fd902122e89b7cae1f76de51037e613e0092ffa6465", async() => {
                WriteLiteral("✍️");
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
#line 12 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
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
            WriteLiteral("\r\n");
#nullable restore
#line 13 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </h2>\r\n</div>\r\n<table class=\"col-12 text-center\">\r\n    <tr>\r\n\r\n        <td class=\"col-4\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 442, "\"", 462, 1);
#nullable restore
#line 20 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
WriteAttributeValue("", 448, Model.LogoURL, 448, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 463, "\"", 488, 1);
#nullable restore
#line 20 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
WriteAttributeValue("", 469, Model.TeamFullName, 469, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /><br/>\r\n            <p><b>");
#nullable restore
#line 21 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
             Write(Model.TeamFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n        </td>\r\n\r\n        <td class=\"col-9\">\r\n            <textarea readonly rows=\"8\" cols=\"80\" style=\"resize:none; border:none;\">\r\n                ");
#nullable restore
#line 26 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
           Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </textarea>\r\n        </td>\r\n\r\n    </tr>\r\n</table>\r\n\r\n<div id=\"accordion\">\r\n    <div class=\"card\">\r\n");
            WriteLiteral(@"        <div class=""card-header"" id=""headingOne"">
            <h5 class=""mb-0"">
                <button class=""btn btn-link"" data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">
                    Players
                </button>
            </h5>
        </div>
");
            WriteLiteral("        <div id=\"collapseOne\" class=\"collapse show\" aria-labelledby=\"headingOne\" data-parent=\"#accordion\">\r\n            <div class=\"card-body row justify-content-center\">\r\n");
#nullable restore
#line 46 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
                  int i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
                 foreach (var player in Model.StaffMembers)
                {
                    i++;
                    if (i == 6) break;


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card\" style=\"width: 13rem;\">\r\n                        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 1651, "\"", 1673, 1);
#nullable restore
#line 53 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
WriteAttributeValue("", 1657, player.ImageURL, 1657, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1674, "\"", 1691, 1);
#nullable restore
#line 53 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
WriteAttributeValue("", 1680, player.IGN, 1680, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"card-body text-center\">\r\n                            <p class=\"card-text\">");
#nullable restore
#line 55 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
                                            Write(player.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 55 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
                                                              Write(player.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p><b>");
#nullable restore
#line 56 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
                             Write(player.IGN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 59 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"card\">\r\n");
            WriteLiteral(@"        <div class=""card-header"" id=""headingTwo"">
            <h5 class=""mb-0"">
                <button class=""btn btn-link collapsed"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">
                    Substitutes
                </button>
            </h5>
        </div>
");
            WriteLiteral("        <div id=\"collapseTwo\" class=\"collapse\" aria-labelledby=\"headingTwo\" data-parent=\"#accordion\">\r\n            <div class=\"card-body row\">\r\n");
#nullable restore
#line 75 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
                 foreach (var player in Model.StaffMembers)
                {
                    if (player.Position == "Substitute")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card\" style=\"width: 13rem;\">\r\n                            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 2855, "\"", 2877, 1);
#nullable restore
#line 80 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
WriteAttributeValue("", 2861, player.ImageURL, 2861, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2878, "\"", 2895, 1);
#nullable restore
#line 80 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
WriteAttributeValue("", 2884, player.IGN, 2884, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"card-body text-center\">\r\n                                <p class=\"card-text\">");
#nullable restore
#line 82 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
                                                Write(player.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 82 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
                                                                  Write(player.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p><b>");
#nullable restore
#line 83 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
                                 Write(player.IGN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 86 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"card\">\r\n");
            WriteLiteral(@"        <div class=""card-header"" id=""headingThree"">
            <h5 class=""mb-0"">
                <button class=""btn btn-link collapsed"" data-toggle=""collapse"" data-target=""#collapseThree"" aria-expanded=""false"" aria-controls=""collapseTwo"">
                    Coaching staff
                </button>
            </h5>
        </div>
");
            WriteLiteral("        <div id=\"collapseThree\" class=\"collapse\" aria-labelledby=\"headingThree\" data-parent=\"#accordion\">\r\n            <div class=\"card-body row\">\r\n");
#nullable restore
#line 103 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
                 foreach (var player in Model.StaffMembers)
                {
                    if (player.Position == "Head Coach" ||
                        player.Position == "Strategic Coach" ||
                        player.Position == "Assistant Coach" ||
                        player.Position == "Coach" ||
                        player.Position == "Head Analyst" ||
                        player.Position =="Remote Analyst" ||
                        player.Position =="Analyst" ||
                        player.Position =="Data Engineer" ||
                        player.Position =="Streamer" ||
                        player.Position == "Owner")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card\" style=\"width: 13rem;\">\r\n                            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 4653, "\"", 4675, 1);
#nullable restore
#line 117 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
WriteAttributeValue("", 4659, player.ImageURL, 4659, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4676, "\"", 4693, 1);
#nullable restore
#line 117 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
WriteAttributeValue("", 4682, player.IGN, 4682, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"card-body text-center\">\r\n                                <p class=\"card-text\">");
#nullable restore
#line 119 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
                                                Write(player.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 119 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
                                                                  Write(player.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p><b>");
#nullable restore
#line 120 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
                                 Write(player.IGN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                                <p>Position: ");
#nullable restore
#line 121 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
                                        Write(player.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 124 "G:\MinecraftMods\LBL_Project\LBL\Views\Teams\Details.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeamDetailsServiceModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
