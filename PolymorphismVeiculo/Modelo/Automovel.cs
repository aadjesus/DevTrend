using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Automovel : Veiculo
    {
        public Automovel(string tipoVeiculo) : base(tipoVeiculo)
        { }

        public override void Mover(int velocidade)
        {
            Console.WriteLine("Acelerando o veículo: " + velocidade);
        }
        public override void Parar()
        {
            Console.WriteLine("Freando veículo.");
        }
    }
}
