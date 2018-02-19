using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.DesignPatterns.Comportamentais.Template.Method.Solucao
{
    public class PrestacaoContratoPadrao : Prestacao
    {
        protected override void CalcularValorDaTaxaAdministrativa()
        {
            _valorDaTaxaAdministrativa = _valorPrincipal * 0.01m;
        }

        protected override void CalcularValorDoSeguro()
        {
            _valorDoSeguro = _valorPrincipal * 0.015m;
        }
    }
}
