using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public sealed class ContaCorrente : Conta
    {
        public ContaCorrente(int numero) : base(numero)
        {
        }

        public ContaCorrente(int numero, double saldo) : base(numero)
        {
            Saldo = saldo;
        }        

        public override bool Sacar(double valo)
        {
            var valorMaior = Saldo > valo;
            if (valorMaior)
                Saldo -= (valo + 0.1);

            return valorMaior;
        }
    }
}
