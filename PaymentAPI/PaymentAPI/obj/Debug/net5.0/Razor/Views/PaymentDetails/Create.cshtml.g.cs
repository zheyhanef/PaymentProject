#pragma checksum "D:\OneDrive\Estudos\Youtube\CodAffection - ASP.NET Core Web API CRUD with Angular 11\PaymentAPI\PaymentAPI\Views\PaymentDetails\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea63ac75df12961a87199671d98c639c07460418"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PaymentDetails_Create), @"mvc.1.0.view", @"/Views/PaymentDetails/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea63ac75df12961a87199671d98c639c07460418", @"/Views/PaymentDetails/Create.cshtml")]
    public class Views_PaymentDetails_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaymentAPI.Models.PaymentDetail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\OneDrive\Estudos\Youtube\CodAffection - ASP.NET Core Web API CRUD with Angular 11\PaymentAPI\PaymentAPI\Views\PaymentDetails\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>PaymentDetail</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""CardOwnerName"" class=""control-label""></label>
                <input asp-for=""CardOwnerName"" class=""form-control"" />
                <span asp-validation-for=""CardOwnerName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CardNumber"" class=""control-label""></label>
                <input asp-for=""CardNumber"" class=""form-control"" />
                <span asp-validation-for=""CardNumber"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ExpirationDate"" class=""control-label""></label>
                <input asp-for=""ExpirationDate"" class=""form-control"" />
                <span asp-validation");
            WriteLiteral(@"-for=""ExpirationDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SecurityCode"" class=""control-label""></label>
                <input asp-for=""SecurityCode"" class=""form-control"" />
                <span asp-validation-for=""SecurityCode"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 47 "D:\OneDrive\Estudos\Youtube\CodAffection - ASP.NET Core Web API CRUD with Angular 11\PaymentAPI\PaymentAPI\Views\PaymentDetails\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaymentAPI.Models.PaymentDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591