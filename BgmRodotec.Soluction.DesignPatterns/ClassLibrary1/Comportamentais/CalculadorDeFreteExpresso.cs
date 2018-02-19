using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.DesignPatterns.Comportamentais.Comportamentais

{
    class CalculadorDeFreteExpresso : ICalculadorDeFrete
    {
        public decimal CalcularFrete(decimal valor)
        {
            return valor;
        }
    }
}
