using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo.Heranca
{
    public class Fisica : Pessoa
    {
        public string Cpf { get; set; }

        public Boolean ValidarCpf()
        {
            return Cpf.Length == 11;
        }
    }
}
