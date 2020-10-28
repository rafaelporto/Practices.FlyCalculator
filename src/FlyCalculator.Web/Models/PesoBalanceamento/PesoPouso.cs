namespace FlyCalculator.Web.Models
{
    public class PesoPouso : PesoBalanceamento 
    {
        private readonly PesoDecolagem _pesoDecolagem;
        private readonly CombustivelEtapa _combustivelEtapa;
        public override decimal Braco => FormulaCalculoBraco(Peso, Momento);
        public override decimal Momento => _pesoDecolagem.Momento - _combustivelEtapa.Momento;
        public override decimal Peso => _pesoDecolagem.Peso - _combustivelEtapa.Peso;

        public PesoPouso(PesoDecolagem pesoDecolagem, CombustivelEtapa combustivelEtapa) =>
                (_pesoDecolagem, _combustivelEtapa) = (pesoDecolagem, combustivelEtapa);
    }
}
