using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.Agencia.Negocio.LSP.Ex2
{
    public class PossivelCliente: IClienteBase
    {
        public int PossivelClienteId { get; set; }
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public TipoCliente TipoCliente { get; set; }

        public decimal CalcularDesconto(decimal valor, TipoCliente tipoCliente)
        {
            switch (tipoCliente)
            {
                case TipoCliente.Gold:
                    return valor * 0.40m; //desconto de 60%
                case TipoCliente.Silver:
                    return valor * 0.80m; //Desconto de 20%
                default:
                    return valor;
            }
        }
        
    }
}
