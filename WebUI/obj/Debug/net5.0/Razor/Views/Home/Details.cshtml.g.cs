#pragma checksum "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4b29adeb5512c43db788b4dcaba949489c4dc18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\C#\WebShop\WebUI\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\C#\WebShop\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\C#\WebShop\WebUI\Views\_ViewImports.cshtml"
using BLL.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\C#\WebShop\WebUI\Views\_ViewImports.cshtml"
using WebUI.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4b29adeb5512c43db788b4dcaba949489c4dc18", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0d48b9e1f0a5a0d9d22cc5fe02cdb35a550ae61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GoodDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Favorites", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "AddFavorite", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("info-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_SizeTable", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PayInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n<div class=\"container\">\r\n\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <div class=\"d-flex justify-content-center\">\r\n                <img class=\"img-fluid\" style=\"width:500px; height:500px\"");
            BeginWriteAttribute("src", " src=\"", 443, "\"", 465, 1);
#nullable restore
#line 24 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
WriteAttributeValue("", 449, Model.PhotoPath, 449, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n        <div class=\"col-6\">\r\n            <h6 class=\"title-page\">\r\n                ");
#nullable restore
#line 29 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
           Write(Model.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 29 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
                               Write(Model.ManufacturerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 29 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
                                                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Артикул: ");
#nullable restore
#line 29 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
                                                                            Write(Model.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h6>\r\n\r\n\r\n");
#nullable restore
#line 33 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
             if (Model.Gender == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"subtitle\">Для мужчин</div>\r\n");
#nullable restore
#line 36 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"

            }
            else if (Model.Gender == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"subtitle\">Для женщин</div>\r\n");
#nullable restore
#line 41 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"subtitle\">Для детей</div>\r\n");
#nullable restore
#line 45 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <div class=\"d-flex justify-content-between  align-items-baseline\">\r\n                <div class=\"price\">");
#nullable restore
#line 49 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
                              Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" грн.</div>\r\n                <div class=\"articul-code\">\r\n                    Aртикул: ");
#nullable restore
#line 51 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
                        Write(Model.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div>\r\n");
#nullable restore
#line 55 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
                 if (!SignInManager.IsSignedIn(User))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <i class=\"bi bi-heart\"></i>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4b29adeb5512c43db788b4dcaba949489c4dc1811304", async() => {
                WriteLiteral("Избранное");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
                }
                else
                {
                    //TO DO: Добавить список избранного по типу корзины

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4b29adeb5512c43db788b4dcaba949489c4dc1812972", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", "\r\n                               value=\"", 1859, "\"", 1946, 1);
#nullable restore
#line 65 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
WriteAttributeValue("", 1899, ViewContext.HttpContext.Request.PathAndQuery(), 1899, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <button type=\"submit\" class=\"btn btn-like\" draggable=\"false\">\r\n\r\n                            <i class=\"bi bi-heart\"></i>\r\n                            Избранное\r\n                        </button>\r\n\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
                                                                                               WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 73 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div>\r\n                Выберите размер (США)\r\n            </div>\r\n            <div class=\"d-flex flex-lg-wrap\">\r\n\r\n");
#nullable restore
#line 80 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
                 for (float i = 6f; i < 13f; i += 0.5f)
                {
                    //TO DO: Добавить сетку размеров

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n\r\n                        <input type=\"button\" class=\"btn btn-outline-dark\" style=\"width:60px; margin: 5px\" name=\"size\"");
            BeginWriteAttribute("value", " value=\"", 2645, "\"", 2655, 1);
#nullable restore
#line 85 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
WriteAttributeValue("", 2653, i, 2653, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </div>\r\n");
#nullable restore
#line 87 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"d-flex justify-content-between p-4\">\r\n                <div class=\"d-flex flex-column\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4b29adeb5512c43db788b4dcaba949489c4dc1818042", async() => {
                WriteLiteral("Наличие в магазинах");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4b29adeb5512c43db788b4dcaba949489c4dc1819314", async() => {
                WriteLiteral("Доставка");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4b29adeb5512c43db788b4dcaba949489c4dc1820575", async() => {
                WriteLiteral("Возврат");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""d-flex flex-column"">

                    <a href=""#"" class=""info-link"" data-url=""Home/SizeTable/"" data-toggle=""modal""
                       data-target=""#modal-size-table"">Таблица размеров</a>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f4b29adeb5512c43db788b4dcaba949489c4dc1822097", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    <a href=\"#\" class=\"info-link\" data-url=\"Home/PayInfo/\" data-toggle=\"modal\"\r\n                       data-target=\"#modal-pay-info\">Оплата</a>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f4b29adeb5512c43db788b4dcaba949489c4dc1823413", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4b29adeb5512c43db788b4dcaba949489c4dc1824554", async() => {
                WriteLiteral("Написать отзыв");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"d-flex align-items-baseline justify-content-around\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4b29adeb5512c43db788b4dcaba949489c4dc1825951", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", "\r\n                           value=\"", 3919, "\"", 4002, 1);
#nullable restore
#line 112 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
WriteAttributeValue("", 3955, ViewContext.HttpContext.Request.PathAndQuery(), 3955, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                    <div class=\"d-flex align-items-baseline\">\r\n                        <div>Количество</div>\r\n                        <select name=\"quant\" class=\"custom-select mb-3\">\r\n\r\n");
#nullable restore
#line 118 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
                             for (int i = 1; i < 10; i++)
                            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4b29adeb5512c43db788b4dcaba949489c4dc1827178", async() => {
#nullable restore
#line 121 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
                                              Write(i);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 121 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
                                   WriteLiteral(i);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 122 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </select>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 110 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
                                                   WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <button type=\"submit\" form=\"form\" class=\"btn btn-orange\">Добавить в корзину</button>\r\n            </div>\r\n        </div>\r\n\r\n");
#nullable restore
#line 130 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
         if (Model.CategoryName == "Кроссовки")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"p-3\">\r\n                <h4 class=\"subtitle-page\">\r\n                    ");
