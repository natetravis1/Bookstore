#pragma checksum "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\ShoppingCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5aee4eae3b8e3e5030112baf4578499902f193ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_ShoppingCart), @"mvc.1.0.razor-page", @"/Pages/ShoppingCart.cshtml")]
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
#line 2 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\_ViewImports.cshtml"
using Bookstore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5aee4eae3b8e3e5030112baf4578499902f193ad", @"/Pages/ShoppingCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ae9a0d045e80a128732142566327aa897fbc3d4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ShoppingCart : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>Your cart</h1>

<br />

<table class=""table table-bordered table-striped"">

    <thead>
        <tr>
            <th>Item</th>
            <th>Quantity</th>
            <th>Cost</th>
            <th>Subtotal</th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 22 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\ShoppingCart.cshtml"
        foreach(var i in Model.basket.Items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\ShoppingCart.cshtml"
               Write(i.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\ShoppingCart.cshtml"
               Write(i.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\ShoppingCart.cshtml"
               Write(i.Book.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\ShoppingCart.cshtml"
                Write((i.Quantity * i.Book.Price).ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td class=\"text-center\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5aee4eae3b8e3e5030112baf4578499902f193ad5285", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"bookId\"");
                BeginWriteAttribute("value", " value=\"", 779, "\"", 801, 1);
#nullable restore
#line 32 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\ShoppingCart.cshtml"
WriteAttributeValue("", 787, i.Book.BookId, 787, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", " value=\"", 868, "\"", 892, 1);
#nullable restore
#line 33 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\ShoppingCart.cshtml"
WriteAttributeValue("", 876, Model.ReturnUrl, 876, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <button type=\"submit\" class=\"btn btn-sm btn-danger\">Remove</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\ShoppingCart.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"3\">Total:</td>\r\n            <td>");
#nullable restore
#line 44 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\ShoppingCart.cshtml"
           Write(Model.basket.CalculateTotal().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tfoot>\r\n\r\n</table>\r\n\r\n<div>\r\n    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1304, "\"", 1327, 1);
#nullable restore
#line 51 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\ShoppingCart.cshtml"
WriteAttributeValue("", 1311, Model.ReturnUrl, 1311, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Continue Shopping</a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bookstore.Pages.ShoppingCartModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Bookstore.Pages.ShoppingCartModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Bookstore.Pages.ShoppingCartModel>)PageContext?.ViewData;
        public Bookstore.Pages.ShoppingCartModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
