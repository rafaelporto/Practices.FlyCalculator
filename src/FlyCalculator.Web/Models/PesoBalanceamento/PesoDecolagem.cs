namespace FlyCalculator.Web.Models
{
    public class PesoDecolagem : PesoBalanceamento 
    {
        private readonly PesoZeroCombustivel _pesoZeroCombustivel;
        private readonly Combustivel _combustivel;

        public override decimal Braco => FormulaCalculoBraco(Peso, Momento);
        public override decimal Peso => _pesoZeroCombustivel.Peso + _combustivel.Peso;
        public override decimal Momento => _pesoZeroCombustivel.Momento + _combustivel.Momento;

        public PesoDecolagem(PesoZeroCombustivel pesoZeroCombustivel, Combustivel combustivel) =>
                (_pesoZeroCombustivel, _combustivel) = (pesoZeroCombustivel, combustivel);
    }
}
