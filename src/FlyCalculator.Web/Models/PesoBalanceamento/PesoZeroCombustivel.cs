namespace FlyCalculator.Web.Models
{
    public class PesoZeroCombustivel : PesoBalanceamento 
    {
        private readonly PesoBalanceamento _pesoBasicoVazio;
        private readonly Ocupantes _ocupantes;
        private readonly Bagageiro _bagageiro;

        public override decimal Peso => _pesoBasicoVazio.Peso + _ocupantes.Peso + _bagageiro.Peso;
        public override decimal Momento => _pesoBasicoVazio.Momento + _ocupantes.Momento + _bagageiro.Momento;
        public override decimal Braco => FormulaCalculoBraco(Peso, Momento);

        public PesoZeroCombustivel(PesoBalanceamento pesoBasicoVazio,
                                    Ocupantes ocupantes, Bagageiro bagageiro)
        {
            _pesoBasicoVazio = pesoBasicoVazio;
            _ocupantes = ocupantes;
            _bagageiro = bagageiro;
        }
    }
}
