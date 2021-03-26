using System;

namespace FiguraClasseAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            Equilatero e = new Equilatero(12);
            Pentagono p = new Pentagono(4);

            Console.WriteLine(e.CalcularArea());
            Console.WriteLine(p.CalcularArea());
        }
    }
}
