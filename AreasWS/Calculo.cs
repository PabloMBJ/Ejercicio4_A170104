using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AreasWS
{
    public class Calculos
    {
        public decimal lado { get; set; }
        public decimal altura { get; set; }
        public decimal radio { get; set; }

        public decimal Cuadrado(decimal lado)
        {
            return lado * lado;
        }

        public decimal Triangulo (decimal lado, decimal altura)
        {
            return (lado * altura) / 2;
        }

        public decimal Circulo(decimal radio)
        {
            var view = Math.PI * Math.Pow(Convert.ToDouble(radio), 2);
            return Convert.ToDecimal(view);
        }
    }
}