namespace FlyCalculator.Web.Models
{
	public class PesoBasicoVazio : PesoBalanceamento
	{
		private readonly ControlePesos _pesos;

		public override decimal Peso => _pesos.BasicoVazio;

		public override decimal Braco 
		{ 
			get => base.Braco;
			set
			{
				base.Braco = value;
				base.Momento = FormulaCalculoMomento(Peso, base.Braco);
			}
		}
		public PesoBasicoVazio(ControlePesos controlePesos) => _pesos = controlePesos;
	}
}
