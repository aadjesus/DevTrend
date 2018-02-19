using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public sealed class ContaPoupanca : Conta
    {
        public ContaPoupanca(int numero) : base(numero)
        {            
        }

        public ContaPoupanca(int numero, double saldo) : base(numero)
        {
            Saldo = saldo;
        }

        public double CalcularRendimento()
        {
            return Saldo * 0.05;
        }
    }
}
