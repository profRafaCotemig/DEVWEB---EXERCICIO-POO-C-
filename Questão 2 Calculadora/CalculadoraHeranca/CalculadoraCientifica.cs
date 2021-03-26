using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraHeranca
{
    class CalculadoraCientifica: Calculadora
    {
        public static double CalculaRaizQuadrada(double x) { 
            return Math.Sqrt(x); 
        }
    }
}
