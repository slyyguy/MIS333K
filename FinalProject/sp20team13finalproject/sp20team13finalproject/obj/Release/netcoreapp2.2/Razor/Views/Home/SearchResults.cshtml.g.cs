#pragma checksum "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Home\SearchResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51beb0d57095c57d113c27481226cfffd8ef1b03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(sp20team13finalproject.Views.Home.Views_Home_SearchResults), @"mvc.1.0.view", @"/Views/Home/SearchResults.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SearchResults.cshtml", typeof(sp20team13finalproject.Views.Home.Views_Home_SearchResults))]
namespace sp20team13finalproject.Views.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Home\SearchResults.cshtml"
using sp20team13finalproject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51beb0d57095c57d113c27481226cfffd8ef1b03", @"/Views/Home/SearchResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff4d81c00e5c680a43b830d7180b3343e1271f30", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SearchResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<sp20team13finalproject.Models.FlightDetail>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailedSearch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchResults", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reservations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(102, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Home\SearchResults.cshtml"
  
    ViewData["Title"] = "Longhorn Airlines";

#line default
#line hidden
            BeginContext(157, 27, true);
            WriteLiteral("\r\n<h1>Search Results</h1>\r\n");
            EndContext();
            BeginContext(184, 636, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51beb0d57095c57d113c27481226cfffd8ef1b036733", async() => {
                BeginContext(252, 342, true);
                WriteLiteral(@"
    <!-- a textbox on the Index view to allow the user to enter the search string for the quick search -->
    <!-- The code below adds the textbox for the quick search and three buttons (Search, Advanced Search, and Show All) -->
    <p class=""form-group"">
        <button type=""submit"" class=""btn btn-primary"">Search</button>
        ");
                EndContext();
                BeginContext(594, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51beb0d57095c57d113c27481226cfffd8ef1b037461", async() => {
                    BeginContext(637, 8, true);
                    WriteLiteral("Show All");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(649, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(659, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51beb0d57095c57d113c27481226cfffd8ef1b039016", async() => {
                    BeginContext(714, 18, true);
                    WriteLiteral("Make a Reservation");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(736, 77, true);
                WriteLiteral("\r\n        <!--<input type=\"hidden\" asp-for=\"FlightDetailID\" />-->\r\n    </p>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(820, 68, true);
            WriteLiteral("\r\n<p>\r\n    <!-- “Displaying X out of Y Movies”  -->\r\n    Displaying ");
            EndContext();
            BeginContext(889, 34, false);
#line 21 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Home\SearchResults.cshtml"
          Write(ViewBag.SelectedFlightDetailsCount);

#line default
#line hidden
            EndContext();
            BeginContext(923, 4, true);
            WriteLiteral(" of ");
            EndContext();
            BeginContext(928, 29, false);
#line 21 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Home\SearchResults.cshtml"
                                                 Write(ViewBag.AllFlightDetailsCount);

#line default
#line hidden
            EndContext();
            BeginContext(957, 94, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1052, 45, false);
#line 28 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Home\SearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.FlightNum));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1153, 50, false);
#line 31 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Home\SearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.Flight.DepCity));

#line default
#line hidden
            EndContext();
            BeginContext(1203, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1259, 54, false);
#line 34 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Home\SearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.Flight.ArrivalCity));

#line default
#line hidden
            EndContext();
            BeginContext(1313, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1369, 40, false);
#line 37 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Home\SearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1409, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1465, 50, false);
#line 40 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Home\SearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.Flight.DepTime));

#line default
#line hidden
            EndContext();
            BeginContext(1515, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1571, 44, false);
#line 43 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Home\SearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.BaseFare));

#line default
#line hidden
            EndContext();
            BeginContext(1615, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 49 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Home\SearchResults.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1750, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1811, 44, false);
#line 53 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Home\SearchResults.cshtml"
               Write(Html.DisplayFor(modelItem => item.FlightNum));

#line default
#line hidden
            EndContext();
            BeginContext(1855, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1923, 49, false);
#line 56 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Home\SearchResults.cshtml"
               Write(Html.DisplayFor(modelItem => item.Flight.DepCity));

#line default
#line hidden
            EndContext();
            BeginContext(1972, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2040, 53, false);
#line 59 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Home\SearchResults.cshtml"
               Write(Html.DisplayFor(modelItem => item.Flight.ArrivalCity));

#line default
#line hidden
            EndContext();
            BeginContext(2093, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2161, 39, false);
#line 62 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Home\SearchResults.cshtml"
               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2200, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2268, 49, false);
#line 65 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Home\SearchResults.cshtml"
               Write(Html.DisplayFor(modelItem => item.Flight.DepTime));

#line default
#line hidden
            EndContext();
            BeginContext(2317, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2385, 43, false);
#line 68 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Home\SearchResults.cshtml"
               Write(Html.DisplayFor(modelItem => item.BaseFare));

#line default
#line hidden
            EndContext();
            BeginContext(2428, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2495, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51beb0d57095c57d113c27481226cfffd8ef1b0319333", async() => {
                BeginContext(2596, 7, true);
                WriteLiteral("Reserve");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-flightDetailID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Home\SearchResults.cshtml"
                                                                                       WriteLiteral(item.FlightDetailID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["flightDetailID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-flightDetailID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["flightDetailID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2607, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 74 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Home\SearchResults.cshtml"
        }

#line default
#line hidden
            BeginContext(2662, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<sp20team13finalproject.Models.FlightDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
