#pragma checksum "D:\OneDrive\Estudos\Youtube\CodAffection - ASP.NET Core Web API CRUD with Angular 11\PaymentAPI\PaymentAPI\Views\PaymentDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb1e8c3f8eaaa218f87882c2ae73595e88f994cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PaymentDetails_Index), @"mvc.1.0.view", @"/Views/PaymentDetails/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb1e8c3f8eaaa218f87882c2ae73595e88f994cc", @"/Views/PaymentDetails/Index.cshtml")]
    public class Views_PaymentDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PaymentAPI.Models.PaymentDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\OneDrive\Estudos\Youtube\CodAffection - ASP.NET Core Web API CRUD with Angular 11\PaymentAPI\PaymentAPI\Views\PaymentDetails\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\OneDrive\Estudos\Youtube\CodAffection - ASP.NET Core Web API CRUD with Angular 11\PaymentAPI\PaymentAPI\Views\PaymentDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CardOwnerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\OneDrive\Estudos\Youtube\CodAffection - ASP.NET Core Web API CRUD with Angular 11\PaymentAPI\PaymentAPI\Views\PaymentDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CardNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\OneDrive\Estudos\Youtube\CodAffection - ASP.NET Core Web API CRUD with Angular 11\PaymentAPI\PaymentAPI\Views\PaymentDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ExpirationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\OneDrive\Estudos\Youtube\CodAffection - ASP.NET Core Web API CRUD with Angular 11\PaymentAPI\PaymentAPI\Views\PaymentDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SecurityCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "D:\OneDrive\Estudos\Youtube\CodAffection - ASP.NET Core Web API CRUD with Angular 11\PaymentAPI\PaymentAPI\Views\PaymentDetails\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "D:\OneDrive\Estudos\Youtube\CodAffection - ASP.NET Core Web API CRUD with Angular 11\PaymentAPI\PaymentAPI\Views\PaymentDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CardOwnerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "D:\OneDrive\Estudos\Youtube\CodAffection - ASP.NET Core Web API CRUD with Angular 11\PaymentAPI\PaymentAPI\Views\PaymentDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CardNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "D:\OneDrive\Estudos\Youtube\CodAffection - ASP.NET Core Web API CRUD with Angular 11\PaymentAPI\PaymentAPI\Views\PaymentDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ExpirationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "D:\OneDrive\Estudos\Youtube\CodAffection - ASP.NET Core Web API CRUD with Angular 11\PaymentAPI\PaymentAPI\Views\PaymentDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SecurityCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1215, "\"", 1251, 1);
#nullable restore
#line 46 "D:\OneDrive\Estudos\Youtube\CodAffection - ASP.NET Core Web API CRUD with Angular 11\PaymentAPI\PaymentAPI\Views\PaymentDetails\Index.cshtml"
WriteAttributeValue("", 1230, item.PaymentDetailId, 1230, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1304, "\"", 1340, 1);
#nullable restore
#line 47 "D:\OneDrive\Estudos\Youtube\CodAffection - ASP.NET Core Web API CRUD with Angular 11\PaymentAPI\PaymentAPI\Views\PaymentDetails\Index.cshtml"
WriteAttributeValue("", 1319, item.PaymentDetailId, 1319, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1395, "\"", 1431, 1);
#nullable restore
#line 48 "D:\OneDrive\Estudos\Youtube\CodAffection - ASP.NET Core Web API CRUD with Angular 11\PaymentAPI\PaymentAPI\Views\PaymentDetails\Index.cshtml"
WriteAttributeValue("", 1410, item.PaymentDetailId, 1410, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 51 "D:\OneDrive\Estudos\Youtube\CodAffection - ASP.NET Core Web API CRUD with Angular 11\PaymentAPI\PaymentAPI\Views\PaymentDetails\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PaymentAPI.Models.PaymentDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
