using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crie uma classe Animal, 
             * com três métodos (Acordar(), Comer(), Dormir()) e uma propriedade (Nome). 
             * No corpo de cada método imprima “Animal acordou”, “Animal comeu”, “Animal dormiu”, 
             * respectivamente.
            Crie uma classe Mamifero, que herda de Animal e que possui o método Mamar().
            Crie, ainda, as classes Morcego (que possui o método Voar()) e 
            Baleia (que possui o método Nadar()), derivadas de Mamifero.

             */

            Animal a = new Animal("Cavalo");

            var baleia = new Baleia("Jubarte");

            Console.WriteLine(baleia.Acordar());

            Console.WriteLine(baleia.Mamar());

            Console.ReadKey();
        }


    }
}
