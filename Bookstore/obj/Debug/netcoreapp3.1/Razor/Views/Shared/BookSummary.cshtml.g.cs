#pragma checksum "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\Shared\BookSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfb3949bb005d3c645a0200d1efea11ee781483c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_BookSummary), @"mvc.1.0.view", @"/Views/Shared/BookSummary.cshtml")]
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
#line 4 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\_ViewImports.cshtml"
using Bookstore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\_ViewImports.cshtml"
using Bookstore.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\_ViewImports.cshtml"
using Bookstore.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfb3949bb005d3c645a0200d1efea11ee781483c", @"/Views/Shared/BookSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"478862f3b70e9db4874ac7cbf823bd556d0dd791", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_BookSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Books>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div class=\"card card-outline-primary m-2 p-1\" data-bs-toggle=\"tooltip\" data-bs-placement=\"right\"");
            BeginWriteAttribute("title", " title=\"", 124, "\"", 168, 6);
            WriteAttributeValue("", 132, "Price", 132, 5, true);
            WriteAttributeValue(" ", 137, "of", 138, 3, true);
#nullable restore
#line 7 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\Shared\BookSummary.cshtml"
WriteAttributeValue(" ", 140, Model.Title, 141, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 153, ":", 153, 1, true);
            WriteAttributeValue(" ", 154, "$", 155, 2, true);
#nullable restore
#line 7 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\Shared\BookSummary.cshtml"
WriteAttributeValue("", 156, Model.Price, 156, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"bg-light p-1\">\r\n        <h5>");
#nullable restore
#line 9 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\Shared\BookSummary.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n        <span class=\"badge bg-info\" style=\"float:right\">\r\n            $");
#nullable restore
#line 12 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\Shared\BookSummary.cshtml"
        Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </span>\r\n    </div>\r\n\r\n    <ul class=\"list-inline\">\r\n        <li>Author: ");
#nullable restore
#line 17 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\Shared\BookSummary.cshtml"
               Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Category: ");
#nullable restore
#line 18 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\Shared\BookSummary.cshtml"
                 Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Publisher: ");
#nullable restore
#line 19 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\Shared\BookSummary.cshtml"
                  Write(Model.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>ISBN: ");
#nullable restore
#line 20 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\Shared\BookSummary.cshtml"
             Write(Model.Isbn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Classification: ");
#nullable restore
#line 21 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\Shared\BookSummary.cshtml"
                       Write(Model.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Pages: ");
#nullable restore
#line 22 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\Shared\BookSummary.cshtml"
              Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ul>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfb3949bb005d3c645a0200d1efea11ee781483c7699", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dfb3949bb005d3c645a0200d1efea11ee781483c7965", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 26 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\Shared\BookSummary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.BookId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", " value=\"", 813, "\"", 868, 1);
#nullable restore
#line 27 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\Shared\BookSummary.cshtml"
WriteAttributeValue("", 821, ViewContext.HttpContext.Request.PathAndQuery(), 821, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n        <span class=\"card-text\">\r\n            <button type=\"submit\" class=\"btn btn-success btn-sm float-end\">Add to cart</button>\r\n        </span>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Books> Html { get; private set; }
    }
}
#pragma warning restore 1591
