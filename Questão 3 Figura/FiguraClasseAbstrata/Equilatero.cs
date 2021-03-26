using System;
using System.Collections.Generic;
using System.Text;

namespace FiguraClasseAbstrata
{
    class Equilatero:  Figura, IControle, ISuperficie
    {
        public Equilatero(double x) : base(x) { }

        public override double CalcularArea()
        {
            return Math.Pow(X, 2) * Math.Sqrt(3) /4;
        }

        public override double CalcularPerimetro()
        {
            return 3 * X;
        }
        public void Desenhar()
        {
            Console.WriteLine("Equilatero desenhado.");
        }

        public void Pintar()
        {
            Console.WriteLine("Equilatero pintado.");
        }
        public override string ToString()
        {
            return "Equilatero\n" + base.ToString();
        }
    }
}
