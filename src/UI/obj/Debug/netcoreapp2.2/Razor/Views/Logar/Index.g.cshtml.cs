#pragma checksum "C:\Desenvolvimento\D4\src\UI\Views\Logar\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fb175bd334eedd092e920da9e80366980448cd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Logar_Index), @"mvc.1.0.view", @"/Views/Logar/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Logar/Index.cshtml", typeof(AspNetCore.Views_Logar_Index))]
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
#line 1 "C:\Desenvolvimento\D4\src\UI\Views\_ViewImports.cshtml"
using UI;

#line default
#line hidden
#line 2 "C:\Desenvolvimento\D4\src\UI\Views\_ViewImports.cshtml"
using UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fb175bd334eedd092e920da9e80366980448cd4", @"/Views/Logar/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31c2cec923fd8a031576e1a0969537a939702c0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Logar_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UI.Controllers.LogarController>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Desenvolvimento\D4\src\UI\Views\Logar\Index.cshtml"
  
    ViewData["Title"] = "Logar";

#line default
#line hidden
            BeginContext(84, 341, true);
            WriteLiteral(@"
<div class=""modal-header light-blue darken-3 white-text"">
    <h4 class=""title""><i class=""fas fa-user""></i> Logar</h4>
    <button type=""button"" class=""close waves-effect waves-light"" data-dismiss=""modal"" aria-label=""Close"">
        <span aria-hidden=""true"">×</span>
    </button>
</div>
<br />
<br />
<div class=""container"">
    ");
            EndContext();
            BeginContext(425, 510, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fb175bd334eedd092e920da9e80366980448cd44198", async() => {
                BeginContext(443, 485, true);
                WriteLiteral(@"
        <div class=""form-group"">
            <input type=""text"" class=""form-control"" id=""CodigoUsuario"" name=""CodigoUsuario"" placeholder=""Código Usuário"">
        </div>
        <div class=""form-group"">
            <input type=""password"" class=""form-control"" id=""Senha"" name=""Senha"" placeholder=""Password"">
        </div>
        <div class=""form-group"">
            <button type=""button"" class=""btn btn-outline-primary"" onclick=""Logar();"">Logar</button>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(935, 1200, true);
            WriteLiteral(@"
</div>


<div id=""myModal"" class=""modal fade"" role=""dialog"">
    <div class=""modal-dialog"">
        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Login</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div id=""content""></div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Fechar</button>
            </div>
        </div>

    </div>
</div>

<script>
    function Logar() {
        var CodigoUsuario = $('#CodigoUsuario').val();
        var Senha = $('#Senha').val();
        var json = { ""CodigoUsuario"": CodigoUsuario, ""Senha"": Senha };

        if (CodigoUsuario == """" || Senha == """") {
        ");
            WriteLiteral("    console.log(\"Digite os campos...\");\r\n            return false;\r\n        }\r\n        var x = location.host;\r\n\r\n        $.ajax({\r\n            type: \"POST\",\r\n            url: \'");
            EndContext();
            BeginContext(2136, 28, false);
#line 66 "C:\Desenvolvimento\D4\src\UI\Views\Logar\Index.cshtml"
             Write(Url.Action("logar", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(2164, 2726, true);
            WriteLiteral(@"',
            data: JSON.stringify(json),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            cache: false,

            beforeSend: function (xhr) {
                xhr.setRequestHeader(""Accept"", ""application/json"");
                xhr.setRequestHeader(""Content-Type"", ""application/json"");
            },
            success: function (data) {
                //jwtRequest('https://' + x + '/api/usuario/getall');
                //console.log(data);

               //setTimeout(""document.location = 'https://' + x + '/api/pedido/'"", 5000);

                $('#content').html("""");
                let body = '';
                body = 'Favor efetuar o seu Login.';
                $(""#content"").append('Acesso autorizado.');
                $(""#myModal"").modal();
                $(""#myModal"").modal({ keyboard: false });
                $(""#myModal"").modal('show');
                return false;

            },
            error: function (x");
            WriteLiteral(@"hr, ajaxOptions, thrownError) {
           
                $('#content').html("""");
                let body = '';
                body = 'Favor efetuar o seu Login.';
                $(""#content"").append('Credenciais Inválidas.');
                $(""#myModal"").modal();
                $(""#myModal"").modal({ keyboard: false });
                $(""#myModal"").modal('show');
                return false;
            }
        });
    }

    function jwtRequest(url) {
        var _token = getCookie('D4Cookie')
        var settings = {
            ""async"": true,
            ""crossDomain"": true,
            ""url"": url,
            ""method"": ""GET"",
            ""headers"": {
                ""authorization"": ""bearer "" + _token,
                ""cache-control"": ""no-cache""
            },
            ""data"": "" {\n        \""id\"": 2,\n        \""nome\"": \""\"",\n        \""email\"": \""\"",\n         \""cnpjCpf\"": \""\"",\n         \""senha\"": \""\"",\n        \""dataCadastro\"": \""\"",\n        \""dataUltimoLog\"": \");
            WriteLiteral(@"""\"",\n        \""ativo\"":\n    }""
        }
        $.ajax(settings).done(function (response) {
            console.log(response);
        });
    }

    function getCookie(c_name) {
        if (document.cookie.length > 0) {
            c_start = document.cookie.indexOf(c_name + ""="");
            if (c_start != -1) {
                c_start = c_start + c_name.length + 1;
                c_end = document.cookie.indexOf("";"", c_start);
                if (c_end == -1) {
                    c_end = document.cookie.length;
                }
                return unescape(document.cookie.substring(c_start, c_end));
            }
        }
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UI.Controllers.LogarController> Html { get; private set; }
    }
}
#pragma warning restore 1591
