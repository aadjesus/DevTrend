using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Forma
    {
        protected int largura, altura;

        public Forma(int a = 0, int b = 0)
        {
            largura = a;
            altura = b;
        }
        public virtual int Area()
        {
            Console.WriteLine("Área da forma :");
            return 0;
        }

        public static void Calcular(Forma formar)
        {
            int area = formar.Area();
            Console.WriteLine("Área: {0}", area);
        }

    }
}
