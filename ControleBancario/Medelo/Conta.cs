using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Conta : IConta
    {
        private static int totalDeContas = 0;

        public static int ProximaConta()
        {
            return totalDeContas + 1;
        }

        public static int TotalDeContas()
        {
            return totalDeContas;
        }

        public static void ImprimeExtrato(Conta conta)
        {
            Console.WriteLine("Número: " + conta.Numero);
            Console.WriteLine("Saldo: " + conta.Saldo);
        }

        public int Numero { get; set; }

        public double Saldo { get; protected set; }

        public DateTime DataDeCriacao { get; set; }

        public Conta()
        {
            totalDeContas++;
        }

        public virtual bool Sacar(double valorDeSaque)
        {
            var saldoMaior = Saldo > valorDeSaque;
            if (saldoMaior)
                Saldo = Saldo - valorDeSaque;

            return saldoMaior;
        }

        public void Depositar(double valorDeDeposito)
        {
            Saldo += valorDeDeposito;
        }
    }
}
