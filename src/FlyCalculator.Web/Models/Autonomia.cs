﻿using Microsoft.AspNetCore.Components.Forms;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace FlyCalculator.Web.Models
{
    public class Autonomia
    {
        public TimeSpan Tempo { get; set; }

        [Range(typeof(decimal), "0", "1000", ErrorMessage = "A quantidade de litros deve ser entre {0} e {1}.")]
        public decimal Litros { get; set; }
        public decimal MassaCombustivel => Litros * 0.72M;
    }
}
