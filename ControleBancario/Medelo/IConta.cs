using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public interface IConta
    {
        bool Sacar(double valorDeSaque);

        void Depositar(double valorDeDeposito);

    }
}
