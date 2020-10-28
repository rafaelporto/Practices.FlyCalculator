using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FlyCalculator.Web.Models
{
	public class ControlePesos : INotifyPropertyChanged
	{
		private readonly Autonomia _totalAutonomia;
		private decimal _basicoVazio;
		public decimal BasicoVazio
		{
			get => _basicoVazio;
			set
			{
				_basicoVazio = value;
				NotifyPropertyChanged();
			}
		}

		public decimal MaximoDecolagem => 757.0M;
		public decimal DisponivelTotal => MaximoDecolagem - BasicoVazio;

		private decimal _tripulantes;
		public decimal Tripulantes
		{
			get => _tripulantes;
			set
			{
				_tripulantes = value;
				NotifyPropertyChanged();
			}
		}
		public decimal CargaMaxima => DisponivelTotal - _totalAutonomia.MassaCombustivel - Tripulantes;

		public ControlePesos(Autonomia totalAutonomia) =>
				_totalAutonomia = totalAutonomia;

		public event PropertyChangedEventHandler PropertyChanged;

		private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") =>
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
