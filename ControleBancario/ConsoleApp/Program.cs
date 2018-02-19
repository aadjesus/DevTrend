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

            var contas = new List<IConta>();
            contas.Add(new ContaCorrente(10, 100));
            contas.Add(new ContaPoupanca(20, 200));
            foreach (var conta in contas)
            {
                Console.WriteLine("Conta");
                Console.WriteLine("Numero: " + conta.Numero);
                Console.WriteLine("Data: " + conta.DataDeCriacao);
                Console.WriteLine("Saldo: " + conta.Saldo);

            }



            //var conta1 = new ContaCorrente(10, 100);

            //Console.WriteLine("Conta 1");
            //Console.WriteLine("Numero: " + conta1.Numero);
            //Console.WriteLine("Data: " + conta1.DataDeCriacao);
            //Console.WriteLine("Saldo: " + conta1.Saldo);

            //var saldoOk = conta1.Sacar(10);
            //Console.WriteLine("Saque ok: " + saldoOk);
            //Conta.ImprimirExtrato(conta1);
            //Console.ReadKey();
            

            //saldoOk = conta1.Sacar(90);
            //Console.WriteLine("Saque ok: " + saldoOk);
            //Console.WriteLine("Saldo: " + conta1.Saldo);
            //Console.ReadKey();


            //Console.WriteLine("");

            //var conta2 = new ContaPoupanca(20, 200);
            


            //Console.WriteLine("Conta 2");
            //Console.WriteLine("Numero: " + conta2.Numero);
            //Console.WriteLine("Data: " + conta2.DataDeCriacao);
            //Console.WriteLine("Saldo: " + conta2.Saldo);
            //Console.WriteLine("Rendimento: " + conta2.CalcularRendimento());

            

            Console.ReadKey();
        }
    }
}
