#pragma checksum "C:\Users\c.vasconcelos\Documents\GitHub\testedotnet1\LH001\LH001\Pages\Estatistica\Desenvolvedor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "760e2d5345ac2e37ac84205d539f79e7eec0c729"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Estatistica_Desenvolvedor), @"mvc.1.0.razor-page", @"/Pages/Estatistica/Desenvolvedor.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"760e2d5345ac2e37ac84205d539f79e7eec0c729", @"/Pages/Estatistica/Desenvolvedor.cshtml")]
    public class Pages_Estatistica_Desenvolvedor : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\c.vasconcelos\Documents\GitHub\testedotnet1\LH001\LH001\Pages\Estatistica\Desenvolvedor.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div style=""width: 93%;padding-left: 7%;"">
    <div style=""font-size: 30px; font-family: Tahoma;"">
        <h1>Estatisticas Desenvolvedor</h1>
        <div style="" font-size: 15px;color: gray;"">
            <p>Mostra os cinco desenvolvedores com a maior media de trabalho nessa semana considerando que cada dia teria 12h.</p>
        </div>
    </div>
    <table class=""table table-striped table-hover"">
        <thead>
            <tr>
                <th scope=""col"">Nome</th>
                <th scope=""col"">Projetos Participados</th>
                <th scope=""col"">Horas Totais</th>
                <th scope=""col"">Dias Trabalhados</th>
                <th scope=""col"">Media</th>
            </tr>
        </thead>
        <tbody id=""tbBusca"">
");
#nullable restore
#line 24 "C:\Users\c.vasconcelos\Documents\GitHub\testedotnet1\LH001\LH001\Pages\Estatistica\Desenvolvedor.cshtml"
             if (Model.modalResult.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td></td>\r\n                <td></td>\r\n                <td>Nenhum resultado encontrado.</td>\r\n                <td></td>\r\n                <td></td>\r\n            </tr>\r\n");
#nullable restore
#line 33 "C:\Users\c.vasconcelos\Documents\GitHub\testedotnet1\LH001\LH001\Pages\Estatistica\Desenvolvedor.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\c.vasconcelos\Documents\GitHub\testedotnet1\LH001\LH001\Pages\Estatistica\Desenvolvedor.cshtml"
             foreach (var item in Model.modalResult)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 37 "C:\Users\c.vasconcelos\Documents\GitHub\testedotnet1\LH001\LH001\Pages\Estatistica\Desenvolvedor.cshtml"
                   Write(item.Tb_Desenvolvedor.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "C:\Users\c.vasconcelos\Documents\GitHub\testedotnet1\LH001\LH001\Pages\Estatistica\Desenvolvedor.cshtml"
                   Write(item.ProjetosEstatisticas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "C:\Users\c.vasconcelos\Documents\GitHub\testedotnet1\LH001\LH001\Pages\Estatistica\Desenvolvedor.cshtml"
                   Write(item.HorasTotais.ToString().Replace(",",":"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "C:\Users\c.vasconcelos\Documents\GitHub\testedotnet1\LH001\LH001\Pages\Estatistica\Desenvolvedor.cshtml"
                   Write(item.NumeroDiasTrabalhados);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "C:\Users\c.vasconcelos\Documents\GitHub\testedotnet1\LH001\LH001\Pages\Estatistica\Desenvolvedor.cshtml"
                   Write(item.Media);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                </tr>\r\n");
#nullable restore
#line 43 "C:\Users\c.vasconcelos\Documents\GitHub\testedotnet1\LH001\LH001\Pages\Estatistica\Desenvolvedor.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LH001.Pages.Estatistica.DesenvolvedorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LH001.Pages.Estatistica.DesenvolvedorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LH001.Pages.Estatistica.DesenvolvedorModel>)PageContext?.ViewData;
        public LH001.Pages.Estatistica.DesenvolvedorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
