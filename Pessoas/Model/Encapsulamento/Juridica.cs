using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo.Encapsulamento
{
    public class Juridica : Pessoa
    {
        public string Cnpj { get; set; }
        private int _tamanho = 14;

        public override bool ValidarDocumento()
        {
            return Cnpj.Length == _tamanho;
        }
    }
}
