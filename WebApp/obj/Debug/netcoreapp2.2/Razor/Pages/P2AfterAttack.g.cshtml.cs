#pragma checksum "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2AfterAttack.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4a7ad92361294d035a2542e77e1b0e350723517"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApp.Pages.Pages_P2AfterAttack), @"mvc.1.0.razor-page", @"/Pages/P2AfterAttack.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/P2AfterAttack.cshtml", typeof(WebApp.Pages.Pages_P2AfterAttack), null)]
namespace WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#line 2 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2AfterAttack.cshtml"
using Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4a7ad92361294d035a2542e77e1b0e350723517", @"/Pages/P2AfterAttack.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56255396305d1d1888ad93afc9c47568e44a4220", @"/Pages/_ViewImports.cshtml")]
    public class Pages_P2AfterAttack : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2AfterAttack.cshtml"
  
    ViewData["Title"] = "Player 2 attack result";

#line default
#line hidden
            BeginContext(107, 2623, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4a7ad92361294d035a2542e77e1b0e3507235173785", async() => {
                BeginContext(113, 2, true);
                WriteLiteral("\n\n");
                EndContext();
#line 9 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2AfterAttack.cshtml"
 if (Domain.GameBoard.hitMiss == BoardSquareState.Hit)
{

#line default
#line hidden
                BeginContext(172, 18, true);
                WriteLiteral("    <h3>Hit!</h3>\n");
                EndContext();
#line 12 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2AfterAttack.cshtml"
}
else
{

#line default
#line hidden
                BeginContext(199, 19, true);
                WriteLiteral("    <h3>Miss!</h3>\n");
                EndContext();
#line 16 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2AfterAttack.cshtml"
}

#line default
#line hidden
                BeginContext(220, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 18 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2AfterAttack.cshtml"
 if (Domain.GameBoard.shipSquareCount == 0)
{
    Domain.GameBoard.gameOn = false;

#line default
#line hidden
                BeginContext(304, 44, true);
                WriteLiteral("    <h3>Congratulations! Player 2 won!</h3>\n");
                EndContext();
#line 22 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2AfterAttack.cshtml"

}

#line default
#line hidden
                BeginContext(351, 131, true);
                WriteLiteral("\n<h3>Player 2 enemy ships</h3>\n<table style=\"border: 1px solid black\">\n    <tr>\n        <td style=\"border: 1px solid black\"> </td>\n");
                EndContext();
#line 29 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2AfterAttack.cshtml"
         for (int a = 0; a < Domain.GameBoard.Player2Board2[0].Count; a++)
        {

#line default
#line hidden
                BeginContext(567, 48, true);
                WriteLiteral("            <td style=\"border: 1px solid black\">");
                EndContext();
                BeginContext(616, 28, false);
#line 31 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2AfterAttack.cshtml"
                                           Write(Domain.GameBoard.Alphabet[a]);

#line default
#line hidden
                EndContext();
                BeginContext(644, 6, true);
                WriteLiteral("</td>\n");
                EndContext();
#line 32 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2AfterAttack.cshtml"
        }

#line default
#line hidden
                BeginContext(660, 10, true);
                WriteLiteral("    </tr>\n");
                EndContext();
#line 34 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2AfterAttack.cshtml"
     for (int i = 0; i < Domain.GameBoard.Player2Board2.Count; i++)
    {

#line default
#line hidden
                BeginContext(744, 61, true);
                WriteLiteral("        <tr>\n            <td style=\"border: 1px solid black\">");
                EndContext();
                BeginContext(807, 5, false);
#line 37 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2AfterAttack.cshtml"
                                            Write(i + 1);

#line default
#line hidden
                EndContext();
                BeginContext(813, 7, true);
                WriteLiteral("</td>\n\n");
                EndContext();
#line 39 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2AfterAttack.cshtml"
             for (int j = 0; j < Domain.GameBoard.Player2Board2[i].Count; j++)
            {
                switch (Domain.GameBoard.Player2Board2[i][j])
                {
                    case BoardSquareState.Empty:

#line default
#line hidden
                BeginContext(1042, 119, true);
                WriteLiteral("                        <td style=\"border: 2px solid black; width: 50px; height: 50px; background-color:inherit\"></td>\n");
                EndContext();
#line 45 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2AfterAttack.cshtml"
                        break;
                    case BoardSquareState.Unknown:

#line default
#line hidden
                BeginContext(1243, 119, true);
                WriteLiteral("                        <td style=\"border: 2px solid black; width: 50px; height: 50px; background-color:inherit\"></td>\n");
                EndContext();
#line 48 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2AfterAttack.cshtml"
                        break;
                    case BoardSquareState.Ship:

#line default
#line hidden
                BeginContext(1441, 155, true);
                WriteLiteral("                        <td style=\"border: 2px solid black; width: 50px; height: 50px\"><img src=\"images/ship.png\" style=\"width: 50px; height: 50px\"/></td>\n");
                EndContext();
#line 51 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2AfterAttack.cshtml"
                        break;
                    case BoardSquareState.Hit:

#line default
#line hidden
                BeginContext(1674, 154, true);
                WriteLiteral("                        <td style=\"border: 2px solid black; width: 50px; height: 50px\"><img src=\"images/hit.png\" style=\"width: 50px; height: 50px\"/></td>\n");
                EndContext();
#line 54 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2AfterAttack.cshtml"
                        break;
                    case BoardSquareState.Miss:

#line default
#line hidden
                BeginContext(1907, 155, true);
                WriteLiteral("                        <td style=\"border: 2px solid black; width: 50px; height: 50px\"><img src=\"images/miss.png\" style=\"width: 50px; height: 50px\"/></td>\n");
                EndContext();
#line 57 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2AfterAttack.cshtml"
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

#line default
#line hidden
                BeginContext(2220, 14, true);
                WriteLiteral("        </tr>\n");
                EndContext();
#line 64 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2AfterAttack.cshtml"
    }

#line default
#line hidden
                BeginContext(2240, 13, true);
                WriteLiteral("</table>\n\n\n\n\n");
                EndContext();
#line 70 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2AfterAttack.cshtml"
 if (Domain.GameBoard.shipSquareCount == 0)
{

#line default
#line hidden
                BeginContext(2299, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(2303, 227, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4a7ad92361294d035a2542e77e1b0e35072351710753", async() => {
                    BeginContext(2323, 200, true);
                    WriteLiteral("\n        <div>\n            <div>\n                <label>&nbsp;</label>\n                <input type=\"submit\" value=\"Start new game\" class=\"btn btn-lg bg-danger\"/>\n            </div>\n        </div>\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2530, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 80 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2AfterAttack.cshtml"

}

else {

#line default
#line hidden
                BeginContext(2542, 177, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4a7ad92361294d035a2542e77e1b0e35072351712813", async() => {
                    BeginContext(2562, 150, true);
                    WriteLiteral("\n    <div>\n        <div>\n            <br/>\n            <input type=\"submit\" value=\"Continue\" class=\"btn btn-lg bg-danger\"/>\n        </div>\n    </div>\n");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2719, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 92 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2AfterAttack.cshtml"
}

#line default
#line hidden
                BeginContext(2722, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Player2AttackResultModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Player2AttackResultModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Player2AttackResultModel>)PageContext?.ViewData;
        public Player2AttackResultModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
