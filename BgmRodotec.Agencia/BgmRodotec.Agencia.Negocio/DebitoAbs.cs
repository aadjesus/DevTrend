using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.Agencia.Negocio
{
    public abstract class DebitoAbs
    {
        public abstract Retorno Debitar(int valor);
    }
}
