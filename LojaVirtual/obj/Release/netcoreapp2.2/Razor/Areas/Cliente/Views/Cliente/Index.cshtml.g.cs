#pragma checksum "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05885e184ea52721b49918980a9e5dc6f24f048a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cliente_Views_Cliente_Index), @"mvc.1.0.view", @"/Areas/Cliente/Views/Cliente/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Cliente/Views/Cliente/Index.cshtml", typeof(AspNetCore.Areas_Cliente_Views_Cliente_Index))]
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
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 5 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 6 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Models.Constants;

#line default
#line hidden
#line 7 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05885e184ea52721b49918980a9e5dc6f24f048a", @"/Areas/Cliente/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ff17eb3fda0722456c40feec5aba28156a62f06", @"/Areas/Cliente/Views/_ViewImports.cshtml")]
    public class Areas_Cliente_Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Atualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\ander\Desktop\Git\LojaVirtual\Novo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Cliente\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 482, true);
            WriteLiteral(@"<br />
<br />

<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"" style=""width: 18rem;"">
                <div class=""card-body"">
                    <h5 class=""card-title""><i class=""fas fa-user-alt""></i></h5>
                    <h6 class=""card-subtitle mb-2 text-muted"">Dados pessoais</h6>
                    <p class=""card-text"">Altere seu endereço de e-mail e seu endereço residencial.</p>
                    ");
            EndContext();
            BeginContext(525, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05885e184ea52721b49918980a9e5dc6f24f048a5369", async() => {
                BeginContext(569, 7, true);
                WriteLiteral("Alterar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
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
            BeginContext(580, 1175, true);
            WriteLiteral(@"
                </div>

            </div>
        </div>
        <div class=""col-md-12"">
            <div class=""card"" style=""width: 18rem;"">
                <div class=""card-body"">
                    <h5 class=""card-title""><i class=""fas fa-shipping-fast""></i></h5>
                    <h6 class=""card-subtitle mb-2 text-muted"">Endereço de entrega</h6>
                    <p class=""card-text"">Cadastre, altere ou remova os locais de entrega.</p>
                    <a href=""#"" class=""card-link"">Alterar</a>
                    <a href=""#"" class=""card-link"">Another link</a>
                </div>

            </div>
        </div>
        <div class=""col-md-12"">
            <div class=""card"" style=""width: 18rem;"">
                <div class=""card-body"">
                    <h5 class=""card-title""><i class=""fas fa-unlock-alt""></i></h5>
                    <h6 class=""card-subtitle mb-2 text-muted"">Senha</h6>
                    <p class=""card-text"">Altere sua senha de acesso</p>
            ");
            WriteLiteral("        <a href=\"#\" class=\"card-link\">Alterar</a>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<h1>Index</h1>\r\n\r\n");
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
