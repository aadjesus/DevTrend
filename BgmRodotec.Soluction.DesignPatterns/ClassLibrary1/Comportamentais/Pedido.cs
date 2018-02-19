using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.DesignPatterns.Comportamentais.Comportamentais
{
    public class Pedido
    {
        private decimal distancia = 10;
        private ICalculadorDeFrete _calculadorDeFrete;
        
        public Pedido(ICalculadorDeFrete calculadorDeFrete)
        {
            _calculadorDeFrete = calculadorDeFrete;
        }

        public decimal CalcularFrete()
        {
            return _calculadorDeFrete.CalcularFrete(distancia);
        }
    }
}
