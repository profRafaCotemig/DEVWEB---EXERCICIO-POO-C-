using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    class Animal

    {
        private string nome;

        public Animal(string nome) {
            this.Nome = nome;
        }

        public string Nome { get => nome; set => nome = value; }

        public string Acordar(){ 
            return "Animal acordou!"; 
        }
        public string Dormir() { 
            return "Animal dormiu!"; 
        }
        public string Comer() { 
            return "Animal comeu!"; 
        }
    }
}
