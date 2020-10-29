using System;
using System.Globalization;
using HerancaVsInterface.Enums;

namespace HerancaVsInterface.Entities
{
    class Circulo : Forma
    {
        public double Raio { get; set; }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }

        public override string ToString()
        {
            return "Cor do Círculo =" + cor + ", raio = " 
                + Raio.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = " 
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
