using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyCalculator.Web.Models
{
    public class CalculoPesoBalanceamento
    {
        public PesoBalanceamento PesoBasicoVazio { get; set; } = new PesoBalanceamento();
        public PesoBalanceamento Ocupantes { get; set; } = new PesoBalanceamento();
        public PesoBalanceamento Bagageiro { get; set; } = new PesoBalanceamento();
        public PesoBalanceamento PesoZeroCombustivel { get; set; } = new PesoBalanceamento();
        public PesoBalanceamento Combustivel { get; set; } = new PesoBalanceamento();
        public PesoBalanceamento PesoDecolagem { get; set; } = new PesoBalanceamento();
        public PesoBalanceamento CombustivelEtapa { get; set; } = new PesoBalanceamento();
        public PesoBalanceamento PesoPouso { get; set; } = new PesoBalanceamento();
    }
}
