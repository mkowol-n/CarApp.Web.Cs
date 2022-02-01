#pragma checksum "D:\dotnet\CarApp.Web\CarAppWeb\CarAppWeb\Views\Home\AddModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43a8054323ba3e19a068f1d52ff995636e8786ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddModel), @"mvc.1.0.view", @"/Views/Home/AddModel.cshtml")]
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
#line 1 "D:\dotnet\CarApp.Web\CarAppWeb\CarAppWeb\Views\_ViewImports.cshtml"
using CarAppWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dotnet\CarApp.Web\CarAppWeb\CarAppWeb\Views\_ViewImports.cshtml"
using CarAppWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dotnet\CarApp.Web\CarAppWeb\CarAppWeb\Views\_ViewImports.cshtml"
using CarAppWeb.Views.Auth.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43a8054323ba3e19a068f1d52ff995636e8786ba", @"/Views/Home/AddModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae722985a70967bd0423261931bd33990d2360c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarAppWeb.Dtos.CarAppPagedModel<CarAppWeb.Dtos.ModelDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("[ngValue]", new global::Microsoft.AspNetCore.Html.HtmlString("i"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("*ngFor", new global::Microsoft.AspNetCore.Html.HtmlString("let i of brands"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\dotnet\CarApp.Web\CarAppWeb\CarAppWeb\Views\Home\AddModel.cshtml"
  
    ViewData["Title"] = "Add model";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<section class=""vh-100"">
  <div class=""container py-5 "">
    <div class=""row d-flex justify-content-center align-items-center h-100"">
      <div class=""col-12 col-lg-8"">
        <div class=""color-on-surface"">
          <div class=""card-body p-5 text-center"">

            <div class=""mb-lg-7 mt-md-4 pb-3"">

              <h2 class=""fw-bold mb-2 text-uppercase"">Add model</h2>

              <div class=""form-outline form-white mb-5 "">
                <input type=""text"" name=""Brand"" [(ngModel)]=""brandInputText"" (ngModelChange)=""getBrands()"">
                <select [ngModel]=""selectedBrand"" (ngModelChange)=""setCurrentBrand($event)"" name=""sel3"">
                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43a8054323ba3e19a068f1d52ff995636e8786ba4905", async() => {
                WriteLiteral("{{i.name}}");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </select>
              </div>

              <div class=""form-outline form-white mb-5 "">

                <input type=""text"" name=""Model"" [(ngModel)]=""modelInputText"">
              </div>

              <button class=""btn button-primary btn-lg px-5"" type=""submit"" (click)=""addModel()"">Add model</button>

            </div>

          </div>
        </div>
      </div>
    </div>
  </div>
</section>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarAppWeb.Dtos.CarAppPagedModel<CarAppWeb.Dtos.ModelDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
