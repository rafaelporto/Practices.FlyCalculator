using System;

namespace FlyCalculator.Web.Models
{
    public class PesoBalanceamento
    {
        public virtual decimal Peso { get; set; }
        public virtual decimal Braco { get; set; }
        public virtual decimal Momento { get; set; }

        public static decimal FormulaCalculoMomento(decimal peso, decimal braco) => peso * braco;
        public static decimal FormulaCalculoBraco(decimal peso, decimal momento)
        {
            if (peso == 0)
                return 0.0M;

            return momento / peso;
        }
    }
}
