#pragma checksum "C:\Users\User\Desktop\StartMeetProject\StartMeet\startmeet\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ddd30cafe4531cf7a2588776b28c98d1c7abedc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\StartMeetProject\StartMeet\startmeet\Views\_ViewImports.cshtml"
using StartMeet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\StartMeetProject\StartMeet\startmeet\Views\_ViewImports.cshtml"
using StartMeet.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ddd30cafe4531cf7a2588776b28c98d1c7abedc", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cd257ab176736de71ca2cf47be16cea315e12be", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"bg-primary m-1 p-1 text-white\">\r\n    <h4>\r\n        User accounts\r\n    </h4>\r\n</div>\r\n<table class=\"table table-sm table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>User Name</th>\r\n        <th>E-mail Adress</th>\r\n    </tr>\r\n");
#nullable restore
#line 14 "C:\Users\User\Desktop\StartMeetProject\StartMeet\startmeet\Views\Admin\Index.cshtml"
     if(Model.Count()==0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td colspan=\"3\" class=\"text-center\">No User accounts.</td>\r\n        </tr>\r\n");
#nullable restore
#line 19 "C:\Users\User\Desktop\StartMeetProject\StartMeet\startmeet\Views\Admin\Index.cshtml"
    }
    else
    {
        foreach (AppUser user in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\User\Desktop\StartMeetProject\StartMeet\startmeet\Views\Admin\Index.cshtml"
               Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\User\Desktop\StartMeetProject\StartMeet\startmeet\Views\Admin\Index.cshtml"
               Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\User\Desktop\StartMeetProject\StartMeet\startmeet\Views\Admin\Index.cshtml"
               Write(user.UserSecondName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\User\Desktop\StartMeetProject\StartMeet\startmeet\Views\Admin\Index.cshtml"
               Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>    \r\n");
#nullable restore
#line 30 "C:\Users\User\Desktop\StartMeetProject\StartMeet\startmeet\Views\Admin\Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591