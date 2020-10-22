using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FlyCalculator.Web.Models
{
    public class CalculoAutonomia : INotifyPropertyChanged
    {
        public Autonomia Etapa { get; set; } = new Autonomia();
        public Autonomia Alternado { get; set; } = new Autonomia();
        public Autonomia Reserva { get; set; } = new Autonomia();
        public Autonomia Adicional { get; set; } = new Autonomia();
        public Autonomia MinimoRequirido { get; set; } = new Autonomia();
        public Autonomia Total { get; set; } = new Autonomia();

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
