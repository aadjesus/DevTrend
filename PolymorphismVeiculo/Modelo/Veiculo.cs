using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Veiculo
    {
        public string Tipo { get; set; }

        public Veiculo(string tipoVeiculo)
        {
            Tipo = tipoVeiculo;
        }
        public virtual void Mover(int velocidade)
        { }

        public virtual void Parar()
        { }
    }
}
