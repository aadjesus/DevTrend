using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var formas = new List<Forma>();
            formas.Add(new Retangulo(10, 7));
            formas.Add(new Triangulo(10, 5));

            foreach (var forma in formas)
                Forma.Calcular(forma);
            

            Console.ReadKey();
        }
    }
}
