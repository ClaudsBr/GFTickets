#pragma checksum "C:\Users\coot\OneDrive - GFT Technologies SE\Documents\GFTickets\Views\Gestao\Estoque.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9172587a184919ceddd476e60e4fbd72e23981af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gestao_Estoque), @"mvc.1.0.view", @"/Views/Gestao/Estoque.cshtml")]
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
#line 1 "C:\Users\coot\OneDrive - GFT Technologies SE\Documents\GFTickets\Views\_ViewImports.cshtml"
using ClaudEventos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\coot\OneDrive - GFT Technologies SE\Documents\GFTickets\Views\_ViewImports.cshtml"
using ClaudEventos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9172587a184919ceddd476e60e4fbd72e23981af", @"/Views/Gestao/Estoque.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f22efb2ba233d7383cf2b1738cb80ceb493b3c62", @"/Views/_ViewImports.cshtml")]
    public class Views_Gestao_Estoque : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClaudEventos.Models.Estoque>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NovoEstoque", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gestao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\coot\OneDrive - GFT Technologies SE\Documents\GFTickets\Views\Gestao\Estoque.cshtml"
  
    Layout= "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2> Estoque</h2>\r\n<hr/>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9172587a184919ceddd476e60e4fbd72e23981af4349", async() => {
                WriteLiteral("Criar Estoque");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    $(document).ready( function () {
    $('#estoques').DataTable({
        ""info"": false, 
        ""language"" : {
            ""lengthMenu"": "" _MENU_ registros por página"",
            ""zeRecords"": ""Desculpe, Nada foi encontrado"",
            ""info"": ""Exibindo _PAGE_ de _PAGES_"",
            ""infoEmpty"": ""Nenhum registro disponível"",
            ""search"": ""Buscar"",
            ""paginate"": {
                ""first"": ""Primeira"",
                ""last"": ""Última"",
                ""next"": ""Próxima"",
                ""previous"": ""Anterior""
            }
        }
    });
} );
</script>

<table class=""table table-sm table-bordered"" id=""estoques"">
    <thead class=""thead-dark"">
        <tr>
            <th> Id </th>
            <th> Evento </th>
            <th> Quantidade</th>
            <th> Editar </th>
                        
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 40 "C:\Users\coot\OneDrive - GFT Technologies SE\Documents\GFTickets\Views\Gestao\Estoque.cshtml"
        foreach (var estoque in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <tr>\r\n             <td>");
#nullable restore
#line 42 "C:\Users\coot\OneDrive - GFT Technologies SE\Documents\GFTickets\Views\Gestao\Estoque.cshtml"
            Write(estoque.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             <td>");
#nullable restore
#line 43 "C:\Users\coot\OneDrive - GFT Technologies SE\Documents\GFTickets\Views\Gestao\Estoque.cshtml"
            Write(estoque.Evento.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             <td>");
#nullable restore
#line 44 "C:\Users\coot\OneDrive - GFT Technologies SE\Documents\GFTickets\Views\Gestao\Estoque.cshtml"
            Write(estoque.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             \r\n             <td><a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 1358, "\"", 1398, 2);
            WriteAttributeValue("", 1365, "/Gestao/EditarEstoque/", 1365, 22, true);
#nullable restore
#line 46 "C:\Users\coot\OneDrive - GFT Technologies SE\Documents\GFTickets\Views\Gestao\Estoque.cshtml"
WriteAttributeValue("", 1387, estoque.Id, 1387, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n             \r\n         </tr>             \r\n");
#nullable restore
#line 49 "C:\Users\coot\OneDrive - GFT Technologies SE\Documents\GFTickets\Views\Gestao\Estoque.cshtml"
       } 

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClaudEventos.Models.Estoque>> Html { get; private set; }
    }
}
#pragma warning restore 1591
