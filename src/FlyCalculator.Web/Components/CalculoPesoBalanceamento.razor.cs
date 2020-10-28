using FlyCalculator.Web.Models;
using Microsoft.AspNetCore.Components;

namespace FlyCalculator.Web.Components
{
	public partial class CalculoPesoBalanceamento : ComponentBase
    {
        private const string Title = "Cálculos de Peso e Balanceamento";
        public PesoBasicoVazio PesoBasicoVazio { get; set; }
        public Ocupantes Ocupantes { get; set; }
        public Bagageiro Bagageiro { get; set; } = new Bagageiro();
        public PesoZeroCombustivel PesoZeroCombustivel { get; set; }
        public Combustivel Combustivel { get; set; }
        public PesoDecolagem PesoDecolagem { get; set; }
        public CombustivelEtapa CombustivelEtapa { get; set; }
		public PesoPouso PesoPouso { get; set; }

        [Parameter]
		public Autonomia Etapa { get; set; }

        [Parameter]
        public Autonomia Total { get; set; }

        [Parameter]
        public ControlePesos Pesos { get; set; }

        protected override void OnInitialized()
        {
            PesoBasicoVazio = new PesoBasicoVazio(Pesos);
            Ocupantes = new Ocupantes(Pesos);
            PesoZeroCombustivel = new PesoZeroCombustivel(PesoBasicoVazio, Ocupantes, Bagageiro);
            Combustivel = new Combustivel(Total);
            PesoDecolagem = new PesoDecolagem(PesoZeroCombustivel, Combustivel);
            CombustivelEtapa = new CombustivelEtapa(Etapa);
            PesoPouso = new PesoPouso(PesoDecolagem, CombustivelEtapa);

            base.OnInitialized();
        }
    }
}
