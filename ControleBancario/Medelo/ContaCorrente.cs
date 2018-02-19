using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int numero, double saldo)
        {
            Numero = numero;
            Saldo = saldo;
            DataDeCriacao = DateTime.Now;
        }

        public override bool Sacar(double valorDeSaque)
        {
            var saldoMaior = Saldo > valorDeSaque;
            if (saldoMaior)
                Saldo = Saldo - valorDeSaque - 0.1;

            return saldoMaior;            
        }
    }
}
