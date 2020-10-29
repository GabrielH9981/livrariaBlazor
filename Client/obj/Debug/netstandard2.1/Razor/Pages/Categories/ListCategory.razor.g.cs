#pragma checksum "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Categories\ListCategory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3c8500d3b457e62515f7ec83d633a2c5679a839"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>Categorias</h3>\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-body");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.AddMarkupContent(7, "<thead>\n            <tr>\n                <th scope=\"col\">Nome</th>        \n            </tr>\n        </thead>\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\n");
#nullable restore
#line 16 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Categories\ListCategory.razor"
             foreach (var item in categoryList)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "            ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 19 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Categories\ListCategory.razor"
                     item.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "        \n                ");
            __builder.OpenElement(16, "td");
            __builder.AddMarkupContent(17, "\n                    ");
            __builder.OpenElement(18, "a");
            __builder.AddAttribute(19, "href", "/Category/EditCategory/" + (
#nullable restore
#line 21 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Categories\ListCategory.razor"
                                                     item.CategoryId.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(20, "<button class=\"btn btn-success\">Editar</button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                    ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "btn btn-danger");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Categories\ListCategory.razor"
                                                               () => DeleteCategory(item.CategoryId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n");
#nullable restore
#line 25 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Categories\ListCategory.razor"
            }   

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n");
            __builder.CloseElement();
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
