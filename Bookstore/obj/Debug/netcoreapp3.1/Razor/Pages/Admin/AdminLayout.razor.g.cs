#pragma checksum "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\AdminLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fa5ff18b85bac1b7ee5c5ec78460438028861d1"
// <auto-generated/>
#pragma warning disable 1591
namespace Bookstore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\_Imports.razor"
using Bookstore.Models;

#line default
#line hidden
#nullable disable
    public partial class AdminLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<nav aria-label=\"breadcrumb\">\r\n    <ol class=\"breadcrumb\">\r\n        <li class=\"breadcrumb-item\"><a href=\"/home\">Home</a></li>\r\n        <li class=\"breadcrumb-item active\" aria-current=\"page\">Admin</li>\r\n    </ol>\r\n</nav>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"bg-info text-white p-2\">\r\n    <span class=\"navbar-brand m-lg-2\">Bookstore Administration</span>\r\n</div>\r\n\r\n<br>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container-fluid");
            __builder.AddMarkupContent(4, "\r\n\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row p-2");
            __builder.AddMarkupContent(7, "\r\n\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-2");
            __builder.AddMarkupContent(10, "\r\n\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "d-grid gap-2");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(14);
            __builder.AddAttribute(15, "class", "btn btn-outline-primary");
            __builder.AddAttribute(16, "href", "/admin/booklist");
            __builder.AddAttribute(17, "ActiveClass", "btn-primary text-white");
            __builder.AddAttribute(18, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 24 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\AdminLayout.razor"
                                                                     NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(20, "Books");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(22);
            __builder.AddAttribute(23, "class", "btn btn-outline-primary");
            __builder.AddAttribute(24, "href", "/admin/purchases");
            __builder.AddAttribute(25, "ActiveClass", "btn-primary text-white");
            __builder.AddAttribute(26, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 27 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\AdminLayout.razor"
                                                                     NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(28, "Orders");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n        ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col");
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.AddContent(35, 
#nullable restore
#line 33 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\AdminLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
