using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Aeronave : Veiculo
    {
        public Aeronave(string tipoVeiculo)
          : base(tipoVeiculo)
        { }

        public override void Mover(int velocidade)
        {
            Console.WriteLine("Decolando aeronave: " + velocidade);
        }
        public override void Parar()
        {
            Console.WriteLine("Aterrisando aeronave.");
        }
    }
}
