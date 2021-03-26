using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    class Baleia: Mamifero
    {
        public Baleia(string nome): base(nome) { }
        public string Nadar() { return "Animal nadou!"; } 
    }
}
