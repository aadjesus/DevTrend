using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo.Polimorfismo
{
    public class Fisica : Pessoa
    {
        public string Cpf { get; set; }

        public override bool ValidarDocumento()
        {
            return Cpf.Length == 11;
        }
    }
}
