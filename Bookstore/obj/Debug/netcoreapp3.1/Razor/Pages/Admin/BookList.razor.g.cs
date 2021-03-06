#pragma checksum "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\BookList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c0d5e17ee5272d7bfae7727abaf34c1e6dbd9a4"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/booklist")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class BookList : OwningComponentBase<IBookstoreRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<thead>\r\n        <tr>\r\n            <th>Book ID</th>\r\n            <th>Book Title</th>\r\n            <th>Author</th>\r\n            <th>ISBN</th>\r\n        </tr>\r\n    </thead>\r\n\r\n    ");
            __builder.OpenElement(4, "tbody");
            __builder.AddMarkupContent(5, "\r\n        \r\n");
#nullable restore
#line 18 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\BookList.razor"
         if (BookData?.Count() > 0)
        {
            // list the books
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\BookList.razor"
             foreach (Books b in BookData)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "                ");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "\r\n                    ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 24 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\BookList.razor"
                         b.BookId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 25 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\BookList.razor"
                         b.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 26 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\BookList.razor"
                         b.Author

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 27 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\BookList.razor"
                         b.Isbn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(24);
            __builder.AddAttribute(25, "class", "btn btn-info btn-sm");
            __builder.AddAttribute(26, "href", 
#nullable restore
#line 30 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\BookList.razor"
                                                                    GetDetailsUrl(b.BookId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(28, "Details");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n                    ");
            __builder.OpenElement(31, "td");
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(33);
            __builder.AddAttribute(34, "class", "btn btn-warning btn-sm");
            __builder.AddAttribute(35, "href", 
#nullable restore
#line 34 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\BookList.razor"
                                                                       GetEditUrl(b.BookId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(37, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n                    ");
            __builder.OpenElement(40, "td");
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\BookList.razor"
                                                                          x => RemoveBook(b)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 41 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\BookList.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\BookList.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "            ");
            __builder.AddMarkupContent(50, "<tr>\r\n                <td colspan=\"5\" class=\"text-center\">No Books</td>\r\n            </tr>\r\n");
#nullable restore
#line 48 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\BookList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(54);
            __builder.AddAttribute(55, "class", "btn btn-primary");
            __builder.AddAttribute(56, "href", "/admin/booklist/create");
            __builder.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(58, "Add New Book");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\BookList.razor"
       

    public IBookstoreRepository repo => Service;

    public IEnumerable<Books> BookData { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        BookData = await repo.Books.ToListAsync();
    }

    public string GetDetailsUrl(long id) => $"/admin/booklist/details/{id}";
    public string GetEditUrl(long id) => $"/admin/booklist/edit/{id}";

    public async Task RemoveBook (Books b)
    {
        repo.DeleteBook(b);
        await UpdateData();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
