#pragma checksum "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a134d88658621871bcfa931dd1df60a5754444d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DataInputAdd), @"mvc.1.0.view", @"/Views/Home/DataInputAdd.cshtml")]
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
#line 1 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\_ViewImports.cshtml"
using Baraban;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\_ViewImports.cshtml"
using Baraban.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a134d88658621871bcfa931dd1df60a5754444d0", @"/Views/Home/DataInputAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17afb25b4d17a2561753b3901972c23c1d3dab96", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_DataInputAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Baraban.Models.DataInputModel>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a134d88658621871bcfa931dd1df60a5754444d03343", async() => {
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a134d88658621871bcfa931dd1df60a5754444d04309", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 11 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
     using (Html.BeginForm("DataInputAdd", "Home", FormMethod.Post))
    {


#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"container\">\r\n            <h2>Исходные данные</h2>\r\n            <div class=\"table-responsive\">\r\n                <div>\r\n");
#nullable restore
#line 18 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                     if (ViewBag.DataInput != null && ViewBag.DataInput.IsActive)
                    {
                        ViewBag.DataInput.Name = null;
                        ViewBag.DataInput.Description = null;
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <table>\r\n                        <tr>\r\n                            <td valign=\"top\" width=\"210\">\r\n                                ");
#nullable restore
#line 26 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextBox("DataInput.Name", (string)(ViewBag.DataInput.Name), htmlAttributes: new { type = "text", style = " width:200px; ", placeholder = "Введите название"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 29 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextArea("DataInput.Description", (string)(ViewBag.DataInput.Description), 5, 1, htmlAttributes: new { type = "text", style = " width:200px; height:30px", placeholder = "Введите описание"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </td>
                        </tr>
                    </table>
                </div>

                <table class=""table"">
                    <thead>
                        <tr>
                            <th>Наименование показателя, ед. изм.</th>
                            <th>Величина</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>Начальная влажность материала, %</td>
                            <td>");
#nullable restore
#line 45 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextBox("DataInput.Wstart", (double)(ViewBag.DataInput.Wstart), htmlAttributes: new { type = "text", style = " width:100px;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Конечная влажность материала, %</td>\r\n                            <td>");
#nullable restore
#line 49 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextBox("DataInput.Wend", (double)(ViewBag.DataInput.Wend), htmlAttributes: new { type = "text", style = " width:100px; "}));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Содержание углерода в топливе, %</td>\r\n                            <td>");
#nullable restore
#line 53 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextBox("DataInput.percentCp", (double)(ViewBag.DataInput.percentCp), htmlAttributes: new { type = "text", style = " width:100px; " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Содержание водорода в топливе, %</td>\r\n                            <td>");
#nullable restore
#line 57 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextBox("DataInput.percentHp", (double)(ViewBag.DataInput.percentHp), htmlAttributes: new { type = "text", style = " width:100px; " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Содержание серы в топливе, %</td>\r\n                            <td>");
#nullable restore
#line 61 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextBox("DataInput.percentSp", (double)(ViewBag.DataInput.percentSp), htmlAttributes: new { type = "text", style = " width:100px; " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Содержание кислорода в топливе, %</td>\r\n                            <td>");
#nullable restore
#line 65 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextBox("DataInput.percentOp", (double)(ViewBag.DataInput.percentOp), htmlAttributes: new { type = "text", style = " width:100px; " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Содержание азота в топливе, %</td>\r\n                            <td>");
#nullable restore
#line 69 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextBox("DataInput.percentNp", (double)(ViewBag.DataInput.percentNp), htmlAttributes: new { type = "text", style = " width:100px; " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Содержание золы в топливе, %</td>\r\n                            <td>");
#nullable restore
#line 73 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextBox("DataInput.percentAp", (double)(ViewBag.DataInput.percentAp), htmlAttributes: new { type = "text", style = " width:100px; " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Содержание влаги в топливе, %</td>\r\n                            <td>");
#nullable restore
#line 77 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextBox("DataInput.percentWp", (double)(ViewBag.DataInput.percentWp), htmlAttributes: new { type = "text", style = " width:100px; " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Максимальная температура газов, °C</td>\r\n                            <td>");
#nullable restore
#line 81 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextBox("DataInput.t1", (double)(ViewBag.DataInput.t1), htmlAttributes: new { type = "text", style = " width:100px; " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Минимальная температура газов, °C</td>\r\n                            <td>");
#nullable restore
#line 85 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextBox("DataInput.t2", (double)(ViewBag.DataInput.t2), htmlAttributes: new { type = "text", style = " width:100px; " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Коэффициент расхода воздуха</td>\r\n                            <td>");
#nullable restore
#line 89 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextBox("DataInput.alpha", (double)(ViewBag.DataInput.alpha), htmlAttributes: new { type = "text", style = " width:100px; " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Коэффициент сохранения тепла</td>\r\n                            <td>");
#nullable restore
#line 93 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextBox("DataInput.eta", (double)(ViewBag.DataInput.eta), htmlAttributes: new { type = "text", style = " width:100px; " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Температура воздуха, °C</td>\r\n                            <td>");
#nullable restore
#line 97 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextBox("DataInput.tair", (double)(ViewBag.DataInput.tair), htmlAttributes: new { type = "text", style = " width:100px; " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Температура газов, °C</td>\r\n                            <td>");
#nullable restore
#line 101 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextBox("DataInput.tgase", (double)(ViewBag.DataInput.tgase), htmlAttributes: new { type = "text", style = " width:100px; " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Средняя по массе начальная температура материала, °C</td>\r\n                            <td>");
#nullable restore
#line 105 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextBox("DataInput.tm1", (double)(ViewBag.DataInput.tm1), htmlAttributes: new { type = "text", style = " width:100px; " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Требуемая производительность, кг/ч</td>\r\n                            <td>");
#nullable restore
#line 109 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextBox("DataInput.Gt", (double)(ViewBag.DataInput.Gt), htmlAttributes: new { type = "text", style = " width:100px; " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Процент химического недожога, %</td>\r\n                            <td>");
#nullable restore
#line 113 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextBox("DataInput.Him", (double)(ViewBag.DataInput.Him), htmlAttributes: new { type = "text", style = " width:100px; " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Объемное отношение кислорода к азоту в воздухе</td>\r\n                            <td>");
#nullable restore
#line 117 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextBox("DataInput.k", (double)(ViewBag.DataInput.k), htmlAttributes: new { type = "text", style = " width:100px; " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Удельная теплоемкость газов, кДж/(кг*К)</td>\r\n                            <td>");
#nullable restore
#line 121 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextBox("DataInput.Cgase", (double)(ViewBag.DataInput.Cgase), htmlAttributes: new { type = "text", style = " width:100px; " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Удельная теплоемкость сухого материала, кДж/(кг*К)</td>\r\n                            <td>");
#nullable restore
#line 125 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextBox("DataInput.Cmaterial", (double)(ViewBag.DataInput.Cmaterial), htmlAttributes: new { type = "text", style = " width:100px; " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Удельная теплоемкость влаги, кДж/(кг*К)</td>\r\n                            <td>");
#nullable restore
#line 129 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextBox("DataInput.Cwet", (double)(ViewBag.DataInput.Cwet), htmlAttributes: new { type = "text", style = " width:100px; " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Энтальпия водяного пара при 100 градусах цельсия, кДж/кг</td>\r\n                            <td>");
#nullable restore
#line 133 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextBox("DataInput.enthalpy100", (double)(ViewBag.DataInput.enthalpy100), htmlAttributes: new { type = "text", style = " width:100px; " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Диаметр барабана, м</td>\r\n                            <td>");
#nullable restore
#line 137 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextBox("DataInput.D", (double)(ViewBag.DataInput.D), htmlAttributes: new { type = "text", style = " width:100px; " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Длина барабана, м</td>\r\n                            <td>");
#nullable restore
#line 141 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
                           Write(Html.TextBox("DataInput.L", (double)(ViewBag.DataInput.L), htmlAttributes: new { type = "text", style = " width:100px; " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n");
                WriteLiteral("        <p>\r\n        </p>\r\n        <div class=\"form-group\" style=\"margin-left: auto; margin-top: 15px\">\r\n            <button type=\"submit\" style=\"font-size: 15px\" class=\"btn btn-primary\">Сохранить</button>\r\n        </div>\r\n");
#nullable restore
#line 153 "E:\Махов Г.Н\РПО\123901_MakhovGrigory\App\Baraban\Baraban\Views\Home\DataInputAdd.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</html>

<script>
    $(document).ready(function () {
        
        const a = (e) => {
            var charCode = (e.which) ? e.which : event.keyCode

            if (String.fromCharCode(charCode).match(/[^0-9\,]/g))

                return false;
        }
        $('input:not([name = ""DataInput.Name""])').keypress(a);

    });
</script>

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Baraban.Models.DataInputModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
