﻿using System;
using System.Globalization;
using HerancaVsInterface.Enums;

namespace HerancaVsInterface.Entities
{
    class Retangulo : Forma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public override double Area()
        {
            return Largura * Altura;
        }

        public override string ToString()
        {
            return "Cor do Retangulo =" + cor + ", largura = "
                + Largura.ToString("F2", CultureInfo.InvariantCulture)
                + ", altura = "
                + Altura.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Altura.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
