#pragma checksum "C:\Users\rafael.monteiro\Rafael\Pessoal\Projetos\Labs\Practices.FlyCalculator\src\FlyCalculator\FlyCalculator.Web\Components\CalculoPesoDecolagemComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a94af9d62338a814b46fe0eb72a13028d410ed4"
// <auto-generated/>
#pragma warning disable 1591
namespace FlyCalculator.Web.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rafael.monteiro\Rafael\Pessoal\Projetos\Labs\Practices.FlyCalculator\src\FlyCalculator\FlyCalculator.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rafael.monteiro\Rafael\Pessoal\Projetos\Labs\Practices.FlyCalculator\src\FlyCalculator\FlyCalculator.Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rafael.monteiro\Rafael\Pessoal\Projetos\Labs\Practices.FlyCalculator\src\FlyCalculator\FlyCalculator.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rafael.monteiro\Rafael\Pessoal\Projetos\Labs\Practices.FlyCalculator\src\FlyCalculator\FlyCalculator.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rafael.monteiro\Rafael\Pessoal\Projetos\Labs\Practices.FlyCalculator\src\FlyCalculator\FlyCalculator.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rafael.monteiro\Rafael\Pessoal\Projetos\Labs\Practices.FlyCalculator\src\FlyCalculator\FlyCalculator.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rafael.monteiro\Rafael\Pessoal\Projetos\Labs\Practices.FlyCalculator\src\FlyCalculator\FlyCalculator.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rafael.monteiro\Rafael\Pessoal\Projetos\Labs\Practices.FlyCalculator\src\FlyCalculator\FlyCalculator.Web\_Imports.razor"
using FlyCalculator.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rafael.monteiro\Rafael\Pessoal\Projetos\Labs\Practices.FlyCalculator\src\FlyCalculator\FlyCalculator.Web\_Imports.razor"
using FlyCalculator.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\rafael.monteiro\Rafael\Pessoal\Projetos\Labs\Practices.FlyCalculator\src\FlyCalculator\FlyCalculator.Web\Components\CalculoPesoDecolagemComponent.razor"
using FlyCalculator.Web.Models;

#line default
#line hidden
#nullable disable
    public partial class CalculoPesoDecolagemComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "h5");
            __builder.AddContent(4, 
#nullable restore
#line 4 "C:\Users\rafael.monteiro\Rafael\Pessoal\Projetos\Labs\Practices.FlyCalculator\src\FlyCalculator\FlyCalculator.Web\Components\CalculoPesoDecolagemComponent.razor"
         title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.AddMarkupContent(9, "<div class=\"col-md-2\">\r\n            <label>Peso Máx. Decolagem</label>\r\n        </div>\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-md-5");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "type", "number");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\rafael.monteiro\Rafael\Pessoal\Projetos\Labs\Practices.FlyCalculator\src\FlyCalculator\FlyCalculator.Web\Components\CalculoPesoDecolagemComponent.razor"
                                              model.MaximoDecolagem

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => model.MaximoDecolagem = __value, model.MaximoDecolagem, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "row");
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.AddMarkupContent(23, "<div class=\"col-md-2\">\r\n            <label>Peso Básico Vazio(PBV)</label>\r\n        </div>\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col-md-5");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "number");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\rafael.monteiro\Rafael\Pessoal\Projetos\Labs\Practices.FlyCalculator\src\FlyCalculator\FlyCalculator.Web\Components\CalculoPesoDecolagemComponent.razor"
                                              model.BasicoVazio

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => model.BasicoVazio = __value, model.BasicoVazio, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "row");
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.AddMarkupContent(37, "<div class=\"col-md-2\">\r\n            <label><b>Peso disponível total: </b></label>\r\n        </div>\r\n        ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "col-md-5");
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "type", "number");
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\rafael.monteiro\Rafael\Pessoal\Projetos\Labs\Practices.FlyCalculator\src\FlyCalculator\FlyCalculator.Web\Components\CalculoPesoDecolagemComponent.razor"
                                              model.DisponivelTotal

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => model.DisponivelTotal = __value, model.DisponivelTotal, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "row");
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.AddMarkupContent(51, "<div class=\"col-md-2\">\r\n            <label>Mínimo Comb. Requirido</label>\r\n        </div>\r\n        ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "col-md-5");
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.OpenElement(55, "input");
            __builder.AddAttribute(56, "type", "number");
            __builder.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\rafael.monteiro\Rafael\Pessoal\Projetos\Labs\Practices.FlyCalculator\src\FlyCalculator\FlyCalculator.Web\Components\CalculoPesoDecolagemComponent.razor"
                                              model.MinimoCombustivel

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => model.MinimoCombustivel = __value, model.MinimoCombustivel, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n    ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "row");
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.AddMarkupContent(65, "<div class=\"col-md-2\">\r\n            <label>Peso dos tripulantes</label>\r\n        </div>\r\n        ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "col-md-5");
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.OpenElement(69, "input");
            __builder.AddAttribute(70, "type", "number");
            __builder.AddAttribute(71, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\Users\rafael.monteiro\Rafael\Pessoal\Projetos\Labs\Practices.FlyCalculator\src\FlyCalculator\FlyCalculator.Web\Components\CalculoPesoDecolagemComponent.razor"
                                              model.Tripulantes

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => model.Tripulantes = __value, model.Tripulantes, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n    ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "row");
            __builder.AddMarkupContent(78, "\r\n        ");
            __builder.AddMarkupContent(79, "<div class=\"col-md-2\">\r\n            <label><b>Carga Paga Máxima: </b></label>\r\n        </div>\r\n        ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "col-md-5");
            __builder.AddMarkupContent(82, "\r\n            ");
            __builder.OpenElement(83, "input");
            __builder.AddAttribute(84, "type", "number");
            __builder.AddAttribute(85, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 50 "C:\Users\rafael.monteiro\Rafael\Pessoal\Projetos\Labs\Practices.FlyCalculator\src\FlyCalculator\FlyCalculator.Web\Components\CalculoPesoDecolagemComponent.razor"
                                              model.CargaMaxima

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(86, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => model.CargaMaxima = __value, model.CargaMaxima, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\rafael.monteiro\Rafael\Pessoal\Projetos\Labs\Practices.FlyCalculator\src\FlyCalculator\FlyCalculator.Web\Components\CalculoPesoDecolagemComponent.razor"
       
    private string title = "Cálculo de Peso de Decolagem";
    private CalculoPesoDecolagem model = new CalculoPesoDecolagem();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
