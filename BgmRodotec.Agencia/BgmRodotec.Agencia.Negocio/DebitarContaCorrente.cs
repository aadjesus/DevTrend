using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.Agencia.Negocio
{
    public class DebitarContaCorrente
    {
        private int SaldoConta = 100;

        public Retorno DebitarConta(int valor)
        {
            var retorno = new Retorno();
            retorno.Mensagens = new List<string>();

            if (valor > SaldoConta)
            {
                retorno.Sucesso = false;
                retorno.Mensagens.Add("Saldo insuficiente");
                return retorno;
            }

            retorno.Sucesso = true;
            retorno.Mensagens.Add("Sucesso");

            SaldoConta -= valor;

            return retorno;
        }
    }
}
