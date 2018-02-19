using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Conta
    {
        public static int TotalDeContas { get; private set; }

        public static int RetornarTotalDeContas()
        {
            return TotalDeContas;
        }

        public Conta(int numero, double saldo)
        {
            Numero = numero;
            Saldo = saldo;
            DataDeCriacao = DateTime.Now;
            TotalDeContas++;
        }

        public Conta(int numero, double saldo, DateTime dataDeCriacao, string nomeDoCliente)
        {
            Numero = numero;
            Saldo = saldo;
            DataDeCriacao = dataDeCriacao;
            Cliente = new Cliente
            {
                Nome = nomeDoCliente
            };
            TotalDeContas++;
        }


        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public DateTime DataDeCriacao { get; set; }
        public Cliente Cliente { get; set; }

        public bool Sacar(double valorDeSaque)
        {
            if (valorDeSaque > Saldo)
                return false;

            Saldo = Saldo - valorDeSaque;
            return true;
        }
    }
}
