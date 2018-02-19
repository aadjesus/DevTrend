using BgmRodotec.Agencia.Negocio._1_LSP.Ex1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.Agencia.Negocio
{
    public abstract class Carro : ICarro
    {
        public abstract void Ignicao();

        public abstract void Acelerar();
    }
}
