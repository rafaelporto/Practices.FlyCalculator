using System;

namespace FlyCalculator.Web.Models
{
    public class CalculoAutonomia
    {
        public Autonomia Etapa { get; set; } = new Autonomia();
        public Autonomia Alternado { get; set; } = new Autonomia();
        public Autonomia Reserva { get; set; } = new Autonomia();
        public Autonomia Adicional { get; set; } = new Autonomia();
        public Autonomia MinimoRequirido { get; set; } = new Autonomia();
        public Autonomia Total { get; set; } = new Autonomia();

        public void CalculaMinimoRequirido()
        { 
            MinimoRequirido.Tempo = Etapa.Tempo + Alternado.Tempo + Reserva.Tempo;
            MinimoRequirido.Litros = CalculaQuantidade(MinimoRequirido.Tempo);
        }

        public void CalculaTotal()
        { 
            Total.Tempo = Etapa.Tempo + Alternado.Tempo + Reserva.Tempo + Adicional.Tempo;
            Total.Litros = CalculaQuantidade(Total.Tempo);
        }

        public decimal CalculaQuantidade(TimeSpan tempo)
        {
            var cessna = 21.0M; //consumo de litro por hora
            return cessna * (decimal)tempo.TotalHours;
        }
    }
}
