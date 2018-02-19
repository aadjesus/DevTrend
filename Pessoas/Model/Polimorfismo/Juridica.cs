using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo.Polimorfismo
{
    public class Juridica : Pessoa
    {
        public string Cnpj { get; set; }

        public override bool ValidarDocumento()
        {
            return Cnpj.Length == 14;
        }
    }
}
