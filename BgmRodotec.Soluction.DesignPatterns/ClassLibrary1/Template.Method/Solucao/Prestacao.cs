using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.DesignPatterns.Comportamentais.Template.Method.Solucao
{
    public abstract class Prestacao
    {
        protected decimal _valorPrincipal;
        protected decimal _valorDaTaxaAdministrativa;
        protected decimal _valorDoSeguro;

        public decimal Calcular(decimal valorTotal, int numeroDeParcelas)
        {
            CalcularValorPrincipal(valorTotal, numeroDeParcelas);
            CalcularValorDaTaxaAdministrativa();
            CalcularValorDoSeguro();
            return CalcularValorTotal();
        }

        protected virtual void CalcularValorPrincipal(decimal valorTotal, int numeroDeParcelas)
        {
            _valorPrincipal = valorTotal / numeroDeParcelas;
        }

        protected abstract void CalcularValorDaTaxaAdministrativa();
        protected abstract void CalcularValorDoSeguro();

        protected virtual decimal CalcularValorTotal()
        {
            return _valorPrincipal + _valorDaTaxaAdministrativa + _valorDoSeguro;
        }
    }
}
