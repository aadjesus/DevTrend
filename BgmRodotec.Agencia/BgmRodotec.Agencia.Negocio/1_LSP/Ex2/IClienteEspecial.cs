using BgmRodotec.Agencia.Negocio.LSP.Ex2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.Agencia.Negocio._1_LSP.Ex2
{
    public class IClienteEspecial : IClienteBase
    {
        public int ClienteId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public TipoCliente TipoCliente { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public decimal CalcularDesconto(decimal valor, TipoCliente tipocliente)
        {
            throw new NotImplementedException();
        }
    }
}
