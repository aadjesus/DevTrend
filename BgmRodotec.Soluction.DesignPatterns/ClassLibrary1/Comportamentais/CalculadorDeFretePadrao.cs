using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.DesignPatterns.Comportamentais.Comportamentais

{
    public class CalculadorDeFretePadrao : ICalculadorDeFrete
    {
        public decimal CalcularFrete(decimal valor)
        {
            return valor;
        }
    }
}
