using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public interface IConta
    {
        int Numero { get; set; }

        double Saldo { get; }

        DateTime DataDeCriacao { get; }

        bool Sacar(double valo);

        void Despositar(double valo);
    }
}
