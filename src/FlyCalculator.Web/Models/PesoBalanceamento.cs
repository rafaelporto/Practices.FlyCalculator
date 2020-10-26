namespace FlyCalculator.Web.Models
{
    public class PesoBalanceamento
    {
        public decimal Peso { get; set; }
        public decimal Braco { get; set; }
        public decimal Momento => Peso * Braco;
    }
}
