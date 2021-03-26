using System;

namespace FiguraClasseAbstrata
{
    class Pentagono: Figura
    {
        public Pentagono(double x) : base(x) { }

        public override double CalcularArea()
        {
            var a = 2 / Math.Tan(36 * Math.PI / 180);
            
            return a * CalcularPerimetro()/2 ;
        }

        public override double CalcularPerimetro()
        {
            return 5 * X;
        }
    }
}
