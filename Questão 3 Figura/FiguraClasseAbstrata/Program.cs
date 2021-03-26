using System;

namespace FiguraClasseAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            Pentagono p = new Pentagono(4);
            Console.WriteLine(p.ToString());
            Console.ReadKey();
        }
    }
}
