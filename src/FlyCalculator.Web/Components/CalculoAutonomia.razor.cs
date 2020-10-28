using FlyCalculator.Web.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace FlyCalculator.Web.Components
{
    public partial class CalculoAutonomia : ComponentBase
    {
        private const string Title = "Cálculo de Autonomia";
        public Autonomia Alternado { get; set; } = new Autonomia();
        public Autonomia Reserva { get; set; } = new Autonomia();
        public Autonomia Adicional { get; set; } = new Autonomia();
        public Autonomia MinimoRequirido { get; set; } = new Autonomia();

        [Parameter]
        public Autonomia Etapa { get; set; }

        [Parameter]
        public EventCallback<Autonomia> EtapaChanged { get; set; }

        [Parameter]
        public Autonomia Total { get; set; }

        [Parameter]
		public EventCallback<Autonomia> TotalChanged { get; set; }

		private async Task AtualizaValores(ChangeEventArgs args, Autonomia autonomia)
        {
            if (TimeSpan.TryParse(args.Value.ToString(), out TimeSpan newValue))
            {
                autonomia.Tempo = newValue;
                autonomia.Litros = CalculaQuantidade(newValue);
                CalculaMinimoRequirido();
                await CalculaTotal();
            }
        }

        public void CalculaMinimoRequirido()
        { 
            MinimoRequirido.Tempo = Etapa.Tempo + Alternado.Tempo + Reserva.Tempo;
            MinimoRequirido.Litros = CalculaQuantidade(MinimoRequirido.Tempo);
        }

        public async Task CalculaTotal()
        { 
            Total.Tempo = Etapa.Tempo + Alternado.Tempo + Reserva.Tempo + Adicional.Tempo;
            Total.Litros = CalculaQuantidade(Total.Tempo);

            await TotalChanged.InvokeAsync(Total);
        }

        public decimal CalculaQuantidade(TimeSpan tempo)
        {
            var cessna = 21.0M; //consumo de litro por hora
            return cessna * (decimal)tempo.TotalHours;
        }
    }
}
