#pragma checksum "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\CadastroLivro.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04ad89ebb4ff9de54ca405928811f2fd199298e6"
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
#line 2 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\CadastroLivro.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Book/CadastroBook")]
    public partial class CadastroLivro : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card m-3");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.AddMarkupContent(3, "<h4 class=\"card-header\">Cadastro de Livros</h4>\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\CadastroLivro.razor"
                          book

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\CadastroLivro.razor"
                                               HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "onreset", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\CadastroLivro.razor"
                                                                            HandleReset

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\n                ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-row");
                __builder2.AddMarkupContent(17, "\n                    ");
                __builder2.AddMarkupContent(18, "<label>Nome do Livro:</label>\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "class", "form-control");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\CadastroLivro.razor"
                                            book.Titulo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => book.Titulo = __value, book.Titulo))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => book.Titulo));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\n                    ");
                __Blazor.crudBlazor.Client.Pages.Livros.CadastroLivro.TypeInference.CreateValidationMessage_0(__builder2, 25, 26, 
#nullable restore
#line 14 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\CadastroLivro.razor"
                                              () => book.Titulo

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(27, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "  \n\n                ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-row");
                __builder2.AddMarkupContent(31, "\n                    ");
                __builder2.AddMarkupContent(32, "<label>Sinopse:</label>\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(33);
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\CadastroLivro.razor"
                                            book.Sinopse

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => book.Sinopse = __value, book.Sinopse))));
                __builder2.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => book.Sinopse));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\n                    ");
                __Blazor.crudBlazor.Client.Pages.Livros.CadastroLivro.TypeInference.CreateValidationMessage_1(__builder2, 39, 40, 
#nullable restore
#line 20 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\CadastroLivro.razor"
                                              () => book.Sinopse

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(41, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, " \n\n                ");
                __builder2.OpenElement(43, "div");
                __builder2.AddMarkupContent(44, "\n                ");
                __Blazor.crudBlazor.Client.Pages.Livros.CadastroLivro.TypeInference.CreateInputSelect_2(__builder2, 45, 46, 
#nullable restore
#line 24 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\CadastroLivro.razor"
                                          book.CategoryId

#line default
#line hidden
#nullable disable
                , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => book.CategoryId = __value, book.CategoryId)), 48, () => book.CategoryId, 49, (__builder3) => {
                    __builder3.AddMarkupContent(50, "\n                    ");
                    __builder3.AddMarkupContent(51, "<option value>Select</option>\n");
#nullable restore
#line 26 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\CadastroLivro.razor"
                     foreach (var category in categoriesList)
                            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(52, "                                ");
                    __builder3.OpenElement(53, "option");
                    __builder3.AddAttribute(54, "value", 
#nullable restore
#line 28 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\CadastroLivro.razor"
                                                category.CategoryId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(55, 
#nullable restore
#line 28 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\CadastroLivro.razor"
                                                                      category.Nome

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(56, "\n");
#nullable restore
#line 29 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\CadastroLivro.razor"
                            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(57, "                        ");
                }
                );
                __builder2.AddMarkupContent(58, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\n\n                \n\n                ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-check form-check-inline");
                __builder2.AddMarkupContent(62, "\n");
#nullable restore
#line 46 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\CadastroLivro.razor"
                     foreach (var autor in autorsList)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(63, "                        ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-check form-check-inline");
                __builder2.AddMarkupContent(66, "\n                            ");
                __builder2.OpenElement(67, "input");
                __builder2.AddAttribute(68, "class", "form-check-input");
                __builder2.AddAttribute(69, "type", "checkbox");
                __builder2.AddAttribute(70, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\CadastroLivro.razor"
                                                                                          autor.Checked

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => autor.Checked = __value, autor.Checked));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\n                            ");
                __builder2.OpenElement(73, "label");
                __builder2.AddAttribute(74, "class", "form-check-label");
                __builder2.AddContent(75, 
#nullable restore
#line 50 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\CadastroLivro.razor"
                                                             autor.Nome

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\n");
#nullable restore
#line 52 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\CadastroLivro.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(78, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\n\n            ");
                __builder2.AddMarkupContent(80, "<div class=\"text-center\">\n                <button type=\"submit\" class=\"btn btn-primary mr-1\">Salvar</button>\n                <button type=\"reset\" class=\"btn btn-secondary\">Cancel</button>\n            </div>\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(81, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\Livros\CadastroLivro.razor"
       
    
    private BookDto book = new BookDto();
    private List<Autor> autorList = new List<Autor>();
    private EditContext editContext { get; set; }
    private List<Category> categoriesList = new List<Category>();
    private List<Autor> autorsList = new List<Autor>();

    protected override async Task OnInitializedAsync()
    {
        // carregar as categorias
        var categories = await Http.GetFromJsonAsync<List<Category>>("/Category/List");
        foreach (var item in categories)
        {
            categoriesList.Add(item);
        }

        // carregar os autores
        var autors = await Http.GetFromJsonAsync<List<Autor>>("/Autor/List");
        foreach (var item in autors)
        {
            autorsList.Add(item);
        }
    }

    private async Task OnChangeCat(string value)
    {
        var autores = await Http.GetFromJsonAsync<List<Autor>>("/Autor/List");
        autorList.Clear();
        var autoresByBook = autores.Where(c => c.AutorId == Convert.ToInt32(value));
        foreach (var item in autoresByBook)
        {
            autorsList.Add(item);
        }
    }

    private async Task HandleValidSubmit()
    {
        var teste = await Http.PostAsJsonAsync("/Book/Create", book);
        NavigationManager.NavigateTo("Book/ListBook");
    }

    private void HandleReset()
    {
        book = new BookDto();
        editContext = new EditContext(book);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.crudBlazor.Client.Pages.Livros.CadastroLivro
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
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
