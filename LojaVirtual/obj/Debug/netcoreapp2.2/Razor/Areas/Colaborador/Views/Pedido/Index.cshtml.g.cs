#pragma checksum "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c537526104724c5e9dcb56109658a43ca711daa8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Colaborador_Views_Pedido_Index), @"mvc.1.0.view", @"/Areas/Colaborador/Views/Pedido/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Colaborador/Views/Pedido/Index.cshtml", typeof(AspNetCore.Areas_Colaborador_Views_Pedido_Index))]
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
#line 10 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 11 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Json.Resolver;

#line default
#line hidden
#line 12 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Texto;

#line default
#line hidden
#line 14 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models.Contants;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c537526104724c5e9dcb56109658a43ca711daa8", @"/Areas/Colaborador/Views/Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57687725793cb78ac88b0dff4b85750171ed3826", @"/Areas/Colaborador/Views/_ViewImports.cshtml")]
    public class Areas_Colaborador_Views_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Pedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Visualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var codigoPedido = Context.Request.Query["codigoPedido"];
    var cpf = Context.Request.Query["cpf"];

#line default
#line hidden
            BeginContext(176, 49, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n<div class=\"container\">\r\n\r\n    ");
            EndContext();
            BeginContext(225, 416, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c537526104724c5e9dcb56109658a43ca711daa86340", async() => {
                BeginContext(264, 124, true);
                WriteLiteral("\r\n\r\n        <label for=\"numeroPedido\">Nº pedido</label>\r\n        <input type=\"text\" name=\"codigoPedido\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 388, "\"", 409, 1);
#line 15 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 396, codigoPedido, 396, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(410, 119, true);
                WriteLiteral(" id=\"numeroPedido\">\r\n\r\n        <label for=\"cpf\">CPF</label>\r\n        <input type=\"text\" name=\"cpf\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 529, "\"", 541, 1);
#line 18 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 537, cpf, 537, 4, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(542, 92, true);
                WriteLiteral(" id=\"cpf\">\r\n\r\n        <button type=\"submit\" class=\"btn btn-primary\">Pesquisar</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(641, 16, true);
            WriteLiteral("\r\n    <br />\r\n\r\n");
            EndContext();
#line 24 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
       await Html.RenderPartialAsync("~/Views/Shared/_Mensagem.cshtml"); 

#line default
#line hidden
            BeginContext(733, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 26 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
     if (Model.Count > 0)
    {

#line default
#line hidden
            BeginContext(769, 659, true);
            WriteLiteral(@"        <div class=""table-responsive"">
            <table class=""table table-bordered"">
                <thead>
                    <tr>
                        <th scope=""col"">Nº Pedido</th>
                        <th scope=""col"">Cliente</th>
                        <th scope=""col"">Data compra</th>
                        <th scope=""col"">Valor</th>
                        <th scope=""col"">Forma pagamento</th>
                        <th scope=""col"">Situação</th>
                        <th scope=""col"">NF-e</th>
                        <th scope=""col"">Ações</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 43 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                     foreach (var pedido in Model)
                    {

#line default
#line hidden
            BeginContext(1503, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1566, 9, false);
#line 46 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                           Write(pedido.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1575, 1, true);
            WriteLiteral("-");
            EndContext();
            BeginContext(1577, 20, false);
#line 46 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                                      Write(pedido.TransactionId);

#line default
#line hidden
            EndContext();
            BeginContext(1597, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1637, 19, false);
#line 47 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                           Write(pedido.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1656, 4, true);
            WriteLiteral("  - ");
            EndContext();
            BeginContext(1661, 18, false);
#line 47 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                                                   Write(pedido.Cliente.CPF);

#line default
#line hidden
            EndContext();
            BeginContext(1679, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1719, 42, false);
#line 48 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                           Write(pedido.DataRegistro.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1761, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1801, 31, false);
#line 49 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                           Write(pedido.ValorTotal.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(1832, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1872, 21, false);
#line 50 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                           Write(pedido.FormaPagamento);

#line default
#line hidden
            EndContext();
            BeginContext(1893, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1933, 15, false);
#line 51 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                           Write(pedido.Situacao);

#line default
#line hidden
            EndContext();
            BeginContext(1948, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1988, 10, false);
#line 52 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                           Write(pedido.NFE);

#line default
#line hidden
            EndContext();
            BeginContext(1998, 73, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2071, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c537526104724c5e9dcb56109658a43ca711daa814863", async() => {
                BeginContext(2124, 10, true);
                WriteLiteral("Visualizar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                                                             WriteLiteral(pedido.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2138, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 57 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2229, 66, true);
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n");
            EndContext();
#line 62 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2302, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(2309, 134, false);
#line 64 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, pagina => Url.Action("Index", new { pagina = pagina, codigoPedido = codigoPedido, cpf = cpf })));

#line default
#line hidden
            EndContext();
            BeginContext(2443, 12, true);
            WriteLiteral("\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Pedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
