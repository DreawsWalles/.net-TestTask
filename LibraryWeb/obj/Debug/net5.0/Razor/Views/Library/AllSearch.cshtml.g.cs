#pragma checksum "E:\OneDrive - ВГУ\TestTask\LibraryWeb\Views\Library\AllSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a593eec2ff54eb983f2779d59fa22b74d79cc936"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Library_AllSearch), @"mvc.1.0.view", @"/Views/Library/AllSearch.cshtml")]
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
#line 1 "E:\OneDrive - ВГУ\TestTask\LibraryWeb\Views\_ViewImports.cshtml"
using LibraryWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\OneDrive - ВГУ\TestTask\LibraryWeb\Views\_ViewImports.cshtml"
using LibraryWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a593eec2ff54eb983f2779d59fa22b74d79cc936", @"/Views/Library/AllSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c99ae578f8eaac6ff644c6d16210b9e535ba815", @"/Views/_ViewImports.cshtml")]
    public class Views_Library_AllSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryWeb.Models.Model>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Library", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("point-menu"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PrintBooks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PrintJournals", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\OneDrive - ВГУ\TestTask\LibraryWeb\Views\Library\AllSearch.cshtml"
  
    ViewData["Title"] = "Поиск";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<header>\r\n    <nav class=\"navbar border\">\r\n        <div class=\"container-menu\">\r\n            <div class=\"brand\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a593eec2ff54eb983f2779d59fa22b74d79cc9365599", async() => {
                WriteLiteral("LibraryWeb");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n            <div class=\"menu\">\r\n                <div class=\"point-menu-1\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a593eec2ff54eb983f2779d59fa22b74d79cc9367133", async() => {
                WriteLiteral("Книги");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                <div class=\"point-menu-2\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a593eec2ff54eb983f2779d59fa22b74d79cc9368626", async() => {
                WriteLiteral("Журналы");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n    </nav>\r\n</header>\r\n<div class=\"container\">\r\n    <main role=\"main\" class=\"pb-3\">\r\n        <table>\r\n\r\n");
#nullable restore
#line 21 "E:\OneDrive - ВГУ\TestTask\LibraryWeb\Views\Library\AllSearch.cshtml"
              
                if (Model.Books.Count() == 0 && Model.Journals.Count() == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>По данному запросу ничего не найдено</div>\r\n");
#nullable restore
#line 25 "E:\OneDrive - ВГУ\TestTask\LibraryWeb\Views\Library\AllSearch.cshtml"
                }
                else if (Model.Books.Count() != 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <tr>
                        <td>Название</td>
                        <td>Издательство</td>
                        <td>Периодичность</td>
                        <td>Номер</td>
                        <td>Количество</td>
                        <td>Год</td>
                    </tr>
");
#nullable restore
#line 36 "E:\OneDrive - ВГУ\TestTask\LibraryWeb\Views\Library\AllSearch.cshtml"
                    foreach (Book element in Model.Books)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a593eec2ff54eb983f2779d59fa22b74d79cc93611477", async() => {
                WriteLiteral("\r\n                        <tr>\r\n                            <td>\r\n                                <input type=\"text\" readonly");
                BeginWriteAttribute("value", " value=\"", 1560, "\"", 1581, 1);
#nullable restore
#line 41 "E:\OneDrive - ВГУ\TestTask\LibraryWeb\Views\Library\AllSearch.cshtml"
WriteAttributeValue("", 1568, element.Name, 1568, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </td>\r\n                            <td>\r\n                                <input type=\"text\" readonly");
                BeginWriteAttribute("value", " value=\"", 1715, "\"", 1738, 1);
#nullable restore
#line 44 "E:\OneDrive - ВГУ\TestTask\LibraryWeb\Views\Library\AllSearch.cshtml"
WriteAttributeValue("", 1723, element.Author, 1723, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </td>\r\n                            <td>\r\n                                <input type=\"text\" readonly");
                BeginWriteAttribute("value", " value=\"", 1872, "\"", 1894, 1);
#nullable restore
#line 47 "E:\OneDrive - ВГУ\TestTask\LibraryWeb\Views\Library\AllSearch.cshtml"
WriteAttributeValue("", 1880, element.Genre, 1880, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </td>\r\n                            <td>\r\n                                <input type=\"text\" readonly");
                BeginWriteAttribute("value", " value=\"", 2028, "\"", 2054, 1);
#nullable restore
#line 50 "E:\OneDrive - ВГУ\TestTask\LibraryWeb\Views\Library\AllSearch.cshtml"
WriteAttributeValue("", 2036, element.Publisher, 2036, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </td>\r\n                            <td>\r\n                                <input type=\"text\" readonly");
                BeginWriteAttribute("value", " value=\"", 2188, "\"", 2210, 1);
#nullable restore
#line 53 "E:\OneDrive - ВГУ\TestTask\LibraryWeb\Views\Library\AllSearch.cshtml"
WriteAttributeValue("", 2196, element.Count, 2196, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </td>\r\n                            <td>\r\n                                <input type=\"text\" readonly");
                BeginWriteAttribute("value", " value=\"", 2344, "\"", 2365, 1);
#nullable restore
#line 56 "E:\OneDrive - ВГУ\TestTask\LibraryWeb\Views\Library\AllSearch.cshtml"
WriteAttributeValue("", 2352, element.Year, 2352, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </td>\r\n                        </tr>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 60 "E:\OneDrive - ВГУ\TestTask\LibraryWeb\Views\Library\AllSearch.cshtml"
                    }
                }
                else if (Model.Journals.Count() != 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <tr>
                        <td>Название</td>
                        <td>Издательство</td>
                        <td>Периодичность</td>
                        <td>Номер</td>
                        <td>Количество</td>
                        <td>Год</td>
                    </tr>
");
#nullable restore
#line 72 "E:\OneDrive - ВГУ\TestTask\LibraryWeb\Views\Library\AllSearch.cshtml"
                    foreach (Journal element in Model.Journals)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a593eec2ff54eb983f2779d59fa22b74d79cc93616760", async() => {
                WriteLiteral("\r\n                        <tr>\r\n                            <td>\r\n                                <input type=\"text\" readonly");
                BeginWriteAttribute("value", " value=\"", 3143, "\"", 3164, 1);
#nullable restore
#line 77 "E:\OneDrive - ВГУ\TestTask\LibraryWeb\Views\Library\AllSearch.cshtml"
WriteAttributeValue("", 3151, element.Name, 3151, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </td>\r\n                            <td>\r\n                                <input type=\"text\" readonly");
                BeginWriteAttribute("value", " value=\"", 3298, "\"", 3324, 1);
#nullable restore
#line 80 "E:\OneDrive - ВГУ\TestTask\LibraryWeb\Views\Library\AllSearch.cshtml"
WriteAttributeValue("", 3306, element.Publisher, 3306, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </td>\r\n                            <td>\r\n                                <input type=\"text\" readonly");
                BeginWriteAttribute("value", " value=\"", 3458, "\"", 3487, 1);
#nullable restore
#line 83 "E:\OneDrive - ВГУ\TestTask\LibraryWeb\Views\Library\AllSearch.cshtml"
WriteAttributeValue("", 3466, element.Periodically, 3466, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </td>\r\n                            <td>\r\n                                <input type=\"text\" readonly");
                BeginWriteAttribute("value", " value=\"", 3621, "\"", 3644, 1);
#nullable restore
#line 86 "E:\OneDrive - ВГУ\TestTask\LibraryWeb\Views\Library\AllSearch.cshtml"
WriteAttributeValue("", 3629, element.Number, 3629, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </td>\r\n                            <td>\r\n                                <input type=\"text\" readonly");
                BeginWriteAttribute("value", " value=\"", 3778, "\"", 3800, 1);
#nullable restore
#line 89 "E:\OneDrive - ВГУ\TestTask\LibraryWeb\Views\Library\AllSearch.cshtml"
WriteAttributeValue("", 3786, element.Count, 3786, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </td>\r\n                            <td>\r\n                                <input type=\"text\" readonly");
                BeginWriteAttribute("value", " value=\"", 3934, "\"", 3955, 1);
#nullable restore
#line 92 "E:\OneDrive - ВГУ\TestTask\LibraryWeb\Views\Library\AllSearch.cshtml"
WriteAttributeValue("", 3942, element.Year, 3942, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </td>\r\n                        </tr>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 96 "E:\OneDrive - ВГУ\TestTask\LibraryWeb\Views\Library\AllSearch.cshtml"
                    }
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n        </table>\r\n    </main>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryWeb.Models.Model> Html { get; private set; }
    }
}
#pragma warning restore 1591
