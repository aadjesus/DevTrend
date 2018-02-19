using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.Agencia.Negocio.LSP.Ex2
{
    public abstract class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public TipoCliente TipoCliente { get; set; }
        public abstract bool ClienteEspecial();
        public abstract decimal CalcularDesconto(decimal valor, TipoCliente tipocliente);
    }
}
