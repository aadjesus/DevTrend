using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public abstract class Conta : IConta
    {
        public Conta(int numero)
        {
            Numero = numero;
            DataDeCriacao = DateTime.Now;
        }

        public int Numero { get; set; }

        public double Saldo { get; protected set; }

        public DateTime DataDeCriacao { get; private set; }

        public virtual void Despositar(double valo)
        {
            Saldo += valo;
        }

        public virtual bool Sacar(double valo)
        {
            var valorMaior = Saldo > valo;
            if (valorMaior)
                Saldo -= valo;

            return valorMaior;
        }

        public static void ImprimirExtrato(Conta conta)
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Data: " + DateTime.Now);
            Console.WriteLine("Numero: " + conta.Numero);
            Console.WriteLine("Saldo: " + conta.Saldo);
            Console.WriteLine("----------------------------------------------");

        }

    }
}
