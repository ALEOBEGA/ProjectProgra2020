#pragma checksum "C:\Users\Amorm\OneDrive\Escritorio\Final\ProjectProgra2020\Views\Cliente\Reporte.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "171d7c0fa4bdb803636aef747c1f87947fd73750"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Reporte), @"mvc.1.0.view", @"/Views/Cliente/Reporte.cshtml")]
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
#line 1 "C:\Users\Amorm\OneDrive\Escritorio\Final\ProjectProgra2020\Views\_ViewImports.cshtml"
using ProjectProgra2020;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Amorm\OneDrive\Escritorio\Final\ProjectProgra2020\Views\Cliente\Reporte.cshtml"
using ProjectProgra2020.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"171d7c0fa4bdb803636aef747c1f87947fd73750", @"/Views/Cliente/Reporte.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5997b91fd43987bb2905252e106b81ecd9b50208", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Reporte : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ventas>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(",\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "171d7c0fa4bdb803636aef747c1f87947fd737503167", async() => {
                WriteLiteral(@"
      <div class=""container"">
        <div class=""row"">


                                  <table class=""table table-dark table-striped"">
                            <thead>
                               <tr>
                                 <th scope=""col"">ID ventas</th>                                 
                                 <th scope=""col"">DNI Cliente</th>
                                 <th scope=""col"">ID producto</th>
                                 <th scope=""col"">fecha de venta</th>
                                 <th scope=""col"">cantidad</th>  
                                 <th scope=""col"">precio total</th>

                               </tr>
                            </thead>


");
#nullable restore
#line 23 "C:\Users\Amorm\OneDrive\Escritorio\Final\ProjectProgra2020\Views\Cliente\Reporte.cshtml"
                              foreach (var ventas in Model){
                             

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n\r\n                                <td>");
#nullable restore
#line 27 "C:\Users\Amorm\OneDrive\Escritorio\Final\ProjectProgra2020\Views\Cliente\Reporte.cshtml"
                               Write(ventas.idventas);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 28 "C:\Users\Amorm\OneDrive\Escritorio\Final\ProjectProgra2020\Views\Cliente\Reporte.cshtml"
                               Write(ventas.idcliente);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 29 "C:\Users\Amorm\OneDrive\Escritorio\Final\ProjectProgra2020\Views\Cliente\Reporte.cshtml"
                               Write(ventas.idproducto);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 30 "C:\Users\Amorm\OneDrive\Escritorio\Final\ProjectProgra2020\Views\Cliente\Reporte.cshtml"
                               Write(ventas.fechaventa);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 31 "C:\Users\Amorm\OneDrive\Escritorio\Final\ProjectProgra2020\Views\Cliente\Reporte.cshtml"
                               Write(ventas.cantidad);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 32 "C:\Users\Amorm\OneDrive\Escritorio\Final\ProjectProgra2020\Views\Cliente\Reporte.cshtml"
                               Write(ventas.preciot);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                                \r\n\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\Amorm\OneDrive\Escritorio\Final\ProjectProgra2020\Views\Cliente\Reporte.cshtml"


                             }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            \r\n                        </table>\r\n        </div>\r\n        \r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ventas>> Html { get; private set; }
    }
}
#pragma warning restore 1591
