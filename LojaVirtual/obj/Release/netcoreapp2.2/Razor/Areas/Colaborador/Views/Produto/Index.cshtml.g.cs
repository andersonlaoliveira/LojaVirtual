#pragma checksum "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e74987f16d08eccc31a6435b006669fe4e7950d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Colaborador_Views_Produto_Index), @"mvc.1.0.view", @"/Areas/Colaborador/Views/Produto/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Colaborador/Views/Produto/Index.cshtml", typeof(AspNetCore.Areas_Colaborador_Views_Produto_Index))]
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
#line 3 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 4 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 6 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#line 7 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#line 8 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models.Constants;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e74987f16d08eccc31a6435b006669fe4e7950d", @"/Areas/Colaborador/Views/Produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"534859548de2b4cb43772b1276347fed152c4b8d", @"/Areas/Colaborador/Views/_ViewImports.cshtml")]
    public class Areas_Colaborador_Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<LojaVirtual.Models.ProdutoAgregador.Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Atualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Excluir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var pesquisa = Context.Request.Query["pesquisa"];

#line default
#line hidden
            BeginContext(172, 43, true);
            WriteLiteral("\r\n<h1>Produto</h1>\r\n\r\n<!-- Formulário -->\r\n");
            EndContext();
            BeginContext(215, 317, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e74987f16d08eccc31a6435b006669fe4e7950d6894", async() => {
                BeginContext(234, 114, true);
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label for=\"pesquisa\"></label>\r\n        <input type=\"text\" name=\"pesquisa\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 348, "\"", 365, 1);
#line 13 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
WriteAttributeValue("", 356, pesquisa, 356, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(366, 159, true);
                WriteLiteral(" id=\"pesquisa\" class=\"form-control\" placeholder=\"Digite o nome do produto\">\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Pesquisar</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(532, 20, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n\r\n");
            EndContext();
#line 20 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
 if (TempData["MSG_S"] != null)
{

#line default
#line hidden
            BeginContext(588, 35, true);
            WriteLiteral("    <p class=\"alert alert-success\">");
            EndContext();
            BeginContext(624, 17, false);
#line 22 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                              Write(TempData["MSG_S"]);

#line default
#line hidden
            EndContext();
            BeginContext(641, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 23 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
}

#line default
#line hidden
            BeginContext(650, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(652, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e74987f16d08eccc31a6435b006669fe4e7950d10288", async() => {
                BeginContext(702, 9, true);
                WriteLiteral("Cadastrar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(715, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 28 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
 if (Model.Count > 0)
{


#line default
#line hidden
            BeginContext(749, 161, true);
            WriteLiteral("    <div class=\"table-responsive\">\r\n        <table class=\"table table-bordered\">\r\n            <thead>\r\n                <tr>\r\n                    <th scope=\"col\">");
            EndContext();
            BeginContext(911, 46, false);
#line 35 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.First().Id));

#line default
#line hidden
            EndContext();
            BeginContext(957, 43, true);
            WriteLiteral("</th>\r\n                    <th scope=\"col\">");
            EndContext();
            BeginContext(1001, 48, false);
#line 36 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.First().Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1049, 43, true);
            WriteLiteral("</th>\r\n                    <th scope=\"col\">");
            EndContext();
            BeginContext(1093, 53, false);
#line 37 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.First().Categoria));

#line default
#line hidden
            EndContext();
            BeginContext(1146, 43, true);
            WriteLiteral("</th>\r\n                    <th scope=\"col\">");
            EndContext();
            BeginContext(1190, 49, false);
#line 38 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.First().Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1239, 121, true);
            WriteLiteral("</th>\r\n                    <th scope=\"col\">Ações</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 43 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                 foreach (Produto produto in Model)
                {

#line default
#line hidden
            BeginContext(1432, 66, true);
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
            EndContext();
            BeginContext(1499, 10, false);
#line 46 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                                   Write(produto.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1509, 35, true);
            WriteLiteral("</th>\r\n                        <td>");
            EndContext();
            BeginContext(1545, 12, false);
#line 47 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                       Write(produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1557, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1593, 19, false);
#line 48 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                       Write(produto.CategoriaId);

#line default
#line hidden
            EndContext();
            BeginContext(1612, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1648, 13, false);
#line 49 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                       Write(produto.Valor);

#line default
#line hidden
            EndContext();
            BeginContext(1661, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1726, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e74987f16d08eccc31a6435b006669fe4e7950d16247", async() => {
                BeginContext(1805, 9, true);
                WriteLiteral("Atualizar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                                                        WriteLiteral(produto.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1818, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1848, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e74987f16d08eccc31a6435b006669fe4e7950d18744", async() => {
                BeginContext(1922, 7, true);
                WriteLiteral("Excluir");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                                                      WriteLiteral(produto.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1933, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 55 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2012, 52, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
            EndContext();
            BeginContext(2071, 115, false);
#line 60 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, pagina => Url.Action("Index", new { pagina = pagina, pesquisa = pesquisa })));

#line default
#line hidden
            EndContext();
#line 60 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                                                                                                                        

}
else
{

#line default
#line hidden
            BeginContext(2202, 46, true);
            WriteLiteral("    <span>Nenhum registro cadastrado!</span>\r\n");
            EndContext();
#line 66 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<LojaVirtual.Models.ProdutoAgregador.Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
