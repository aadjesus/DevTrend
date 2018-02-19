using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo.Heranca
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public void EscreverNome()
        {
            Console.Write(Nome);
        }
    }
}
