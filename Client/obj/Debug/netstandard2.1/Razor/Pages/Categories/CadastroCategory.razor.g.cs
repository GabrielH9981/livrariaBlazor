#pragma checksum "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Categories\CadastroCategory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c22407aae5ba4c2d42233493a363d8dc429fc55f"
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
#line 2 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Categories\CadastroCategory.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Category/CadastroCategory")]
    public partial class CadastroCategory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card m-3");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.AddMarkupContent(3, "<h4 class=\"card-header\">Cadastro de Categorias</h4>\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Categories\CadastroCategory.razor"
                          category

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Categories\CadastroCategory.razor"
                                                   HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "onreset", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Categories\CadastroCategory.razor"
                                                                                HandleReset

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\n\n                ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group col-5");
                __builder2.AddMarkupContent(17, "\n                    ");
                __builder2.AddMarkupContent(18, "<label>Nome da Categorias</label>\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "class", "form-control");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Categories\CadastroCategory.razor"
                                            category.Nome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => category.Nome = __value, category.Nome))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => category.Nome));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\n                    ");
                __Blazor.crudBlazor.Client.Pages.Categories.CadastroCategory.TypeInference.CreateValidationMessage_0(__builder2, 25, 26, 
#nullable restore
#line 15 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Categories\CadastroCategory.razor"
                                              () => category.Nome

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(27, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\n                \n            ");
                __builder2.AddMarkupContent(29, "<div class=\"text-center\">\n                <button type=\"submit\" class=\"btn btn-primary mr-1\">Salvar</button>\n                <button type=\"reset\" class=\"btn btn-secondary\">Cancel</button>\n            </div>\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Categories\CadastroCategory.razor"
       
    private Category category = new Category();
    private EditContext editContext { get; set; }

    private async Task HandleValidSubmit()
    {
        //Enviar dados para o Controller no Backend
        var teste = await Http.PostAsJsonAsync("/Category/Create", category);
        NavigationManager.NavigateTo("Category/ListCategory");
    }

    private void HandleReset()
    {
        category = new Category();
        editContext = new EditContext(category);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.crudBlazor.Client.Pages.Categories.CadastroCategory
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
