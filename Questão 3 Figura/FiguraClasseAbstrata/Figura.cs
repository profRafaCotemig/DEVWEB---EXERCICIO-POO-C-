using System;
using System.Collections.Generic;
using System.Text;

namespace FiguraClasseAbstrata
{
    abstract class Figura
    {
        private double x;

        public Figura(double x)
        {
            this.X = x;
        }

        public double X { get => x; set => x = value; }

        public abstract double CalcularArea();

        public abstract double CalcularPerimetro();

        public override string ToString()
        {
            return String.Format("Medida: {0}\nÁrea: {1}\nPerímetro: {2}\n", X, CalcularArea(), CalcularPerimetro());
        }
    }
}
