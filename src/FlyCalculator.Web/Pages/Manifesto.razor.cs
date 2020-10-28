using FlyCalculator.Web.Models;
using Microsoft.AspNetCore.Components;

namespace FlyCalculator.Web.Pages
{
    public partial class Manifesto : ComponentBase
    {
        private const string Title = "Manifesto de Peso e Balanceamento";
        private Autonomia Total { get; set; }
        private Autonomia Etapa { get; set; }
        private ControlePesos Pesos { get; set; }
        private decimal PesoBasicoVazio { get; set; }

        protected override void OnInitialized()
        {
            Total = new Autonomia();
            Etapa = new Autonomia();
            Pesos = new ControlePesos(Total);
            base.OnInitialized();
        }
    }
}
