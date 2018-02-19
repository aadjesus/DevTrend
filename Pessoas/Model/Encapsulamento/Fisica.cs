using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo.Encapsulamento
{
    public class Fisica : Pessoa
    {
        public string Cpf { get; set; }

        private int _tamanho = 11;

        public override bool ValidarDocumento()
        {
            return Cpf.Length == _tamanho;
        }
    }
}
