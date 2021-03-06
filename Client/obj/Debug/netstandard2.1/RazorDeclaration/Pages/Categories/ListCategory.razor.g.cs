#pragma checksum "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Categories\ListCategory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3c8500d3b457e62515f7ec83d633a2c5679a839"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace crudBlazor.Client.Pages.Categories
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\_Imports.razor"
using crudBlazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\_Imports.razor"
using crudBlazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\_Imports.razor"
using crudBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Categories\ListCategory.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Category/ListCategory")]
    public partial class ListCategory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Categories\ListCategory.razor"
       

    private List<Category> categoryList = new List<Category>();

    protected override async Task OnInitializedAsync()
    {
        var categories = await Http.GetFromJsonAsync<List<Category>>("/Category/List");
        foreach (var item in categories)
        {
            categoryList.Add(item);
        }
    }

    private async Task DeleteCategory(int itemId)
    {
        //call controller
        await Http.DeleteAsync("/Category/Delete/"+itemId);
        NavigationManager.NavigateTo("Category/ListCategory", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
