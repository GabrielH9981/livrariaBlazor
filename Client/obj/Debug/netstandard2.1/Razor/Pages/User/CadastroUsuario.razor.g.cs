#pragma checksum "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\User\CadastroUsuario.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22144625738cab52e5375ae3b1fdcec7b0c14182"
// <auto-generated/>
#pragma warning disable 1591
namespace crudBlazor.Client.Pages.User
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
#line 2 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\User\CadastroUsuario.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/User/CadastroUsuario")]
    public partial class CadastroUsuario : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card m-3");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.AddMarkupContent(3, "<h4 class=\"card-header\">Cadastro do Usuário</h4>\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\User\CadastroUsuario.razor"
                          user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\User\CadastroUsuario.razor"
                                               HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "onreset", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\User\CadastroUsuario.razor"
                                                                            HandleReset

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\n            ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-row");
                __builder2.AddMarkupContent(17, "\n                ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group col");
                __builder2.AddMarkupContent(20, "\n                    ");
                __builder2.AddMarkupContent(21, "<label>Título</label>\n                    ");
                __Blazor.crudBlazor.Client.Pages.User.CadastroUsuario.TypeInference.CreateInputSelect_0(__builder2, 22, 23, "form-control", 24, 
#nullable restore
#line 14 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\User\CadastroUsuario.razor"
                                              user.Title

#line default
#line hidden
#nullable disable
                , 25, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Title = __value, user.Title)), 26, () => user.Title, 27, (__builder3) => {
                    __builder3.AddMarkupContent(28, "\n                        <option value></option>\n                        ");
                    __builder3.AddMarkupContent(29, "<option value=\"Sr\">Sr</option>\n                        ");
                    __builder3.AddMarkupContent(30, "<option value=\"Sra\">Sra</option>\n                    ");
                }
                );
                __builder2.AddMarkupContent(31, "\n                    ");
                __Blazor.crudBlazor.Client.Pages.User.CadastroUsuario.TypeInference.CreateValidationMessage_1(__builder2, 32, 33, 
#nullable restore
#line 19 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\User\CadastroUsuario.razor"
                                              () => user.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(34, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\n                ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group col-5");
                __builder2.AddMarkupContent(38, "\n                    ");
                __builder2.AddMarkupContent(39, "<label>First Name</label>\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(40);
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddAttribute(42, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\User\CadastroUsuario.razor"
                                            user.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.FirstName = __value, user.FirstName))));
                __builder2.AddAttribute(44, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\n                    ");
                __Blazor.crudBlazor.Client.Pages.User.CadastroUsuario.TypeInference.CreateValidationMessage_2(__builder2, 46, 47, 
#nullable restore
#line 24 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\User\CadastroUsuario.razor"
                                              () => user.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(48, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\n                ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group col-5");
                __builder2.AddMarkupContent(52, "\n                    ");
                __builder2.AddMarkupContent(53, "<label>Middle Name</label>\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(54);
                __builder2.AddAttribute(55, "class", "form-control");
                __builder2.AddAttribute(56, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\User\CadastroUsuario.razor"
                                            user.MiddleName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.MiddleName = __value, user.MiddleName))));
                __builder2.AddAttribute(58, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.MiddleName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\n                    ");
                __Blazor.crudBlazor.Client.Pages.User.CadastroUsuario.TypeInference.CreateValidationMessage_3(__builder2, 60, 61, 
#nullable restore
#line 29 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\User\CadastroUsuario.razor"
                                              () => user.MiddleName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(62, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\n                ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-group col-5");
                __builder2.AddMarkupContent(66, "\n                    ");
                __builder2.AddMarkupContent(67, "<label>Last Name</label>\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(68);
                __builder2.AddAttribute(69, "class", "form-control");
                __builder2.AddAttribute(70, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\User\CadastroUsuario.razor"
                                            user.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.LastName = __value, user.LastName))));
                __builder2.AddAttribute(72, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\n                    ");
                __Blazor.crudBlazor.Client.Pages.User.CadastroUsuario.TypeInference.CreateValidationMessage_4(__builder2, 74, 75, 
#nullable restore
#line 34 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\User\CadastroUsuario.razor"
                                              () => user.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(76, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\n            ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "form-row");
                __builder2.AddMarkupContent(81, "\n                ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "form-group col");
                __builder2.AddMarkupContent(84, "\n                    ");
                __builder2.AddMarkupContent(85, "<label>Date of Birth</label>\n                    ");
                __Blazor.crudBlazor.Client.Pages.User.CadastroUsuario.TypeInference.CreateInputDate_5(__builder2, 86, 87, "form-control", 88, 
#nullable restore
#line 40 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\User\CadastroUsuario.razor"
                                            user.DateOfBirth

#line default
#line hidden
#nullable disable
                , 89, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.DateOfBirth = __value, user.DateOfBirth)), 90, () => user.DateOfBirth);
                __builder2.AddMarkupContent(91, "\n                    ");
                __Blazor.crudBlazor.Client.Pages.User.CadastroUsuario.TypeInference.CreateValidationMessage_6(__builder2, 92, 93, 
#nullable restore
#line 41 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\User\CadastroUsuario.razor"
                                              () => user.DateOfBirth

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(94, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\n                ");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "form-group col");
                __builder2.AddMarkupContent(98, "\n                    ");
                __builder2.AddMarkupContent(99, "<label>Email</label>\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(100);
                __builder2.AddAttribute(101, "class", "form-control");
                __builder2.AddAttribute(102, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\User\CadastroUsuario.razor"
                                            user.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(103, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Email = __value, user.Email))));
                __builder2.AddAttribute(104, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(105, "\n                    ");
                __Blazor.crudBlazor.Client.Pages.User.CadastroUsuario.TypeInference.CreateValidationMessage_7(__builder2, 106, 107, 
#nullable restore
#line 46 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\User\CadastroUsuario.razor"
                                              () => user.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(108, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\n            ");
                __builder2.OpenElement(111, "div");
                __builder2.AddAttribute(112, "class", "form-row");
                __builder2.AddMarkupContent(113, "\n                ");
                __builder2.OpenElement(114, "div");
                __builder2.AddAttribute(115, "class", "form-group col");
                __builder2.AddMarkupContent(116, "\n                    ");
                __builder2.AddMarkupContent(117, "<label>Password</label>\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(118);
                __builder2.AddAttribute(119, "type", "password");
                __builder2.AddAttribute(120, "class", "form-control");
                __builder2.AddAttribute(121, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\User\CadastroUsuario.razor"
                                            user.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(122, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Password = __value, user.Password))));
                __builder2.AddAttribute(123, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(124, "\n                    ");
                __Blazor.crudBlazor.Client.Pages.User.CadastroUsuario.TypeInference.CreateValidationMessage_8(__builder2, 125, 126, 
#nullable restore
#line 53 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\User\CadastroUsuario.razor"
                                              () => user.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(127, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\n                ");
                __builder2.OpenElement(129, "div");
                __builder2.AddAttribute(130, "class", "form-group col");
                __builder2.AddMarkupContent(131, "\n                    ");
                __builder2.AddMarkupContent(132, "<label>Confirm Password</label>\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(133);
                __builder2.AddAttribute(134, "type", "password");
                __builder2.AddAttribute(135, "class", "form-control");
                __builder2.AddAttribute(136, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\User\CadastroUsuario.razor"
                                            user.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(137, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.ConfirmPassword = __value, user.ConfirmPassword))));
                __builder2.AddAttribute(138, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.ConfirmPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(139, "\n                    ");
                __Blazor.crudBlazor.Client.Pages.User.CadastroUsuario.TypeInference.CreateValidationMessage_9(__builder2, 140, 141, 
#nullable restore
#line 58 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\User\CadastroUsuario.razor"
                                              () => user.ConfirmPassword

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(142, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(143, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(144, "\n            ");
                __builder2.OpenElement(145, "div");
                __builder2.AddAttribute(146, "class", "form-group form-check");
                __builder2.AddMarkupContent(147, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(148);
                __builder2.AddAttribute(149, "id", "acceptTerms");
                __builder2.AddAttribute(150, "class", "form-check-input");
                __builder2.AddAttribute(151, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 62 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\User\CadastroUsuario.razor"
                                            user.AcceptTerms

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(152, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.AcceptTerms = __value, user.AcceptTerms))));
                __builder2.AddAttribute(153, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => user.AcceptTerms));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(154, "\n                ");
                __builder2.AddMarkupContent(155, "<label for=\"acceptTerms\" class=\"form-check-label\">Accept Terms & Conditions</label>\n                ");
                __Blazor.crudBlazor.Client.Pages.User.CadastroUsuario.TypeInference.CreateValidationMessage_10(__builder2, 156, 157, 
#nullable restore
#line 64 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\User\CadastroUsuario.razor"
                                          () => user.AcceptTerms

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(158, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(159, "\n            ");
                __builder2.AddMarkupContent(160, "<div class=\"text-center\">\n                <button type=\"submit\" class=\"btn btn-primary mr-1\">Salvar</button>\n                <button type=\"reset\" class=\"btn btn-secondary\">Cancel</button>\n            </div>\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(161, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\Users\Gabriel\Desktop\blazorLivraria-main\Client\Pages\User\CadastroUsuario.razor"
       

    private User user = new User();
    private EditContext editContext { get; set; }

    private async Task HandleValidSubmit()
    {
        //Enviar dados para o Controller no Backend
        var teste = await Http.PostAsJsonAsync("/User/Create", user);
        NavigationManager.NavigateTo("user/ListUsuario");

    }

    private void HandleReset()
    {
        user = new User();
        editContext = new EditContext(user);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.crudBlazor.Client.Pages.User.CadastroUsuario
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_10<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
