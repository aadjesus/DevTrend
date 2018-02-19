using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.Agencia.Modelos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public Endereco Endereco { get; set; }
        public List<Telefone> Telefones { get; set; }
        public Conta Conta { get; set; }
    }
}
