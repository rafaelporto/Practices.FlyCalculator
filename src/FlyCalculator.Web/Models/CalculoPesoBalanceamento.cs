namespace FlyCalculator.Web.Models
{
    public class CalculoPesoBalanceamento
    {
        public PesoBalanceamento PesoBasicoVazio { get; set; } = new PesoBalanceamento();
        public PesoBalanceamento Ocupantes { get; set; }
        public PesoBalanceamento Bagageiro { get; set; } = new PesoBalanceamento();
        public PesoBalanceamento PesoZeroCombustivel { get; set; } = new PesoBalanceamento();
        public PesoBalanceamento Combustivel { get; set; } = new PesoBalanceamento();
        public PesoBalanceamento PesoDecolagem { get; set; } = new PesoBalanceamento();
        public PesoBalanceamento CombustivelEtapa { get; set; } = new PesoBalanceamento();
        public PesoBalanceamento PesoPouso { get; set; } = new PesoBalanceamento();

        public CalculoPesoBalanceamento()
        {
            Ocupantes = new PesoBalanceamento() { Braco = 0.990M };
            Bagageiro = new PesoBalanceamento() { Braco = 1.620M };
            Combustivel = new PesoBalanceamento() { Braco = 1.0M };
            CombustivelEtapa = new PesoBalanceamento() { Braco = 1.0M };
        }
    }
}
