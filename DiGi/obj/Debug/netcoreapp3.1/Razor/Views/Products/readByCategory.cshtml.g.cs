#pragma checksum "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Products\readByCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6055d8e91e87fc8f81df7fb8739c939f1286bdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_readByCategory), @"mvc.1.0.view", @"/Views/Products/readByCategory.cshtml")]
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
#line 1 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\_ViewImports.cshtml"
using DiGi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\_ViewImports.cshtml"
using DiGi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Products\readByCategory.cshtml"
using Be;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6055d8e91e87fc8f81df7fb8739c939f1286bdb", @"/Views/Products/readByCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2439745b4c393cfe34bccc674d07af14dd486aa1", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_readByCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Denim Jeans"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" width: 56%; margin-right: 22%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Products\readByCategory.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container"">
    <div class=""row"">
        <nav class=""col-md-2"">
            <div id=""mySidenav"" class=""sidenav"" style="" border-radius: 40px;"">
                <div style="" margin-right: 4%;"">

                    <a href=""#"">About</a>
                    <a href=""#"">Services</a>
                    <a href=""#"">Clients</a>
                    <a href=""#"">Contact</a>
                </div>

            </div>
        </nav>
        <div class=""col-md-10"" style="" border-bottom: solid; display: flex; flex-wrap: wrap; justify-content: space-evenly; margin-top: 1%; border-top: solid; padding-top: 26px; border-radius: 40px; padding-bottom: 40px;"">
");
#nullable restore
#line 22 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Products\readByCategory.cshtml"
             foreach (Products.Product i in ViewBag.Products)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card\" style=\" height: auto; width: 27%;\">\r\n\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a6055d8e91e87fc8f81df7fb8739c939f1286bdb5254", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 932, "~/image/users/", 932, 14, true);
#nullable restore
#line 28 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Products\readByCategory.cshtml"
AddHtmlAttributeValue("", 946, i.pics, 946, 7, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <h3>\r\n                        ");
#nullable restore
#line 30 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Products\readByCategory.cshtml"
                   Write(i.nameProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h3>\r\n                    <h5 class=\"price\">");
#nullable restore
#line 32 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Products\readByCategory.cshtml"
                                 Write(i.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p>");
#nullable restore
#line 33 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Products\readByCategory.cshtml"
                  Write(i.specialFeatures);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><button style=\"  border-radius: 10px;\">افزودن به سبد خرید</button></p>\r\n                </div>\r\n");
#nullable restore
#line 36 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Products\readByCategory.cshtml"


            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
  
    <style>



        .sidenav {
            height: 100%;
            width: 250px;
            position: fixed;
            z-index: 1;
            top: 10px;
            left: auto;
            background-color: #343a40;
            overflow-x: hidden;
            transition: 0.5s;
            padding-top: 60px;
            margin-right: -6.1%;
            margin-top: 5.5%;
        }

            .sidenav a {
                padding: 8px 8px 8px 32px;
                text-decoration: none;
                font-size: 25px;
                color: #818181;
                display: block;
                transition: 0.3s;
            }

                .sidenav a:hover {
                    color: #f1f1f1;
                }

            .sidenav .closebtn {
                position: absolute;
                top: 0;
                right: 210px;
                font-size: 36px;
                margin-left: 50px;
            }
    </style>

    <script>

       ");
                WriteLiteral(" $(document).ready(function () {\r\n\r\n        });\r\n\r\n\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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
