#pragma checksum "C:\Users\Ryan\Desktop\Kohanski_Ryan_HW2\Views\Home\Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5be7c3a1cd3913131dce64310daad34889f83b85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Kohanski_Ryan_HW2.Views.Home.Views_Home_Results), @"mvc.1.0.view", @"/Views/Home/Results.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Results.cshtml", typeof(Kohanski_Ryan_HW2.Views.Home.Views_Home_Results))]
namespace Kohanski_Ryan_HW2.Views.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5be7c3a1cd3913131dce64310daad34889f83b85", @"/Views/Home/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c27b03846d1df0f4f998e76b47581f2ccbc09581", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Ryan\Desktop\Kohanski_Ryan_HW2\Views\Home\Results.cshtml"
  
    ViewData["Title"] = "Results";

#line default
#line hidden
            BeginContext(45, 56, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h2>Totals</h2>\r\n    <h3>");
            EndContext();
            BeginContext(102, 15, false);
#line 8 "C:\Users\Ryan\Desktop\Kohanski_Ryan_HW2\Views\Home\Results.cshtml"
   Write(ViewBag.strCode);

#line default
#line hidden
            EndContext();
            BeginContext(117, 14, true);
            WriteLiteral("</h3>\r\n    <p>");
            EndContext();
            BeginContext(132, 25, false);
#line 9 "C:\Users\Ryan\Desktop\Kohanski_Ryan_HW2\Views\Home\Results.cshtml"
  Write(ViewBag.intItemsRequested);

#line default
#line hidden
            EndContext();
            BeginContext(157, 14, true);
            WriteLiteral("</p> \r\n    <p>");
            EndContext();
            BeginContext(172, 23, false);
#line 10 "C:\Users\Ryan\Desktop\Kohanski_Ryan_HW2\Views\Home\Results.cshtml"
  Write(ViewBag.dblTacoSubtotal);

#line default
#line hidden
            EndContext();
            BeginContext(195, 14, true);
            WriteLiteral("</p> \r\n    <p>");
            EndContext();
            BeginContext(210, 23, false);
#line 11 "C:\Users\Ryan\Desktop\Kohanski_Ryan_HW2\Views\Home\Results.cshtml"
  Write(ViewBag.dblSandSubtotal);

#line default
#line hidden
            EndContext();
            BeginContext(233, 14, true);
            WriteLiteral("</p> \r\n    <p>");
            EndContext();
            BeginContext(248, 19, false);
#line 12 "C:\Users\Ryan\Desktop\Kohanski_Ryan_HW2\Views\Home\Results.cshtml"
  Write(ViewBag.dblSubtotal);

#line default
#line hidden
            EndContext();
            BeginContext(267, 14, true);
            WriteLiteral("</p> \r\n    <p>");
            EndContext();
            BeginContext(282, 14, false);
#line 13 "C:\Users\Ryan\Desktop\Kohanski_Ryan_HW2\Views\Home\Results.cshtml"
  Write(ViewBag.dblTax);

#line default
#line hidden
            EndContext();
            BeginContext(296, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(310, 16, false);
#line 14 "C:\Users\Ryan\Desktop\Kohanski_Ryan_HW2\Views\Home\Results.cshtml"
  Write(ViewBag.dblTotal);

#line default
#line hidden
            EndContext();
            BeginContext(326, 13, true);
            WriteLiteral("</p> \r\n\r\n    ");
            EndContext();
            BeginContext(339, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5be7c3a1cd3913131dce64310daad34889f83b856180", async() => {
                BeginContext(385, 18, true);
                WriteLiteral("Back to Order Page");
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
            BeginContext(407, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591