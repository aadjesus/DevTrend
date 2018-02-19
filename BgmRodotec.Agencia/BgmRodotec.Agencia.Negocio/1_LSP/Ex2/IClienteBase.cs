using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.Agencia.Negocio.LSP.Ex2
{
    public interface IClienteBase
    {
        int ClienteId { get; set; }
        string Nome { get; set; }
        TipoCliente TipoCliente { get; set; }
        decimal CalcularDesconto(decimal valor, TipoCliente tipocliente);
    }
}
