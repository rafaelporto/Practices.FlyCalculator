namespace FlyCalculator.Web.Models
{
    public class Ocupantes : PesoBalanceamento 
    {
        private readonly ControlePesos controlePesos;
        public override decimal Braco => 0.990M;
        public override decimal Peso => controlePesos.Tripulantes;
        public override decimal Momento => FormulaCalculoMomento(Peso, Braco);

		public Ocupantes(ControlePesos pesos) => controlePesos = pesos;
    }
}
