#pragma checksum "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\Home\OrderList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e33e5091c8256b905690b14cc16722c56707166b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(G151210078.Home.Views_Home_OrderList), @"mvc.1.0.view", @"/Views/Home/OrderList.cshtml")]
namespace G151210078.Home
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
#line 1 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\_ViewImports.cshtml"
using G151210078;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\_ViewImports.cshtml"
using G151210078.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.TagHelpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e33e5091c8256b905690b14cc16722c56707166b", @"/Views/Home/OrderList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49c0fa8ea642c6ee8e0b1112e55ad5e2999b6622", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OrderList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("140px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\Home\OrderList.cshtml"
  
    ViewData["Title"] = "OrderListAsync";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>OrderListAsync</h1>

<div class=""container pt-100 mb-5"">

    <h1 class=""mb-2"">Alışveriş Sepetiniz</h1>
    <div class=""row"">
        <div class=""col-12"">
            
            <div class=""accordion"" id=""accordionExample"">
                <div class=""card"">
");
#nullable restore
#line 16 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\Home\OrderList.cshtml"
                     foreach (var orderId in ViewBag.Product)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\Home\OrderList.cshtml"
                         foreach (var item in orderId.Value)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""card-header"" id=""headingOne"">
                                <h2 class=""mb-0"">
                                    <button class=""btn btn-link btn-block text-left"" type=""button"" data-toggle=""collapse"" data-target=""");
#nullable restore
#line 22 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\Home\OrderList.cshtml"
                                                                                                                                   Write("#"+orderId.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" aria-expanded=""true"" aria-controls=""collapseOne"">
                                        <ul class=""list-group list-group-horizontal-md"">
                                            <li class=""list-group-item"">
                                                ");
#nullable restore
#line 25 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\Home\OrderList.cshtml"
                                           Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </li>\r\n                                            <li class=\"list-group-item\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e33e5091c8256b905690b14cc16722c56707166b6795", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\Home\OrderList.cshtml"
                                               WriteLiteral("~/images/"+item.ImageName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 28 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\Home\OrderList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </li>\r\n                                        </ul>\r\n                                    </button>\r\n                                </h2>\r\n                            </div>\r\n");
#nullable restore
#line 34 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\Home\OrderList.cshtml"
                            break;
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\Home\OrderList.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\Home\OrderList.cshtml"
                     foreach (var orderId in ViewBag.Product)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\Home\OrderList.cshtml"
                         foreach (var item in orderId.Value)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div");
            BeginWriteAttribute("id", " id=\"", 1840, "\"", 1857, 1);
#nullable restore
#line 41 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\Home\OrderList.cshtml"
WriteAttributeValue("", 1845, orderId.Key, 1845, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""collapse show"" aria-labelledby=""headingOne"" data-parent=""#accordionExample"">
                                <div class=""card-body"">
                                    <ul class=""list-group list-group-horizontal-md"">
                                        <li class=""list-group-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e33e5091c8256b905690b14cc16722c56707166b11093", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\Home\OrderList.cshtml"
                                                                   WriteLiteral("~/images/"+item.ImageName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 44 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\Home\OrderList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                                        <li class=\"list-group-item\">");
#nullable restore
#line 45 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\Home\OrderList.cshtml"
                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        <li class=\"list-group-item\">");
#nullable restore
#line 46 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\Home\OrderList.cshtml"
                                                               Write(item.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        <li class=\"list-group-item\">");
#nullable restore
#line 47 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\Home\OrderList.cshtml"
                                                               Write(item.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        <li class=\"list-group-item\">");
#nullable restore
#line 48 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\Home\OrderList.cshtml"
                                                               Write(item.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        <li class=\"list-group-item\">");
#nullable restore
#line 49 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\Home\OrderList.cshtml"
                                                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                    </ul>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 53 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\Home\OrderList.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\Home\OrderList.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n\r\n\r\n");
#nullable restore
#line 59 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\Home\OrderList.cshtml"
             if (ViewBag.Product == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""alert alert-warning mt-3"">
                    Sepetinizde ürün yok <br>
                    <button routerLink=""/shop"" class=""btn btn-link p-0"">
                        Alışverişe devam etmek için tıklayınız.
                    </button>
                </div>
");
#nullable restore
#line 67 "C:\Users\Que\Desktop\G151210078-7633ac5e7e621644eac6cc554f5e6975532edbe1\Views\Home\OrderList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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