#nullable restore
#line 134 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
               Write(Model.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 134 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
                                   Write(Model.ManufacturerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 134 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
                                                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Артикул: ");
#nullable restore
#line 134 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
                                                                                Write(Model.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h4>\r\n\r\n                <b>УПРУГОСТЬ, КОМФОРТ И ИДЕАЛЬНАЯ ПОСАДКА </b><br />\r\n                Кроссовки <strong> ");
#nullable restore
#line 138 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
                              Write(Model.ManufacturerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 138 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"
                                                      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong> с упругой подошвой из пеноматериала,
                как в предыдущей версии, обеспечивают амортизацию при каждом шаге.
                Прочный верх из дышащей сетки с более широкой посадкой в области носка обеспечивает комфорт.
                Старое и новое. Более широкая передняя часть дает дополнительное пространство для пальцев.
                Классическая посадка обеспечивает тот уровень комфорта, который ты ожидаешь от Pegasus.Верх выполнен из воздухопроницаемой мягкой сетки. Эластичная конструкция дает оптимальную форму и посадку.
                Амортизация при каждом шаге. Легкий пеноматериал Nike React обеспечивает упругость и прочность
                <br />
                <b>Преимущества </b>
                <ul>
                    <li>Больше пеноматериала в язычке для мягкости в верхней части стопы.</li>
                    <li>Увеличенное количество пеноматериала повышает эффективность амортизации без лишнего объема.</li>
                    <li>Подушка Zoom Air усиливае");
            WriteLiteral(@"т отскок при каждом шаге. Она расположена ближе к стопе для дополнительной амортизации.</li>
                    <li> Надежная посадка. Плетение в средней части стопы обеспечивает плотную посадку при затягивании шнурков.</li>
                </ul>
                <b>Информация о товаре</b>
                <ul>
                    <li>Верх: синтетический материал / текстиль</li>
                    <li>Верх: синтетический материал / текстиль</li>
                    <li>Внутренний материал: текстиль</li>
                    <li>Подошва: пена / резина</li>
                </ul>
            </div>
");
#nullable restore
#line 160 "C:\C#\WebShop\WebUI\Views\Home\Details.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n<div id=\"modDialog\" class=\"modal fade\">\r\n    <div id=\"dialogContent\" class=\"modal-dialog\"></div>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">

        $(function () {
            $.ajaxSetup({ cache: false });
            $("".sizeTable"").click(function (e) {

                e.preventDefault();
                $.get(this.href, function (data) {
                    $('#dialogContent').html(data);
                    $('#modDialog').modal('show');
                });
            });
        })
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GoodDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591