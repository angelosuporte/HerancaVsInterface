using System;
using HerancaVsInterface.Entities;
using HerancaVsInterface.Enums;

namespace HerancaVsInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IForma s1 = new Circulo() { Raio = 2.0, Cor = Cor.White };
            IForma s2 = new Retangulo() { Largura = 3.5, Altura = 4.2, Cor = Cor.Black };
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.ReadKey();
        }
    }
}
