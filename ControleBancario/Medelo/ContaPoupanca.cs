using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class ContaPoupanca : Conta
    {
        public DateTime DataDeAniversario { get; set; }

        public ContaPoupanca(int numero, double saldo)
        {
            Numero = numero;
            Saldo = saldo;
            DataDeCriacao = DateTime.Now;
        }

        public double CalcularRendimento()
        {
            return Saldo * 0.05;
        }
    }
}
