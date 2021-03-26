using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    class Morcego: Mamifero
    {
        public Morcego(string nome): base(nome) { }
        public string Voar() { return "Animal voou!"; }
    }
}
