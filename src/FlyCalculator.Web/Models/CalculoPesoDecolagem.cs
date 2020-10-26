namespace FlyCalculator.Web.Models
{
    public class CalculoPesoDecolagem
    {
        public decimal MaximoDecolagem => 757.0M;
        public decimal BasicoVazio { get; set; }
        public decimal DisponivelTotal => MaximoDecolagem - BasicoVazio;
        public Autonomia TotalAutonomia { get; set; }
        public decimal Tripulantes { get; set; }
        public decimal CargaMaxima => DisponivelTotal - TotalAutonomia.MassaCombustivel - Tripulantes;

		public CalculoPesoDecolagem(Autonomia totalAutonomia) => TotalAutonomia = totalAutonomia;
    }
}
