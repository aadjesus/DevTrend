using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.Agencia.Negocio
{
    public class SaldoContaCorrente
    {
        private int SaldoConta = 100;
        public bool ValidarSaldo(int valor)
        {
            if (valor > SaldoConta)
                return false;
            return SaldoConta < valor;
        }
    }
}
