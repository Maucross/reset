#pragma checksum "C:\Users\mau_a\Desktop\CLASES\6TO CICLO\SW2\PROYECTO RESET\Pro_ResetProgra\Views\Licitacion\EvaluarLicitacion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8f1aace02e42dbfeae058af77d11976b89abb41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Licitacion_EvaluarLicitacion), @"mvc.1.0.view", @"/Views/Licitacion/EvaluarLicitacion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Licitacion/EvaluarLicitacion.cshtml", typeof(AspNetCore.Views_Licitacion_EvaluarLicitacion))]
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
#line 1 "C:\Users\mau_a\Desktop\CLASES\6TO CICLO\SW2\PROYECTO RESET\Pro_ResetProgra\Views\_ViewImports.cshtml"
using Pro_ResetProgra;

#line default
#line hidden
#line 2 "C:\Users\mau_a\Desktop\CLASES\6TO CICLO\SW2\PROYECTO RESET\Pro_ResetProgra\Views\_ViewImports.cshtml"
using Pro_ResetProgra.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8f1aace02e42dbfeae058af77d11976b89abb41", @"/Views/Licitacion/EvaluarLicitacion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6048294792c48de89e19cc3bf54265b9f886129", @"/Views/_ViewImports.cshtml")]
    public class Views_Licitacion_EvaluarLicitacion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Aprobado", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Desaprobado", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Pendiente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 1 "C:\Users\mau_a\Desktop\CLASES\6TO CICLO\SW2\PROYECTO RESET\Pro_ResetProgra\Views\Licitacion\EvaluarLicitacion.cshtml"
  
    ViewData["Title"] = "EvaluarLicitacion";

#line default
#line hidden
            BeginContext(53, 1163, true);
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-md-12"">
        <h1 style=""text-align:center"">Evaluar Licitación de Requerimientos de Máquinas</h2>
        
    </div>
</div>
<div class=""row"">    
    <div class=""col-md-3"">
       Usuario: <input type=""text"" value=""Alejandro Uribe"">
    </div>

</div><br>
<div  class=""row"">
   
    <div class=""borde col-md-4"">
        <h3>Datos del Cliente</h3>
            <div>RUC: <input type=""text"" value=""992775138""></div><br>
            <div>
                Empresa: <input type=""text"" value=""US ITEM S.A"">
            </div><br>
         
    </div>
    <div class=""borde col-md-4"">
        <h3>Datos de Licitación</h3>
            <div>Número de Licitacion: <input type=""text"" value=""08966413""></div><br>
            <div>
                Fecha de Entrega: <input type=""date"">
            </div><br>
    </div>
    <div class=""borde col-md-4"">
        <br>
            <div>Usuario Creador:<input type=""text"" value=""Alejandro Uribe""></div><br>
        ");
            WriteLiteral("    <div>\r\n               Fecha de Creación:<input type=\"date\">\r\n            </div><br>\r\n            <div>\r\n                Estado:<select>");
            EndContext();
            BeginContext(1216, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f93e922c0b048288739d95f24ed5892", async() => {
                BeginContext(1241, 8, true);
                WriteLiteral("Aprobado");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1258, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1272, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "871bf2abdb594d72b141852656abb87b", async() => {
                BeginContext(1300, 11, true);
                WriteLiteral("Desaprobado");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1320, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1334, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd8c3a9378284b058d903e571d6df875", async() => {
                BeginContext(1360, 9, true);
                WriteLiteral("Pendiente");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1378, 1459, true);
            WriteLiteral(@"
        </select> 
            </div><br>
    </div>
    
</div><br>
<div class=""row"">
    <div class=""col-md-12"">
      <table style=""width:100%"">
          <tr>
              <th>Item</th>
              <th>Cantidad</th>
              <th>Descripción</th>
              <th>Marca</th>
              <th>Características</th>
              <th>Garantía</th>
              
          </tr>
          <tr>
              <td>1</td>
              <td>15</td>
              <td>Computadora de Escritorio</td>
              <td></td>
              <td></td>
              <td>1 año</td>
    
          </tr>
          <tr>
          </tr>
          <tr>
              
          </tr>
          <tr>
              
          </tr>
          <tr>
              
          </tr>
          <tr></tr>
      </table>
    </div>

</div><br>
<div class=""row"">
    <div class=""col-md-8"">
    </div>
    <div style=""text-align:right"" class=""col-md-2"">
        <button type=""button""class=""btn");
            WriteLiteral(@" btn-primary btn-sm"">Exportar Documento</button>
    </div>
</div><br>
<div class=""row"">
    <div class=""col-md-7"">
    </div>
    <div style=""text-align:right"" class=""col-md-5"">
       <button type=""button""class=""btn btn-primary btn-sm"">Regresar</button>
       <button type=""button""class=""btn btn-primary btn-sm"">Limpiar</button>
       <button type=""button""class=""btn btn-primary btn-sm"">Grabar</button>
    </div>
</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
