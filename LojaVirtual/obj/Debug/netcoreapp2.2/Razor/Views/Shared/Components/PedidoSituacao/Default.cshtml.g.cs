#pragma checksum "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Views\Shared\Components\PedidoSituacao\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2a06b39669306757026d42b9273dba00d8cf677"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PedidoSituacao_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PedidoSituacao/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/PedidoSituacao/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_PedidoSituacao_Default))]
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
#line 3 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#line 4 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 5 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 6 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModel;

#line default
#line hidden
#line 7 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModel.Components;

#line default
#line hidden
#line 8 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#line 9 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.Contants;

#line default
#line hidden
#line 10 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Texto;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2a06b39669306757026d42b9273dba00d8cf677", @"/Views/Shared/Components/PedidoSituacao/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db6c50a82ad95964959a9b5b95e8774fb6936668", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_PedidoSituacao_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PedidoSituacaoStatus>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Views\Shared\Components\PedidoSituacao\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
            BeginContext(78, 43, true);
            WriteLiteral("\r\n\r\n\r\n<ul class=\"timeline\" id=\"timeline\">\r\n");
            EndContext();
#line 9 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Views\Shared\Components\PedidoSituacao\Default.cshtml"
     foreach(var pedidoStatus in Model) {

#line default
#line hidden
            BeginContext(164, 7, true);
            WriteLiteral("    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 171, "\"", 226, 2);
            WriteAttributeValue("", 179, "li", 179, 2, true);
#line 10 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Views\Shared\Components\PedidoSituacao\Default.cshtml"
WriteAttributeValue(" ", 181, (pedidoStatus.Concluido)? "complete" : "", 182, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(227, 68, true);
            WriteLiteral(">\r\n        <div class=\"timestamp\">\r\n            <span class=\"date\"> ");
            EndContext();
            BeginContext(297, 65, false);
#line 12 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Views\Shared\Components\PedidoSituacao\Default.cshtml"
                            Write((pedidoStatus.Data != null) ? pedidoStatus.Data.ToString() : "-" );

#line default
#line hidden
            EndContext();
            BeginContext(363, 72, true);
            WriteLiteral(" <span>\r\n        </div>\r\n        <div class=\"status\">\r\n            <h4> ");
            EndContext();
            BeginContext(436, 21, false);
#line 15 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Views\Shared\Components\PedidoSituacao\Default.cshtml"
            Write(pedidoStatus.Situacao);

#line default
#line hidden
            EndContext();
            BeginContext(457, 35, true);
            WriteLiteral(" </h4>\r\n        </div>\r\n    </li>\r\n");
            EndContext();
#line 18 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Views\Shared\Components\PedidoSituacao\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(499, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PedidoSituacaoStatus>> Html { get; private set; }
    }
}
#pragma warning restore 1591
