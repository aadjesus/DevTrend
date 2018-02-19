using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.Agencia.Negocio
{
    public class Camaro: Carro
    {
        public override void Ignicao()
        {
            System.Console.WriteLine("Ignicao....");
            System.Console.ReadLine();
        }

        public override void Acelerar()
        {
            System.Console.WriteLine("Acelerar....");
            System.Console.ReadLine();
        }

        public void Turbo()
        {
            System.Console.WriteLine("Turbo....");
            System.Console.ReadLine();
        }
    }
}
