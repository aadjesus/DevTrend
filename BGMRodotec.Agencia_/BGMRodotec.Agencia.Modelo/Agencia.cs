using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BGMRodotec.Agencia.Modelo
{
    public class Agencia
    {
        public string Nome { get; set; }
        public List<Telefone> Telefones { get; set; }
        public Endereco Endereco { get; set; }
        public List<Conta> Contas { get; set; }
        public string Numero { get; set; }
        public string Digito { get; set; }
    }
}
