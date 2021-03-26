using System;
using System.Collections.Generic;
using System.Text;

namespace FiguraClasseAbstrata
{
    class Quadrado: Figura
    {
        public Quadrado(double x) : base(x) { }

        public override double CalcularArea()
        {
            return Math.Pow(X, 2);
        }

        public override double CalcularPerimetro()
        {
            return 4 * X;
        }
        public void Desenhar()
        {
            Console.WriteLine("Quadrado desenhado.");
        }

        public void Pintar()
        {
            Console.WriteLine("Quadrado pintado.");
        }

        public override string ToString()
        {
            return "Quadrado\n" + base.ToString();
        }

    }
}
