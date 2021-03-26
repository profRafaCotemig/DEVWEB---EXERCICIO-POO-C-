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
            return String.Format("TIPO: {0}\n\tMedida: {1}\n\tÁrea: {2}\n\tPerímetro: {3}\n", GetType().Name, X, CalcularArea(), CalcularPerimetro());
        }
    }
}
