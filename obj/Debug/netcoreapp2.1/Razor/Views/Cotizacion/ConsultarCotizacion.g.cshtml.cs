#pragma checksum "C:\Users\mau_a\Desktop\CLASES\6TO CICLO\SW2\PROYECTO RESET\Pro_ResetProgra\Views\Cotizacion\ConsultarCotizacion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac904aa82e727a13f0baca5638d8ebe02cae9c32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cotizacion_ConsultarCotizacion), @"mvc.1.0.view", @"/Views/Cotizacion/ConsultarCotizacion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cotizacion/ConsultarCotizacion.cshtml", typeof(AspNetCore.Views_Cotizacion_ConsultarCotizacion))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac904aa82e727a13f0baca5638d8ebe02cae9c32", @"/Views/Cotizacion/ConsultarCotizacion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6048294792c48de89e19cc3bf54265b9f886129", @"/Views/_ViewImports.cshtml")]
    public class Views_Cotizacion_ConsultarCotizacion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\mau_a\Desktop\CLASES\6TO CICLO\SW2\PROYECTO RESET\Pro_ResetProgra\Views\Cotizacion\ConsultarCotizacion.cshtml"
  
    ViewData["Title"] = "ConsultarCotizacion";

#line default
#line hidden
            BeginContext(55, 620, true);
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-md-12"">
        <h1 style=""text-align:center"">Consultar Cotizacion  de Requerimientos de Máquinas</h2>
        
    </div>
</div>
<div class=""borde row"">    
    <div class=""col-md-4"">
        Número de Cotizacion:<br>
        <input type=""text"" value=""08966413"">
    </div><br>
     <div class=""col-md-2"">RUC: <input type=""text"" value=""992775138""></div>
     <div class=""col-md-2"">Empresa: <input type=""text"" value=""US ITEM S.A""></div>
    <div class=""col-md-2"">
        Fecha de Creación:<input type=""date"">
    </div>
    <div class=""col-md-2"">Estado:<select>");
            EndContext();
            BeginContext(675, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddc0926edb1f4f70940ab47ae8cf9f64", async() => {
                BeginContext(700, 8, true);
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
            BeginContext(717, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(731, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e69a4b6e8c44291958b717787100a62", async() => {
                BeginContext(759, 11, true);
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
            BeginContext(779, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(793, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce3b1bc3e6864836aed6b503c8acce5a", async() => {
                BeginContext(819, 9, true);
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
            BeginContext(837, 1680, true);
            WriteLiteral(@"
        </select> </div>
</div><br>
<div>
    <button type=""button""class=""btn btn-primary btn-sm"">Consultar</button>
</div><br>
<div class=""row"">
    <div class=""col-md-12"">
      <table style=""width:100%"">
          <tr>
              <th>Número de Cotizacion</th>
              <th>RUC</th>
              <th>Empresa</th>
              <th>Fecha de Creación</th>
              <th>Estado</th>
              <th></th>
          </tr>
          <tr>
              <td>000000000010</td>
              <td>20110343907</td>
              <td>U.S. ITEM S.A</td>
              <td>28/08/2018  </td>
              <td>Pendiente</td>
              <td><input type=""button"" value=""Visualizar""></td>
          </tr>
          <tr> <td>000000000020</td>
              <td>20110343907</td>
              <td>U.S. ITEM S.A</td>
              <td>28/08/2018  </td>
              <td>Desaprobado</td>
              <td><input type=""button"" value=""Visualizar""></td>
          </tr>
          <tr>
        ");
            WriteLiteral(@"       <td>000000000030</td>
              <td>20110343907</td>
              <td>U.S. ITEM S.A</td>
              <td>28/08/2018  </td>
              <td>Aprobado</td>
              <td><input type=""button"" value=""Visualizar""></td>
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
</div><br>
<div class=""row"">
    <div class=""col-md-7"">
    </div>
    <div style=""text-align:right"" class=""col-md-5"">
       <button type=""button""class=""btn btn-primary btn-sm"">Regresar</button>
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