using BgmRodotec.DesignPatterns.Comportamentais;
using BgmRodotec.DesignPatterns.Comportamentais.Comportamentais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pedido = new Pedido(new CalculadorDeFretePadrao());

            Console.WriteLine(pedido.CalcularFrete());
        }
    }
}
