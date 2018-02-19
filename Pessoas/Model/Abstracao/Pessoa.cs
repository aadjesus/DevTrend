using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo.Abstracao
{
    public class Pessoa
    {
        public string Nome { get; set; }

        // Idade
        // Cor


        public void EscreverNome()
        {
            Console.Write(Nome);
        }

    }
}
