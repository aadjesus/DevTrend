using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo.Encapsulamento
{
    public abstract class Pessoa : IValidador
    {
        public string Nome { get; set; }

        public void EscreverNome()
        {
            Console.Write(Nome);
        }
        public virtual bool ValidarDocumento()
        {
            throw new NotImplementedException();
        }
    }
}
