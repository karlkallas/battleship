#pragma checksum "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2PlaceShips.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2178e2ebe43c17e111199345dd8e61c4ce93b7e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApp.Pages.Pages_P2PlaceShips), @"mvc.1.0.razor-page", @"/Pages/P2PlaceShips.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/P2PlaceShips.cshtml", typeof(WebApp.Pages.Pages_P2PlaceShips), null)]
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
#line 2 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2PlaceShips.cshtml"
using Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2178e2ebe43c17e111199345dd8e61c4ce93b7e2", @"/Pages/P2PlaceShips.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56255396305d1d1888ad93afc9c47568e44a4220", @"/Pages/_ViewImports.cshtml")]
    public class Pages_P2PlaceShips : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 4 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2PlaceShips.cshtml"
  
    ViewData["Title"] = "Player 2 ships coordinates: ";

#line default
#line hidden
            BeginContext(111, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(116, 17, false);
#line 7 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2PlaceShips.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(133, 8, true);
            WriteLiteral("</h2>\n\n\n");
            EndContext();
            BeginContext(141, 5587, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2178e2ebe43c17e111199345dd8e61c4ce93b7e24199", async() => {
                BeginContext(147, 101, true);
                WriteLiteral("\n<table style=\"border: 1px solid black\">\n    <tr>\n        <td style=\"border: 1px solid black\"> </td>\n");
                EndContext();
#line 14 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2PlaceShips.cshtml"
         for (int a = 0; a < Domain.GameBoard.Player2Board1[0].Count; a++)
        {

#line default
#line hidden
                BeginContext(333, 48, true);
                WriteLiteral("            <td style=\"border: 1px solid black\">");
                EndContext();
                BeginContext(382, 28, false);
#line 16 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2PlaceShips.cshtml"
                                           Write(Domain.GameBoard.Alphabet[a]);

#line default
#line hidden
                EndContext();
                BeginContext(410, 6, true);
                WriteLiteral("</td>\n");
                EndContext();
#line 17 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2PlaceShips.cshtml"
        }

#line default
#line hidden
                BeginContext(426, 10, true);
                WriteLiteral("    </tr>\n");
                EndContext();
#line 19 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2PlaceShips.cshtml"
     for (int i = 0; i < Domain.GameBoard.Player2Board1.Count; i++)
    {

#line default
#line hidden
                BeginContext(510, 61, true);
                WriteLiteral("        <tr>\n            <td style=\"border: 1px solid black\">");
                EndContext();
                BeginContext(573, 5, false);
#line 22 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2PlaceShips.cshtml"
                                            Write(i + 1);

#line default
#line hidden
                EndContext();
                BeginContext(579, 6, true);
                WriteLiteral("</td>\n");
                EndContext();
#line 23 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2PlaceShips.cshtml"
             for (int j = 0; j < Domain.GameBoard.Player2Board1[i].Count; j++)
            {
                switch (Domain.GameBoard.Player2Board1[i][j])
                {
                    case BoardSquareState.Empty:

#line default
#line hidden
                BeginContext(807, 119, true);
                WriteLiteral("                        <td style=\"border: 2px solid black; width: 50px; height: 50px; background-color:inherit\"></td>\n");
                EndContext();
#line 29 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2PlaceShips.cshtml"
                        break;
                    case BoardSquareState.Unknown:

#line default
#line hidden
                BeginContext(1008, 119, true);
                WriteLiteral("                        <td style=\"border: 2px solid black; width: 50px; height: 50px; background-color:inherit\"></td>\n");
                EndContext();
#line 32 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2PlaceShips.cshtml"
                        break;
                    case BoardSquareState.Ship:

#line default
#line hidden
                BeginContext(1206, 155, true);
                WriteLiteral("                        <td style=\"border: 2px solid black; width: 50px; height: 50px\"><img src=\"images/ship.png\" style=\"width: 50px; height: 50px\"/></td>\n");
                EndContext();
#line 35 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2PlaceShips.cshtml"
                        break;
                    case BoardSquareState.Hit:

#line default
#line hidden
                BeginContext(1439, 154, true);
                WriteLiteral("                        <td style=\"border: 2px solid black; width: 50px; height: 50px\"><img src=\"images/hit.png\" style=\"width: 50px; height: 50px\"/></td>\n");
                EndContext();
#line 38 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2PlaceShips.cshtml"
                        break;
                    case BoardSquareState.Miss:

#line default
#line hidden
                BeginContext(1672, 155, true);
                WriteLiteral("                        <td style=\"border: 2px solid black; width: 50px; height: 50px\"><img src=\"images/miss.png\" style=\"width: 50px; height: 50px\"/></td>\n");
                EndContext();
#line 41 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2PlaceShips.cshtml"
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

#line default
#line hidden
                BeginContext(1985, 14, true);
                WriteLiteral("        </tr>\n");
                EndContext();
#line 48 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2PlaceShips.cshtml"
    }

#line default
#line hidden
                BeginContext(2005, 10, true);
                WriteLiteral("</table>\n\n");
                EndContext();
#line 51 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2PlaceShips.cshtml"
 if (Domain.GameBoard.isRerun)
{

#line default
#line hidden
                BeginContext(2048, 66, true);
                WriteLiteral("    <p>Coordinates you entered did not fit. Please enter new.</p>\n");
                EndContext();
#line 54 "/Users/karlkallas/RiderProjects/BattleShipV2/WebApp/Pages/P2PlaceShips.cshtml"
}

#line default
#line hidden
                BeginContext(2116, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(2117, 3603, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2178e2ebe43c17e111199345dd8e61c4ce93b7e210020", async() => {
                    BeginContext(2137, 3576, true);
                    WriteLiteral(@"
    <fieldset>
        <h3>Enter ships</h3>
         <div>
            <label for=""CarrierVertCoord"">Vertical - carrier (E.g. 1)</label>
            <input style=""background-color: inherit"" type=""text"" name=""CarrierVertCoord"" value=""""/>
        </div>
        <div>
            <label for=""CarrierHorizCoord"">Horizontal - carrier (E.g. a)</label>
            <input style=""background-color: inherit"" type=""text"" name=""CarrierHorizCoord"" value=""""/>
        </div>
        <div>
            <label for=""CarrierDirection"">Direction of the ship: ""R"" - right, ""D"" - down</label>
            <input style=""background-color: inherit"" type=""text"" name=""CarrierDirection"" value=""""/>
        </div>
        <br>
        <br>
        <br>
        <div>
            <label for=""BattleshipVertCoord"">Vertical - battleship (E.g. 1)</label>
            <input style=""background-color: inherit"" type=""text"" name=""BattleshipVertCoord"" value=""""/>
        </div>
        <div>
            <label for=""BattleshipHorizCoord"">Horizontal - battle");
                    WriteLiteral(@"ship (E.g. a)</label>
            <input style=""background-color: inherit"" type=""text"" name=""BattleshipHorizCoord"" value=""""/>
        </div>
        <div>
            <label for=""BattleshipDirection"">Direction of the ship: ""R"" - right, ""D"" - down</label>
            <input style=""background-color: inherit"" type=""text"" name=""BattleshipDirection"" value=""""/>
        </div>
        <br>
        <br>
        <br>
        <div>
            <label for=""SubVertCoord"">Vertical - submarine (E.g. 1)</label>
            <input style=""background-color: inherit"" type=""text"" name=""SubVertCoord"" value=""""/>
        </div>
        <div>
            <label for=""SubHorizCoord"">Horizontal - submarine (E.g. a)</label>
            <input style=""background-color: inherit"" type=""text"" name=""SubHorizCoord"" value=""""/>
        </div>
        <div>
            <label for=""SubDirection"">Direction of the ship: ""R"" - right, ""D"" - down</label>
            <input style=""background-color: inherit"" type=""text"" name=""SubDirection"" value=""""/>
   ");
                    WriteLiteral(@"     </div>
        <br>
        <br>
        <br>
        <div>
            <label for=""CruiserVertCoord"">Vertical - cruiser (E.g. 1)</label>
            <input style=""background-color: inherit"" type=""text"" name=""CruiserVertCoord"" value=""""/>
        </div>
        <div>
            <label for=""CruiserHorizCoord"">Vertical - cruiser (E.g. a)</label>
            <input style=""background-color: inherit"" type=""text"" name=""CruiserHorizCoord"" value=""""/>
        </div>
        <div>
            <label for=""CruiserDirection"">Direction of the ship: ""R"" - right, ""D"" - down</label>
            <input style=""background-color: inherit"" type=""text"" name=""CruiserDirection"" value=""""/>
        </div>
        <br>
        <br>
        <br>
        <div>
            <label for=""PatrolVertCoord"">Vertical - patrol (E.g. 1)</label>
            <input style=""background-color: inherit"" type=""text"" name=""PatrolVertCoord"" value=""""/>
        </div>
        <div>
            <label for=""PatrolHorizCoord"">Horizontal - patrol (E.g. a)</la");
                    WriteLiteral(@"bel>
            <input style=""background-color: inherit"" type=""text"" name=""PatrolHorizCoord"" value=""""/>
        </div>
        <div>
            <label for=""PatrolDirection"">Direction of the ship: ""R"" - right, ""D"" - down</label>
            <input style=""background-color: inherit"" type=""text"" name=""PatrolDirection"" value=""""/>
        </div>
        <div>
            <label>&nbsp;</label>
            <input type=""submit"" value=""Continue"" class=""btn btn-lg bg-danger""/>
        </div>
    </fieldset>
");
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
                BeginContext(5720, 1, true);
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
            BeginContext(5728, 2, true);
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Player2PlaceShipsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Player2PlaceShipsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Player2PlaceShipsModel>)PageContext?.ViewData;
        public Player2PlaceShipsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
