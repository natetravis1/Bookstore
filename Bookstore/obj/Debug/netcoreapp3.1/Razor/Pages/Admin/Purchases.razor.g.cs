#pragma checksum "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\Purchases.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dbf8f7616b7be771ec4eed88edf685e3974e74f"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/purchases")]
    public partial class Purchases : OwningComponentBase<IPurchaseRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Bookstore.Pages.Admin.PurchaseTable>(0);
            __builder.AddAttribute(1, "TableTitle", "Unshipped Orders");
            __builder.AddAttribute(2, "Purchases", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Bookstore.Models.Purchase>>(
#nullable restore
#line 4 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\Purchases.razor"
                                                        UnshippedOrders

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ButtonLabel", "Order Shipped");
            __builder.AddAttribute(4, "PurchaseSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 5 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\Purchases.razor"
                                                             CollectPurchase

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<Bookstore.Pages.Admin.PurchaseTable>(6);
            __builder.AddAttribute(7, "TableTitle", "Shipped Orders");
            __builder.AddAttribute(8, "Purchases", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Bookstore.Models.Purchase>>(
#nullable restore
#line 7 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\Purchases.razor"
                                                      ShippedOrders

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ButtonLabel", "Reset");
            __builder.AddAttribute(10, "PurchaseSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 8 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\Purchases.razor"
                                                     ResetPurchase

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "btn btn-info");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\Purchases.razor"
                                         x => UpdateData()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Refresh Data");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\natet\source\repos\Bookstore\Bookstore\Pages\Admin\Purchases.razor"
       

    public IPurchaseRepository repo => Service;

    public IEnumerable<Purchase> AllOrders { get; set; }
    public IEnumerable<Purchase> UnshippedOrders { get; set; }
    public IEnumerable<Purchase> ShippedOrders { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        AllOrders = await repo.Purchases.ToListAsync();
        UnshippedOrders = AllOrders.Where(x => !x.OrderShipped);
        ShippedOrders = AllOrders.Where(x => x.OrderShipped);
    }

    public void CollectPurchase(int id) => UpdatePurchase(id, true);
    public void ResetPurchase(int id) => UpdatePurchase(id, false);

    public void UpdatePurchase(int id, bool shipped)
    {
        Purchase p = repo.Purchases.FirstOrDefault(x => x.PurchaseId == id);
        p.OrderShipped = shipped;
        repo.SavePurchase(p);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
