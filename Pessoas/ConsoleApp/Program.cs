using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Modelo.Abstracao.Pessoa()
            {
                Nome = "Teste"
            };
            Console.WriteLine(pessoa.Nome);
            Console.Read();

        }
    }
}
