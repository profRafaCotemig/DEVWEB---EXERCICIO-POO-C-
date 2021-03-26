using System;
using System.Collections.Generic;
using System.Text;

namespace FiguraClasseAbstrata
{
    class Hexagono: Figura, IControle, ISuperficie
    {
        public Hexagono(double x) : base(x) { }

        public override double CalcularArea()
        {
            return 3 * Math.Pow(X, 2) * Math.Sqrt(3) / 2;
        }

        public override double CalcularPerimetro()
        {
            return 6 * X;
        }
        public void Desenhar()
        {
            Console.WriteLine("Hexagono desenhado.");
        }

        public void Pintar()
        {
            Console.WriteLine("Hexagono pintado.");
        }
    }
}
