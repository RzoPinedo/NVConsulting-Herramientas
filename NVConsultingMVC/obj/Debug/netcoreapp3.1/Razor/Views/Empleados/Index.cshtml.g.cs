#pragma checksum "C:\Users\Leo Pinedo\Desktop\Repositorios\HP2\NVConsulting-Herramientas\NVConsultingMVC\Views\Empleados\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "503053c8d4557387291d1f8acff5becddae854ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleados_Index), @"mvc.1.0.view", @"/Views/Empleados/Index.cshtml")]
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
#line 1 "C:\Users\Leo Pinedo\Desktop\Repositorios\HP2\NVConsulting-Herramientas\NVConsultingMVC\Views\_ViewImports.cshtml"
using NVConsultingMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Leo Pinedo\Desktop\Repositorios\HP2\NVConsulting-Herramientas\NVConsultingMVC\Views\_ViewImports.cshtml"
using NVConsultingMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"503053c8d4557387291d1f8acff5becddae854ea", @"/Views/Empleados/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e05d9bc814d20a2aa99304ddea933e45e0374e95", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleados_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NVConsultingMVC.Models.VMEmpleados>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("main"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Leo Pinedo\Desktop\Repositorios\HP2\NVConsulting-Herramientas\NVConsultingMVC\Views\Empleados\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "503053c8d4557387291d1f8acff5becddae854ea4438", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Alumnos</title>
    <link href=""css/estilos.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""css/bootstrap.css"" rel=""stylesheet"">
    <link href=""css/bootstrap.min.css"" rel=""stylesheet"">
    <link href=""estilos.css"" rel=""stylesheet"">
    <!---<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">--->
");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "503053c8d4557387291d1f8acff5becddae854ea6087", async() => {
                WriteLiteral("\r\n\r\n    <h1>Index</h1>\r\n\r\n    <p>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "503053c8d4557387291d1f8acff5becddae854ea6394", async() => {
                    WriteLiteral("Create New");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </p>\r\n    <table class=\"table\">\r\n        <thead class=\"thead-dark\">\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 30 "C:\Users\Leo Pinedo\Desktop\Repositorios\HP2\NVConsulting-Herramientas\NVConsultingMVC\Views\Empleados\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.IdEmpleados));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 33 "C:\Users\Leo Pinedo\Desktop\Repositorios\HP2\NVConsulting-Herramientas\NVConsultingMVC\Views\Empleados\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Nombres));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 36 "C:\Users\Leo Pinedo\Desktop\Repositorios\HP2\NVConsulting-Herramientas\NVConsultingMVC\Views\Empleados\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Apellidos));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 39 "C:\Users\Leo Pinedo\Desktop\Repositorios\HP2\NVConsulting-Herramientas\NVConsultingMVC\Views\Empleados\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Dni));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 42 "C:\Users\Leo Pinedo\Desktop\Repositorios\HP2\NVConsulting-Herramientas\NVConsultingMVC\Views\Empleados\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Correo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 45 "C:\Users\Leo Pinedo\Desktop\Repositorios\HP2\NVConsulting-Herramientas\NVConsultingMVC\Views\Empleados\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 48 "C:\Users\Leo Pinedo\Desktop\Repositorios\HP2\NVConsulting-Herramientas\NVConsultingMVC\Views\Empleados\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 51 "C:\Users\Leo Pinedo\Desktop\Repositorios\HP2\NVConsulting-Herramientas\NVConsultingMVC\Views\Empleados\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.IdCargo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody class=\"text-dark\">\r\n");
#nullable restore
#line 57 "C:\Users\Leo Pinedo\Desktop\Repositorios\HP2\NVConsulting-Herramientas\NVConsultingMVC\Views\Empleados\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr class=\"table-secondary\">\r\n                    <td>\r\n                        ");
#nullable restore
#line 61 "C:\Users\Leo Pinedo\Desktop\Repositorios\HP2\NVConsulting-Herramientas\NVConsultingMVC\Views\Empleados\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IdEmpleados));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 64 "C:\Users\Leo Pinedo\Desktop\Repositorios\HP2\NVConsulting-Herramientas\NVConsultingMVC\Views\Empleados\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nombres));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 67 "C:\Users\Leo Pinedo\Desktop\Repositorios\HP2\NVConsulting-Herramientas\NVConsultingMVC\Views\Empleados\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Apellidos));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 70 "C:\Users\Leo Pinedo\Desktop\Repositorios\HP2\NVConsulting-Herramientas\NVConsultingMVC\Views\Empleados\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Dni));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 73 "C:\Users\Leo Pinedo\Desktop\Repositorios\HP2\NVConsulting-Herramientas\NVConsultingMVC\Views\Empleados\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Correo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 76 "C:\Users\Leo Pinedo\Desktop\Repositorios\HP2\NVConsulting-Herramientas\NVConsultingMVC\Views\Empleados\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Telefono));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 79 "C:\Users\Leo Pinedo\Desktop\Repositorios\HP2\NVConsulting-Herramientas\NVConsultingMVC\Views\Empleados\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Direccion));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 82 "C:\Users\Leo Pinedo\Desktop\Repositorios\HP2\NVConsulting-Herramientas\NVConsultingMVC\Views\Empleados\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IdCargo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 85 "C:\Users\Leo Pinedo\Desktop\Repositorios\HP2\NVConsulting-Herramientas\NVConsultingMVC\Views\Empleados\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id = item.IdEmpleados }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                        ");
#nullable restore
#line 86 "C:\Users\Leo Pinedo\Desktop\Repositorios\HP2\NVConsulting-Herramientas\NVConsultingMVC\Views\Empleados\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { id = item.IdEmpleados }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                        ");
#nullable restore
#line 87 "C:\Users\Leo Pinedo\Desktop\Repositorios\HP2\NVConsulting-Herramientas\NVConsultingMVC\Views\Empleados\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id = item.IdEmpleados }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 90 "C:\Users\Leo Pinedo\Desktop\Repositorios\HP2\NVConsulting-Herramientas\NVConsultingMVC\Views\Empleados\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NVConsultingMVC.Models.VMEmpleados>> Html { get; private set; }
    }
}
#pragma warning restore 1591
