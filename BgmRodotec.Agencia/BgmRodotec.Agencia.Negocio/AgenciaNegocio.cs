using BgmRodotec.Agencia.AcessoDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.Agencia.Negocio
{
    public class AgenciaNegocio
    {
        public Retorno ValidarNegocio(Modelos.Agencia agencia)
        {
            var retorno = new Retorno();
            retorno.Sucesso = true;
            retorno.Mensagens = new List<string>();
            AgenciaAcessoDados acessoDados = new AgenciaAcessoDados();

            if (string.IsNullOrEmpty(agencia.Numero))
            {
                retorno.Sucesso = false;
                retorno.Mensagens.Add("Preencha numero da agencia");
            }

            if (!agencia.Telefones.Any())
            {
                retorno.Sucesso = false;
                retorno.Mensagens.Add("Preencha pelo menos um telefone!");
            }

            if (!retorno.Sucesso)
                return retorno;

            retorno.Sucesso = acessoDados.Salvar(agencia);
            if (retorno.Sucesso)
            {
                retorno.Mensagens.Add("Salvo com sucesso");
            }
            else
            {
                retorno.Mensagens.Add("Erro ao salvar");
            }

            return retorno;
        }
    }
}
