#pragma checksum "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\RoleAdmin\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "288916acba48873be36550d54254f524985bb581"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Kohanski_Ryan_HW6.Views.RoleAdmin.Views_RoleAdmin_Edit), @"mvc.1.0.view", @"/Views/RoleAdmin/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RoleAdmin/Edit.cshtml", typeof(Kohanski_Ryan_HW6.Views.RoleAdmin.Views_RoleAdmin_Edit))]
namespace Kohanski_Ryan_HW6.Views.RoleAdmin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\_ViewImports.cshtml"
using Kohanski_Ryan_HW6.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"288916acba48873be36550d54254f524985bb581", @"/Views/RoleAdmin/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"892c859570c5dff8aabf50ecb31b0ecb2a192b4f", @"/Views/_ViewImports.cshtml")]
    public class Views_RoleAdmin_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleEditModel>
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
#line 2 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\RoleAdmin\Edit.cshtml"
  
    ViewBag.Title = "Edit Role";

#line default
#line hidden
            BeginContext(63, 17, true);
            WriteLiteral("\r\n<h2>Edit Role: ");
            EndContext();
            BeginContext(81, 15, false);
#line 6 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\RoleAdmin\Edit.cshtml"
          Write(Model.Role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(96, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
            BeginContext(106, 24, false);
#line 8 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\RoleAdmin\Edit.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(130, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 10 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\RoleAdmin\Edit.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(164, 40, true);
            WriteLiteral("    <input type=\"hidden\" name=\"roleName\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 204, "\"", 228, 1);
#line 12 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\RoleAdmin\Edit.cshtml"
WriteAttributeValue("", 212, Model.Role.Name, 212, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(229, 86, true);
            WriteLiteral(" />\r\n    <div class=\"panel panel-primary\">\r\n        <div class=\"panel-heading\">Add To ");
            EndContext();
            BeginContext(316, 15, false);
#line 14 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\RoleAdmin\Edit.cshtml"
                                     Write(Model.Role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(331, 53, true);
            WriteLiteral("</div>\r\n        <table class=\"table table-striped\">\r\n");
            EndContext();
#line 16 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\RoleAdmin\Edit.cshtml"
             if (Model.NonMembers.Count() == 0)
            {

#line default
#line hidden
            BeginContext(448, 109, true);
            WriteLiteral("                <tr>\r\n                    <td colspan=\"3\">All Users Are Members</td>\r\n                </tr>\r\n");
            EndContext();
#line 21 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\RoleAdmin\Edit.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(605, 164, true);
            WriteLiteral("                <tr>\r\n                    <th>First Name</th>\r\n                    <th>Email</th>\r\n                    <th>Add to Role</th>\r\n                </tr>\r\n");
            EndContext();
#line 29 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\RoleAdmin\Edit.cshtml"
                foreach (AppUser user in Model.NonMembers)
                {

#line default
#line hidden
            BeginContext(848, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(903, 14, false);
#line 32 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\RoleAdmin\Edit.cshtml"
                       Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(917, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(953, 13, false);
#line 33 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\RoleAdmin\Edit.cshtml"
                       Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(966, 103, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            <input type=\"checkbox\" name=\"IdsToAdd\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1069, "\"", 1085, 1);
#line 35 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\RoleAdmin\Edit.cshtml"
WriteAttributeValue("", 1077, user.Id, 1077, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1086, 63, true);
            WriteLiteral(" />\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 38 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\RoleAdmin\Edit.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(1183, 30, true);
            WriteLiteral("        </table>\r\n    </div>\r\n");
            EndContext();
            BeginContext(1215, 86, true);
            WriteLiteral("    <div class=\"panel panel-primary\">\r\n        <div class=\"panel-heading\">Remove from ");
            EndContext();
            BeginContext(1302, 15, false);
#line 44 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\RoleAdmin\Edit.cshtml"
                                          Write(Model.Role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1317, 53, true);
            WriteLiteral("</div>\r\n        <table class=\"table table-striped\">\r\n");
            EndContext();
#line 46 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\RoleAdmin\Edit.cshtml"
             if (Model.Members.Count() == 0)
            {

#line default
#line hidden
            BeginContext(1431, 108, true);
            WriteLiteral("                <tr>\r\n                    <td colspan=\"3\">No Users Are Members</td>\r\n                </tr>\r\n");
            EndContext();
#line 51 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\RoleAdmin\Edit.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1587, 169, true);
            WriteLiteral("                <tr>\r\n                    <th>First Name</th>\r\n                    <th>Email</th>\r\n                    <th>Remove From Role</th>\r\n                </tr>\r\n");
            EndContext();
#line 59 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\RoleAdmin\Edit.cshtml"
                foreach (AppUser user in Model.Members)
                {

#line default
#line hidden
            BeginContext(1832, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1887, 14, false);
#line 62 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\RoleAdmin\Edit.cshtml"
                       Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1901, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1937, 13, false);
#line 63 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\RoleAdmin\Edit.cshtml"
                       Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1950, 106, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            <input type=\"checkbox\" name=\"IdsToDelete\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2056, "\"", 2072, 1);
#line 65 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\RoleAdmin\Edit.cshtml"
WriteAttributeValue("", 2064, user.Id, 2064, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2073, 63, true);
            WriteLiteral(" />\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 68 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\RoleAdmin\Edit.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(2170, 30, true);
            WriteLiteral("        </table>\r\n    </div>\r\n");
            EndContext();
            BeginContext(2202, 68, true);
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-danger\">Save</button>\r\n    ");
            EndContext();
            BeginContext(2270, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "288916acba48873be36550d54254f524985bb58112143", async() => {
                BeginContext(2316, 6, true);
                WriteLiteral("Cancel");
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
            BeginContext(2326, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 75 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\RoleAdmin\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(2331, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleEditModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
