using System;

namespace FlyCalculator.Web.Models
{
    public class CalculoPesoBalanceamento
    {
        public PesoBalanceamento PesoBasicoVazio { get; set; } = new PesoBalanceamento();
        public Ocupantes Ocupantes { get; set; } = new Ocupantes();
        public Bagageiro Bagageiro { get; set; } = new Bagageiro();
        public PesoZeroCombustivel PesoZeroCombustivel { get; set; }
        public Combustivel Combustivel { get; set; }
        public PesoDecolagem PesoDecolagem { get; set; }
        public CombustivelEtapa CombustivelEtapa { get; set; }
        //public PesoPouso PesoPouso { get; set; }

        public CalculoPesoBalanceamento(CalculoAutonomia calculoAutonomia)
        {
            PesoZeroCombustivel = new PesoZeroCombustivel(PesoBasicoVazio, Ocupantes, Bagageiro);
            Combustivel = new Combustivel(calculoAutonomia.Total);
            PesoDecolagem = new PesoDecolagem(PesoZeroCombustivel, Combustivel);
            CombustivelEtapa = new CombustivelEtapa(calculoAutonomia.Etapa);
            //PesoPouso = new PesoPouso(PesoDecolagem, CombustivelEtapa);
        }
    }
}
