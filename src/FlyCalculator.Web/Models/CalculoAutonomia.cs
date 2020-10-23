namespace FlyCalculator.Web.Models
{
    public class CalculoAutonomia
    {
        public Autonomia Etapa { get; set; } = new Autonomia();
        public Autonomia Alternado { get; set; } = new Autonomia();
        public Autonomia Reserva { get; set; } = new Autonomia();
        public Autonomia Adicional { get; set; } = new Autonomia();
        public Autonomia MinimoRequirido { get; set; } = new Autonomia();
        public Autonomia Total { get; set; } = new Autonomia();
    }
}
