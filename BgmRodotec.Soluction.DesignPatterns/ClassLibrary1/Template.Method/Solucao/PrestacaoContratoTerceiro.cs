using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.DesignPatterns.Comportamentais.Template.Method.Solucao
{
    public class PrestacaoContratoTerceiro : Prestacao
    {
        protected override void CalcularValorDaTaxaAdministrativa()
        {
            _valorDaTaxaAdministrativa = _valorPrincipal * 0.11m;
        }

        protected override void CalcularValorDoSeguro()
        {
            _valorDoSeguro = _valorPrincipal * 0.815m;
        }
    }
}
