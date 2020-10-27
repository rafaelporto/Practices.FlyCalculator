namespace FlyCalculator.Web.Models
{
    public class CombustivelEtapa : PesoBalanceamento 
    {
        private readonly Autonomia _etapa;
        public override decimal Braco => 1.0M;
        public override decimal Momento => FormulaCalculoMomento(Peso, Braco);
        public override decimal Peso => _etapa.MassaCombustivel;

        public CombustivelEtapa(Autonomia etapa) => _etapa = etapa;
    }
}
