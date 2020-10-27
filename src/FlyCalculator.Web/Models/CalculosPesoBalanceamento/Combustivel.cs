namespace FlyCalculator.Web.Models
{
    public class Combustivel : PesoBalanceamento 
    {
        private readonly Autonomia _totalAutonomia;
        public override decimal Braco => 1.0M;
        public override decimal Momento => FormulaCalculoMomento(Peso, Braco);
        public override decimal Peso => _totalAutonomia.MassaCombustivel;

        public Combustivel(Autonomia totalAutonomia) =>
                _totalAutonomia = totalAutonomia;
    }
}
