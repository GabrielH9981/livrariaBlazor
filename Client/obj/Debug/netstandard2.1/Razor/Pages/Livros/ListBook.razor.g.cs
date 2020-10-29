#pragma checksum "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\ListBook.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c12f4037e362420e00031ca705310349ca7e4363"
// <auto-generated/>
#pragma warning disable 1591
namespace crudBlazor.Client.Pages.Livros
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
#line 2 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\ListBook.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Book/ListBook")]
    public partial class ListBook : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Livros</h3>\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-body");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.AddMarkupContent(7, "<thead>\n            <tr>\n                <th scope=\"col\">Titulo</th>\n                <th scope=\"col\">Sinopse</th>\n                \n            </tr>\n        </thead>\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\n");
#nullable restore
#line 18 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\ListBook.razor"
             foreach (var item in bookList)
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
#line 21 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\ListBook.razor"
                     item.Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 22 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\ListBook.razor"
                     item.Sinopse

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                \n                ");
            __builder.OpenElement(19, "td");
            __builder.AddMarkupContent(20, "\n                    ");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "href", "/Book/EditBook/" + (
#nullable restore
#line 25 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\ListBook.razor"
                                             item.BookId.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "<button class=\"btn btn-success\">Editar</button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                    ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "btn btn-danger");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\ListBook.razor"
                                                               () => DeleteBook(item.BookId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n");
#nullable restore
#line 29 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\ListBook.razor"
            }   

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\ListBook.razor"
       

    private List<Book> bookList = new List<Book>();

    protected override async Task OnInitializedAsync()
    {

        var books = await Http.GetFromJsonAsync<List<Book>>("/Book/List");
        foreach (var item in books)
        {
            bookList.Add(item);
        }
    }

    private async Task DeleteBook(int itemId)
    {
        //call controller
        await Http.DeleteAsync("/Book/Delete/"+itemId);
        NavigationManager.NavigateTo("Book/ListBook", true);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591