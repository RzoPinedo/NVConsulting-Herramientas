#pragma checksum "C:\Users\User\Desktop\CarpetasIDAT\IV-Ciclo\Evaluaciones\Herramientas de Programación 2\sNVConsultingApi\NVConsultingMVC\Views\Cursos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd8affc688283cead4640e1719adef11f7760f07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cursos_Details), @"mvc.1.0.view", @"/Views/Cursos/Details.cshtml")]
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
#line 1 "C:\Users\User\Desktop\CarpetasIDAT\IV-Ciclo\Evaluaciones\Herramientas de Programación 2\sNVConsultingApi\NVConsultingMVC\Views\_ViewImports.cshtml"
using NVConsultingMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\CarpetasIDAT\IV-Ciclo\Evaluaciones\Herramientas de Programación 2\sNVConsultingApi\NVConsultingMVC\Views\_ViewImports.cshtml"
using NVConsultingMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd8affc688283cead4640e1719adef11f7760f07", @"/Views/Cursos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e05d9bc814d20a2aa99304ddea933e45e0374e95", @"/Views/_ViewImports.cshtml")]
    public class Views_Cursos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NVConsultingMVC.Models.VMCurso>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\User\Desktop\CarpetasIDAT\IV-Ciclo\Evaluaciones\Herramientas de Programación 2\sNVConsultingApi\NVConsultingMVC\Views\Cursos\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>VMCurso</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\User\Desktop\CarpetasIDAT\IV-Ciclo\Evaluaciones\Herramientas de Programación 2\sNVConsultingApi\NVConsultingMVC\Views\Cursos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdCursos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\User\Desktop\CarpetasIDAT\IV-Ciclo\Evaluaciones\Herramientas de Programación 2\sNVConsultingApi\NVConsultingMVC\Views\Cursos\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdCursos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\User\Desktop\CarpetasIDAT\IV-Ciclo\Evaluaciones\Herramientas de Programación 2\sNVConsultingApi\NVConsultingMVC\Views\Cursos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\User\Desktop\CarpetasIDAT\IV-Ciclo\Evaluaciones\Herramientas de Programación 2\sNVConsultingApi\NVConsultingMVC\Views\Cursos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\User\Desktop\CarpetasIDAT\IV-Ciclo\Evaluaciones\Herramientas de Programación 2\sNVConsultingApi\NVConsultingMVC\Views\Cursos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NroHoras));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\User\Desktop\CarpetasIDAT\IV-Ciclo\Evaluaciones\Herramientas de Programación 2\sNVConsultingApi\NVConsultingMVC\Views\Cursos\Details.cshtml"
       Write(Html.DisplayFor(model => model.NroHoras));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\User\Desktop\CarpetasIDAT\IV-Ciclo\Evaluaciones\Herramientas de Programación 2\sNVConsultingApi\NVConsultingMVC\Views\Cursos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\User\Desktop\CarpetasIDAT\IV-Ciclo\Evaluaciones\Herramientas de Programación 2\sNVConsultingApi\NVConsultingMVC\Views\Cursos\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\User\Desktop\CarpetasIDAT\IV-Ciclo\Evaluaciones\Herramientas de Programación 2\sNVConsultingApi\NVConsultingMVC\Views\Cursos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\User\Desktop\CarpetasIDAT\IV-Ciclo\Evaluaciones\Herramientas de Programación 2\sNVConsultingApi\NVConsultingMVC\Views\Cursos\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\User\Desktop\CarpetasIDAT\IV-Ciclo\Evaluaciones\Herramientas de Programación 2\sNVConsultingApi\NVConsultingMVC\Views\Cursos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PrecioCurso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\User\Desktop\CarpetasIDAT\IV-Ciclo\Evaluaciones\Herramientas de Programación 2\sNVConsultingApi\NVConsultingMVC\Views\Cursos\Details.cshtml"
       Write(Html.DisplayFor(model => model.PrecioCurso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\User\Desktop\CarpetasIDAT\IV-Ciclo\Evaluaciones\Herramientas de Programación 2\sNVConsultingApi\NVConsultingMVC\Views\Cursos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdEmpleados));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\User\Desktop\CarpetasIDAT\IV-Ciclo\Evaluaciones\Herramientas de Programación 2\sNVConsultingApi\NVConsultingMVC\Views\Cursos\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdEmpleados));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 59 "C:\Users\User\Desktop\CarpetasIDAT\IV-Ciclo\Evaluaciones\Herramientas de Programación 2\sNVConsultingApi\NVConsultingMVC\Views\Cursos\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd8affc688283cead4640e1719adef11f7760f079929", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NVConsultingMVC.Models.VMCurso> Html { get; private set; }
    }
}
#pragma warning restore 1591
