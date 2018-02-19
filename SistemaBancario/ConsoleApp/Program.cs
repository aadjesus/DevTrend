using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var contaJoao = new Conta(100, 2000, DateTime.Now, "Teste");

            Console.WriteLine("contaJoao");
            Console.WriteLine("Numero :" + contaJoao.Numero);
            Console.WriteLine("Saldo :" + contaJoao.Saldo);
            Console.WriteLine("Data :" + contaJoao.DataDeCriacao);
            Console.WriteLine("Cliente :" + contaJoao.Cliente.Nome);
            Console.ReadKey();

            var retornoSaque = contaJoao.Sacar(10);
            if (retornoSaque)
                Console.WriteLine("Saldo OK: " + contaJoao.Saldo);
            else
                Console.WriteLine("Saldo :" + contaJoao.Saldo);

            var contaMaria = new Conta(10, 100);
            Console.WriteLine("contaMaria");
            Console.WriteLine("Numero :" + contaMaria.Numero);
            Console.WriteLine("Saldo :" + contaMaria.Saldo);
            Console.WriteLine("Data :" + contaMaria.DataDeCriacao);

            Console.ReadKey();
            Console.WriteLine("Total: " + Conta.TotalDeContas);
            Console.WriteLine("Total: " + Conta.RetornarTotalDeContas());
            Console.ReadKey();
        }
    }
}
