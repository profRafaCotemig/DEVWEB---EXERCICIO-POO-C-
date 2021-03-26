using System;
using System.Collections.Generic;
using System.Text;

namespace FiguraClasseAbstrata
{
    class Circulo: Figura, IControle, ISuperficie

    {
        public Circulo(double x) : base(x) { }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(X, 2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * X;
        }
        public void Desenhar() {
            Console.WriteLine("Circulo desenhado.");
        }

        public void Pintar() {
            Console.WriteLine("Circulo pintado.");
        }
        public override string ToString()
        {
            return "Circulo\n" + base.ToString();
        }
    }
}
