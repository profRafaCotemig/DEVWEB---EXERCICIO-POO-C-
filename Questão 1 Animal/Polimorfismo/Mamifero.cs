using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    class Mamifero: Animal
    {

        public Mamifero(string nome): base(nome) { 
        }
        public string Mamar() {
            return "Animal mamou!"; 
        }
    }
}
