#pragma checksum "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60551ed138f74d0381f4a002eb71d308f35f0474"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Products__products), @"mvc.1.0.view", @"/Views/Shared/Components/Products/_products.cshtml")]
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
#line 1 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml"
using Be;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60551ed138f74d0381f4a002eb71d308f35f0474", @"/Views/Shared/Components/Products/_products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2439745b4c393cfe34bccc674d07af14dd486aa1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Products__products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card-body\" id=\"crd\">\r\n\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml"
      
        BlL.productsBll bl = new BlL.productsBll();

        var prod = bl.Read();
        foreach (Products.Product i in prod)
        {

        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\" style=\" height: auto; width: 27%;\">\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60551ed138f74d0381f4a002eb71d308f35f04744832", async() => {
                WriteLiteral("\r\n                    <input type=\"text\" name=\"id\" class=\"mid\"");
                BeginWriteAttribute("value", " value=\"", 363, "\"", 376, 1);
#nullable restore
#line 17 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml"
WriteAttributeValue("", 371, i.Id, 371, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden>\r\n                    <input type=\"text\" name=\"nameProduct\" class=\"mnameProduct\"");
                BeginWriteAttribute("value", " value=\"", 465, "\"", 487, 1);
#nullable restore
#line 18 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml"
WriteAttributeValue("", 473, i.nameProduct, 473, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden>\r\n                    <input type=\"text\" name=\"price\" class=\"mprice\"");
                BeginWriteAttribute("value", " value=\"", 564, "\"", 580, 1);
#nullable restore
#line 19 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml"
WriteAttributeValue("", 572, i.price, 572, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden>\r\n                    <input type=\"text\" name=\"description\" class=\"mdescription\"");
                BeginWriteAttribute("value", " value=\"", 669, "\"", 691, 1);
#nullable restore
#line 20 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml"
WriteAttributeValue("", 677, i.description, 677, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden>\r\n                    <input type=\"text\" name=\"camra\" class=\"mcamra\"");
                BeginWriteAttribute("value", " value=\"", 768, "\"", 784, 1);
#nullable restore
#line 21 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml"
WriteAttributeValue("", 776, i.camra, 776, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden>\r\n                    <input type=\"text\" name=\"dimensions\" class=\"mdimensions\"");
                BeginWriteAttribute("value", " value=\"", 871, "\"", 892, 1);
#nullable restore
#line 22 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml"
WriteAttributeValue("", 879, i.dimensions, 879, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden>\r\n                    <input type=\"text\" name=\"weight\" class=\"mweight\"");
                BeginWriteAttribute("value", " value=\"", 971, "\"", 988, 1);
#nullable restore
#line 23 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml"
WriteAttributeValue("", 979, i.weight, 979, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden>\r\n                    <input type=\"text\" name=\"screen\" class=\"mscreen\"");
                BeginWriteAttribute("value", " value=\"", 1067, "\"", 1084, 1);
#nullable restore
#line 24 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml"
WriteAttributeValue("", 1075, i.screen, 1075, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden>\r\n                    <input type=\"text\" name=\"screenSize\" class=\"mscreenSize\"");
                BeginWriteAttribute("value", " value=\"", 1171, "\"", 1192, 1);
#nullable restore
#line 25 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml"
WriteAttributeValue("", 1179, i.screenSize, 1179, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden>\r\n                    <input type=\"text\" name=\"bodyStructure\" class=\"mbodyStructure\"");
                BeginWriteAttribute("value", " value=\"", 1285, "\"", 1309, 1);
#nullable restore
#line 26 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml"
WriteAttributeValue("", 1293, i.bodyStructure, 1293, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden>\r\n                    <input type=\"text\" name=\"specialFeatures\" class=\"mspecialFeatures\"");
                BeginWriteAttribute("value", " value=\"", 1406, "\"", 1432, 1);
#nullable restore
#line 27 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml"
WriteAttributeValue("", 1414, i.specialFeatures, 1414, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden>\r\n                    <input type=\"text\" name=\"introductionTime\" class=\"mintroductionTime\"");
                BeginWriteAttribute("value", " value=\"", 1531, "\"", 1558, 1);
#nullable restore
#line 28 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml"
WriteAttributeValue("", 1539, i.introductionTime, 1539, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden>\r\n                    <input type=\"text\" name=\"productModel\" class=\"mproductModel\"");
                BeginWriteAttribute("value", " value=\"", 1649, "\"", 1672, 1);
#nullable restore
#line 29 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml"
WriteAttributeValue("", 1657, i.productModel, 1657, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden>\r\n                    <input type=\"text\" name=\"memoryCard\" class=\"mmemoryCard\"");
                BeginWriteAttribute("value", " value=\"", 1759, "\"", 1780, 1);
#nullable restore
#line 30 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml"
WriteAttributeValue("", 1767, i.memoryCard, 1767, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden>\r\n                    <input type=\"text\" name=\"numberProducts\" class=\"mnumberProducts\"");
                BeginWriteAttribute("value", " value=\"", 1875, "\"", 1900, 1);
#nullable restore
#line 31 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml"
WriteAttributeValue("", 1883, i.numberProducts, 1883, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden>\r\n                    <input type=\"text\" name=\"batterySpecifications\" class=\"mbatterySpecifications\"");
                BeginWriteAttribute("value", " value=\"", 2009, "\"", 2041, 1);
#nullable restore
#line 32 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml"
WriteAttributeValue("", 2017, i.batterySpecifications, 2017, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden>\r\n                    <input type=\"text\" name=\"operatingSystem\" class=\"moperatingSystem\"");
                BeginWriteAttribute("value", " value=\"", 2138, "\"", 2164, 1);
#nullable restore
#line 33 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml"
WriteAttributeValue("", 2146, i.operatingSystem, 2146, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden>\r\n                    <input type=\"text\" name=\"category\" class=\"mcategory\"");
                BeginWriteAttribute("value", " value=\"", 2247, "\"", 2266, 1);
#nullable restore
#line 34 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml"
WriteAttributeValue("", 2255, i.category, 2255, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden>\r\n                    <input type=\"text\" name=\"titlecategory\" class=\"mtitlecategory\"");
                BeginWriteAttribute("value", " value=\"", 2359, "\"", 2383, 1);
#nullable restore
#line 35 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml"
WriteAttributeValue("", 2367, i.titleCategory, 2367, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden>\r\n\r\n\r\n                    <a class=\"btnmoadl\" style=\"margin-right: 89%; cursor: pointer\" data-toggle=\"modal\" data-target=\"#myModal\" id=\"searchsub\"><i class=\"material-icons\">&#xe241;</i></a>\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "60551ed138f74d0381f4a002eb71d308f35f047415417", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2636, "~/image/users/", 2636, 14, true);
#nullable restore
#line 43 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml"
AddHtmlAttributeValue("", 2650, i.pics, 2650, 7, false);

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
            WriteLiteral("\r\n            <h3>\r\n                ");
#nullable restore
#line 45 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml"
           Write(i.nameProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h3>\r\n            <h5 class=\"price\">");
#nullable restore
#line 47 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml"
                         Write(i.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p>");
#nullable restore
#line 48 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml"
          Write(i.specialFeatures);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p><button style=\" background-color: black; border-radius: 10px;\">افزودن به سبد خرید</button></p>\r\n        </div>\r\n");
#nullable restore
#line 51 "C:\Users\Key1\source\repos\DiGi\DiGi\Views\Shared\Components\Products\_products.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>");
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
