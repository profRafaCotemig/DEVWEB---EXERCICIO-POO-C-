using System;

namespace FiguraClasseAbstrata
{
    class Pentagono: Figura, IControle, ISuperficie
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
        public void Desenhar()
        {
            Console.WriteLine("Pentagono desenhado.");
        }

        public void Pintar()
        {
            Console.WriteLine("Pentagono pintado.");
        }
        public override string ToString()
        {
            return "Pentagono\n" + base.ToString();
        }
    }
}
