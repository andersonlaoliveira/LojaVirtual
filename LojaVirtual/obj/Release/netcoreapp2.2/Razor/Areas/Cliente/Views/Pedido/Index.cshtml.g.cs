#pragma checksum "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40bc31b3ca8b55619398039345d25d7b88753952"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cliente_Views_Pedido_Index), @"mvc.1.0.view", @"/Areas/Cliente/Views/Pedido/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Cliente/Views/Pedido/Index.cshtml", typeof(AspNetCore.Areas_Cliente_Views_Pedido_Index))]
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
#line 3 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#line 4 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#line 5 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 6 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 7 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModel;

#line default
#line hidden
#line 8 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 9 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Texto;

#line default
#line hidden
#line 10 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Json.Resolver;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40bc31b3ca8b55619398039345d25d7b88753952", @"/Areas/Cliente/Views/Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b5a6d9e52f3bb853a2f7cf6a89a5f26fe1b175f", @"/Areas/Cliente/Views/_ViewImports.cshtml")]
    public class Areas_Cliente_Views_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Pedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Visualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(68, 45, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n<div class=\"container\">\r\n\r\n");
            EndContext();
#line 10 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
       await Html.RenderPartialAsync("~/Views/Shared/_Mensagem.cshtml"); 

#line default
#line hidden
            BeginContext(189, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 12 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
     if (Model.Count > 0)
    {

#line default
#line hidden
            BeginContext(225, 609, true);
            WriteLiteral(@"        <div class=""table-responsive"">
            <table class=""table table-bordered"">
                <thead>
                    <tr>
                        <th scope=""col"">N Pedido</th>
                        <th scope=""col"">Data da compra</th>
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
#line 29 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                     foreach (var pedido in Model)
                    {

#line default
#line hidden
            BeginContext(909, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(972, 9, false);
#line 32 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                           Write(pedido.Id);

#line default
#line hidden
            EndContext();
            BeginContext(981, 1, true);
            WriteLiteral("-");
            EndContext();
            BeginContext(983, 20, false);
#line 32 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                      Write(pedido.TransactionId);

#line default
#line hidden
            EndContext();
            BeginContext(1003, 40, true);
            WriteLiteral(" </td>\r\n                            <td>");
            EndContext();
            BeginContext(1044, 42, false);
#line 33 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                           Write(pedido.DataRegistro.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1086, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1126, 31, false);
#line 34 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                           Write(pedido.ValorTotal.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(1157, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1197, 21, false);
#line 35 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                           Write(pedido.FormaPagamento);

#line default
#line hidden
            EndContext();
            BeginContext(1218, 41, true);
            WriteLiteral("</td>\r\n                            <td>\r\n");
            EndContext();
#line 37 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                 if (pedido.Situacao == LojaVirtual.Models.Contants.PedidoSituacaoConstant.PEDIDO_REALIZADO)
                                {

#line default
#line hidden
            BeginContext(1420, 73, true);
            WriteLiteral("                                    <span class=\"label pedido-realizado\">");
            EndContext();
            BeginContext(1494, 15, false);
#line 39 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                                                    Write(pedido.Situacao);

#line default
#line hidden
            EndContext();
            BeginContext(1509, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 40 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(1553, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 41 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                 if (pedido.Situacao == LojaVirtual.Models.Contants.PedidoSituacaoConstant.PAGAMENTO_APROVADO)
                                {

#line default
#line hidden
            BeginContext(1716, 75, true);
            WriteLiteral("                                    <span class=\"label pagamento-aprovado\">");
            EndContext();
            BeginContext(1792, 15, false);
#line 43 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                                                      Write(pedido.Situacao);

#line default
#line hidden
            EndContext();
            BeginContext(1807, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 44 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(1851, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 45 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                 if (pedido.Situacao == LojaVirtual.Models.Contants.PedidoSituacaoConstant.NF_EMITIDA)
                                {

#line default
#line hidden
            BeginContext(2006, 67, true);
            WriteLiteral("                                    <span class=\"label nf-emitida\">");
            EndContext();
            BeginContext(2074, 15, false);
#line 47 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                                              Write(pedido.Situacao);

#line default
#line hidden
            EndContext();
            BeginContext(2089, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 48 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(2133, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 49 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                 if (pedido.Situacao == LojaVirtual.Models.Contants.PedidoSituacaoConstant.EM_TRANSPORTE)
                                {

#line default
#line hidden
            BeginContext(2291, 70, true);
            WriteLiteral("                                    <span class=\"label em-transporte\">");
            EndContext();
            BeginContext(2362, 15, false);
#line 51 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                                                 Write(pedido.Situacao);

#line default
#line hidden
            EndContext();
            BeginContext(2377, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 52 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(2421, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 53 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                 if (pedido.Situacao == LojaVirtual.Models.Contants.PedidoSituacaoConstant.ENTREGUE)
                                {

#line default
#line hidden
            BeginContext(2574, 65, true);
            WriteLiteral("                                    <span class=\"label entregue\">");
            EndContext();
            BeginContext(2640, 15, false);
#line 55 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                                            Write(pedido.Situacao);

#line default
#line hidden
            EndContext();
            BeginContext(2655, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 56 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(2699, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 57 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                 if (pedido.Situacao == LojaVirtual.Models.Contants.PedidoSituacaoConstant.FINALIZADO)
                                {

#line default
#line hidden
            BeginContext(2854, 67, true);
            WriteLiteral("                                    <span class=\"label finalizado\">");
            EndContext();
            BeginContext(2922, 15, false);
#line 59 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                                              Write(pedido.Situacao);

#line default
#line hidden
            EndContext();
            BeginContext(2937, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 60 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(2981, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 61 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                 if (pedido.Situacao == LojaVirtual.Models.Contants.PedidoSituacaoConstant.DEVOLVER)
                                {

#line default
#line hidden
            BeginContext(3134, 65, true);
            WriteLiteral("                                    <span class=\"label devolver\">");
            EndContext();
            BeginContext(3200, 15, false);
#line 63 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                                            Write(pedido.Situacao);

#line default
#line hidden
            EndContext();
            BeginContext(3215, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 64 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(3259, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 65 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                 if (pedido.Situacao == LojaVirtual.Models.Contants.PedidoSituacaoConstant.DEVOLVER_ENTREGUE)
                                {

#line default
#line hidden
            BeginContext(3421, 74, true);
            WriteLiteral("                                    <span class=\"label devolver-entregue\">");
            EndContext();
            BeginContext(3496, 15, false);
#line 67 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                                                     Write(pedido.Situacao);

#line default
#line hidden
            EndContext();
            BeginContext(3511, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 68 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(3555, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 69 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                 if (pedido.Situacao == LojaVirtual.Models.Contants.PedidoSituacaoConstant.DEVOLUCAO_ACEITA)
                                {

#line default
#line hidden
            BeginContext(3716, 73, true);
            WriteLiteral("                                    <span class=\"label devolucao-aceita\">");
            EndContext();
            BeginContext(3790, 15, false);
#line 71 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                                                    Write(pedido.Situacao);

#line default
#line hidden
            EndContext();
            BeginContext(3805, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 72 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(3849, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 73 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                 if (pedido.Situacao == LojaVirtual.Models.Contants.PedidoSituacaoConstant.DEVOLUCAO_REJEITADA)
                                {

#line default
#line hidden
            BeginContext(4013, 76, true);
            WriteLiteral("                                    <span class=\"label devolucao-rejeitada\">");
            EndContext();
            BeginContext(4090, 15, false);
#line 75 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                                                       Write(pedido.Situacao);

#line default
#line hidden
            EndContext();
            BeginContext(4105, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 76 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(4149, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 77 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                 if (pedido.Situacao == LojaVirtual.Models.Contants.PedidoSituacaoConstant.DEVOLVER_ESTORNO)
                                {

#line default
#line hidden
            BeginContext(4310, 64, true);
            WriteLiteral("                                    <span class=\"label estorno\">");
            EndContext();
            BeginContext(4375, 15, false);
#line 79 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                                           Write(pedido.Situacao);

#line default
#line hidden
            EndContext();
            BeginContext(4390, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 80 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(4434, 67, true);
            WriteLiteral("                            </td>\r\n                            <td>");
            EndContext();
            BeginContext(4502, 92, false);
#line 82 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                           Write(Html.Raw(pedido.NFE == null ? "-" : "<a href='" + pedido.NFE + "' target='_blank'>NF-e</a>"));

#line default
#line hidden
            EndContext();
            BeginContext(4594, 73, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4667, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40bc31b3ca8b55619398039345d25d7b8875395223159", async() => {
                BeginContext(4741, 10, true);
                WriteLiteral("Visualizar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 84 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
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
            BeginContext(4755, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 87 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(4846, 66, true);
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n");
            EndContext();
#line 92 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(4919, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(4924, 94, false);
#line 93 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, pagina => Url.Action("Index", new { pagina = pagina })));

#line default
#line hidden
            EndContext();
            BeginContext(5018, 10, true);
            WriteLiteral("\r\n\r\n</div>");
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
