using System;

namespace CalculadoraHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculadora.Somar(2,4));
            Console.WriteLine(Calculadora.Somar(2, 4));
            Console.WriteLine(CalculadoraCientifica.CalculaRaizQuadrada(2).ToString("N4"));
            Console.ReadKey();
        }
    }
}
