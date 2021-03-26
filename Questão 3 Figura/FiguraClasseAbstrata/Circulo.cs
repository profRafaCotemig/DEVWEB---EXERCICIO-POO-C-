using System;
using System.Collections.Generic;
using System.Text;

namespace FiguraClasseAbstrata
{
    class Circulo: Figura

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

    }
}
