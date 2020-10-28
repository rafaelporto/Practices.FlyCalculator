using System;
using System.ComponentModel;
using FlyCalculator.Web.Models;
using Microsoft.AspNetCore.Components;

namespace FlyCalculator.Web.Components
{
	public partial class CalculoPesoDecolagem : ComponentBase
	{
		private const string Title = "Cálculo de Peso de Decolagem";

		[Parameter]
		public Autonomia TotalAutonomia { get; set; }

		[Parameter]
		public ControlePesos Pesos { get; set; }

		[Parameter]
		public EventCallback<ControlePesos> PesosChanged { get; set; }

		protected override void OnInitialized()
		{
			Pesos.PropertyChanged += PesosAtualizados;
			base.OnInitialized();
		}

		private void PesosAtualizados(object sender, PropertyChangedEventArgs e)
		{
			Console.WriteLine($"Propriedade atualizada: {e.PropertyName}");

			if (sender is ControlePesos pesos)
				PesosChanged.InvokeAsync(pesos);
		}
	}
}


