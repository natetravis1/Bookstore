#pragma checksum "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ba8fa5c395a8fb4917772f06d087af19a443f2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 2 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\_ViewImports.cshtml"
using Bookstore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\_ViewImports.cshtml"
using Bookstore.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ba8fa5c395a8fb4917772f06d087af19a443f2e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5274b5d5f5ce692d8720bd88d9b1d1343d2366de", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BooksViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Bookstore.Infrastructure.PaginationTagHelper __Bookstore_Infrastructure_PaginationTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Book List</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\Home\Index.cshtml"
 foreach (Books b in Model.Books)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 10 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\Home\Index.cshtml"
   Write(b.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <ul>\r\n        <li>Author: ");
#nullable restore
#line 12 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\Home\Index.cshtml"
               Write(b.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Category: ");
#nullable restore
#line 13 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\Home\Index.cshtml"
                 Write(b.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Publisher: ");
#nullable restore
#line 14 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\Home\Index.cshtml"
                  Write(b.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>ISBN: ");
#nullable restore
#line 15 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\Home\Index.cshtml"
             Write(b.Isbn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Classification/Category: ");
#nullable restore
#line 16 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\Home\Index.cshtml"
                                Write(b.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Number of pages: ");
#nullable restore
#line 17 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\Home\Index.cshtml"
                        Write(b.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Price: $");
#nullable restore
#line 18 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\Home\Index.cshtml"
               Write(b.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ul>\r\n    <br />\r\n");
#nullable restore
#line 21 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ba8fa5c395a8fb4917772f06d087af19a443f2e5879", async() => {
            }
            );
            __Bookstore_Infrastructure_PaginationTagHelper = CreateTagHelper<global::Bookstore.Infrastructure.PaginationTagHelper>();
            __tagHelperExecutionContext.Add(__Bookstore_Infrastructure_PaginationTagHelper);
#nullable restore
#line 23 "C:\Users\natet\source\repos\Bookstore\Bookstore\Views\Home\Index.cshtml"
__Bookstore_Infrastructure_PaginationTagHelper.PageBlah = Model.PageInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-blah", __Bookstore_Infrastructure_PaginationTagHelper.PageBlah, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Bookstore_Infrastructure_PaginationTagHelper.PageAction = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BooksViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
