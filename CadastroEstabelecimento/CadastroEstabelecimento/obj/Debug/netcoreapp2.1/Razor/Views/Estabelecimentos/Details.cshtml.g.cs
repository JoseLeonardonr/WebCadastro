#pragma checksum "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ad43ddb092f620704a1f2c6b68e7e6fac170e34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estabelecimentos_Details), @"mvc.1.0.view", @"/Views/Estabelecimentos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Estabelecimentos/Details.cshtml", typeof(AspNetCore.Views_Estabelecimentos_Details))]
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
#line 1 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\_ViewImports.cshtml"
using CadastroEstabelecimento;

#line default
#line hidden
#line 2 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\_ViewImports.cshtml"
using CadastroEstabelecimento.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ad43ddb092f620704a1f2c6b68e7e6fac170e34", @"/Views/Estabelecimentos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97ea5aee9707961797eff48a2c9758b9cea9da8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Estabelecimentos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CadastroEstabelecimento.Models.Estabelecimentos>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
  
    ViewData["Title"] = "Excluir Estabelecimento";

#line default
#line hidden
            BeginContext(118, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(125, 17, false);
#line 7 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(142, 107, true);
            WriteLiteral("</h2>\r\n\r\n<div>\r\n    <h4>Seller</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(250, 41, false);
#line 14 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Razao));

#line default
#line hidden
            EndContext();
            BeginContext(291, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(335, 37, false);
#line 17 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Razao));

#line default
#line hidden
            EndContext();
            BeginContext(372, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(416, 40, false);
#line 20 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(456, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(500, 36, false);
#line 23 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(536, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(580, 40, false);
#line 26 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cnpj));

#line default
#line hidden
            EndContext();
            BeginContext(620, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(664, 36, false);
#line 29 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cnpj));

#line default
#line hidden
            EndContext();
            BeginContext(700, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(744, 41, false);
#line 32 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(785, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(829, 37, false);
#line 35 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(866, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(910, 44, false);
#line 38 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Endereco));

#line default
#line hidden
            EndContext();
            BeginContext(954, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(998, 40, false);
#line 41 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Endereco));

#line default
#line hidden
            EndContext();
            BeginContext(1038, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1082, 48, false);
#line 44 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataCadastro));

#line default
#line hidden
            EndContext();
            BeginContext(1130, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1174, 44, false);
#line 47 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataCadastro));

#line default
#line hidden
            EndContext();
            BeginContext(1218, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1262, 42, false);
#line 50 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1304, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1348, 38, false);
#line 53 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1386, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1430, 42, false);
#line 56 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1472, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1516, 38, false);
#line 59 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1554, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1598, 44, false);
#line 62 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
            EndContext();
            BeginContext(1642, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1686, 40, false);
#line 65 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Telefone));

#line default
#line hidden
            EndContext();
            BeginContext(1726, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1770, 46, false);
#line 68 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Categorias));

#line default
#line hidden
            EndContext();
            BeginContext(1816, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1860, 61, false);
#line 71 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Categorias.CategoriaDescricao));

#line default
#line hidden
            EndContext();
            BeginContext(1921, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1965, 43, false);
#line 74 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Agencia));

#line default
#line hidden
            EndContext();
            BeginContext(2008, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2052, 39, false);
#line 77 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Agencia));

#line default
#line hidden
            EndContext();
            BeginContext(2091, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2135, 41, false);
#line 80 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Conta));

#line default
#line hidden
            EndContext();
            BeginContext(2176, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2220, 37, false);
#line 83 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Conta));

#line default
#line hidden
            EndContext();
            BeginContext(2257, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2304, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "909e3b4f1a06479c8f8e9093c86a7545", async() => {
                BeginContext(2381, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 88 "C:\Users\alfac\Desktop\Teste Pratico\CadastroEstabelecimento\CadastroEstabelecimento\Views\Estabelecimentos\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2391, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(2397, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb9bf0d75a5f4a4ca0b967d7929c6683", async() => {
                BeginContext(2450, 6, true);
                WriteLiteral("Voltar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2460, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CadastroEstabelecimento.Models.Estabelecimentos> Html { get; private set; }
    }
}
#pragma warning restore 1591