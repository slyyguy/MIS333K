#pragma checksum "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "763b73dc31a434eb23a83e280470d249824fb881"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Kohanski_Ryan_HW6.Views.Account.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(Kohanski_Ryan_HW6.Views.Account.Views_Account_Register))]
namespace Kohanski_Ryan_HW6.Views.Account
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"763b73dc31a434eb23a83e280470d249824fb881", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"892c859570c5dff8aabf50ecb31b0ecb2a192b4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Account\Register.cshtml"
  
    ViewBag.Title = "Register";

#line default
#line hidden
            BeginContext(66, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(73, 13, false);
#line 6 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Account\Register.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(86, 10, true);
            WriteLiteral(".</h2>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Account\Register.cshtml"
 using (Html.BeginForm("Register", "Account", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{
    

#line default
#line hidden
            BeginContext(220, 23, false);
#line 10 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Account\Register.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(245, 48, true);
            WriteLiteral("    <h4>Create a new account.</h4>\r\n    <hr />\r\n");
            EndContext();
            BeginContext(298, 58, false);
#line 13 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Account\Register.cshtml"
Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(358, 8, true);
            WriteLiteral("    <h4>");
            EndContext();
            BeginContext(367, 13, false);
#line 14 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Account\Register.cshtml"
   Write(ViewBag.Error);

#line default
#line hidden
            EndContext();
            BeginContext(380, 45, true);
            WriteLiteral("</h4>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(426, 70, false);
#line 16 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Account\Register.cshtml"
   Write(Html.LabelFor(m => m.Email, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(496, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(544, 62, false);
#line 18 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Account\Register.cshtml"
       Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(606, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(844, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(883, 74, false);
#line 24 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Account\Register.cshtml"
   Write(Html.LabelFor(m => m.FirstName, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(957, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(1005, 66, false);
#line 26 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Account\Register.cshtml"
       Write(Html.TextBoxFor(m => m.FirstName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 68, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1140, 73, false);
#line 30 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Account\Register.cshtml"
   Write(Html.LabelFor(m => m.LastName, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1213, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(1261, 65, false);
#line 32 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Account\Register.cshtml"
       Write(Html.TextBoxFor(m => m.LastName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1326, 68, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1395, 76, false);
#line 36 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Account\Register.cshtml"
   Write(Html.LabelFor(m => m.PhoneNumber, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1471, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(1519, 68, false);
#line 38 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Account\Register.cshtml"
       Write(Html.TextBoxFor(m => m.PhoneNumber, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1587, 68, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1656, 73, false);
#line 42 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Account\Register.cshtml"
   Write(Html.LabelFor(m => m.Password, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1729, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(1777, 66, false);
#line 44 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Account\Register.cshtml"
       Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1843, 68, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1912, 80, false);
#line 48 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Account\Register.cshtml"
   Write(Html.LabelFor(m => m.ConfirmPassword, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1992, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(2040, 73, false);
#line 50 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Account\Register.cshtml"
       Write(Html.PasswordFor(m => m.ConfirmPassword, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2113, 215, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" class=\"btn btn-primary\" value=\"Register\" />\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 58 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Account\Register.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
