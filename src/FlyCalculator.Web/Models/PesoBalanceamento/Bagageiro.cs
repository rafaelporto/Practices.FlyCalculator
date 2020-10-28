namespace FlyCalculator.Web.Models
{
    public class Bagageiro : PesoBalanceamento 
    {
        public override decimal Braco => 1.620M;
        public override decimal Momento => FormulaCalculoMomento(Peso, Braco);
	}
}
