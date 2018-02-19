using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Triangulo : Forma
    {
        public Triangulo(int a = 0, int b = 0) : base(a, b)
        {
        }

        public override int Area()
        {
            Console.WriteLine("Área do Triangulo :");
            return altura * largura / 2;
        }
    }
}
