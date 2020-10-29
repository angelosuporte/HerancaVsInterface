using HerancaVsInterface.Enums;

namespace HerancaVsInterface.Entities
{
    abstract class Forma
    {
        public Cor cor { get; set; }
        public abstract double Area();
    }
}
