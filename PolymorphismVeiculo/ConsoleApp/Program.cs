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
            var veiculos = new List<Veiculo>();
            veiculos.Add(new Automovel("Ferrari"));
            veiculos.Add(new Aeronave("Tucano"));

            foreach (var veiculo in veiculos)
            {
                Console.WriteLine(veiculo.Tipo);
                for (int i = 0; i < 5; i++)
                    veiculo.Mover(i);

                veiculo.Parar();
            }
            
            Console.ReadKey();
        }        
    }
}
