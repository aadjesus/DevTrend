using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BGMRodotec.Agencia.RegraDeNegocio
{
    public class AgenciaNegocio
    {
        public Retorno ValidarNegocio(Modelo.Agencia agencia)
        {
            var retorno = new Retorno() { Sucesso = true };
            retorno.Mensagens = new List<string>();
            if (string.IsNullOrEmpty(agencia.Numero))
            {
                retorno.Sucesso = false;
                retorno.Mensagens.Add("Preencha o numero da agencia");
            }
            
            if (!agencia.Telefones.Any())
            {
                retorno.Sucesso = false;
                retorno.Mensagens.Add("Preencha peslo menus um telefone");
            }

            if (!retorno.Sucesso)
            {
                return retorno;
            }

            retorno.Sucesso = new AcessoDados2.AgenciaAcessoDados().Salvar(agencia);
            if (retorno.Sucesso)
            {
                retorno.Mensagens.Add("Salvo com sucesso");
            }
            else
            {
                retorno.Mensagens.Add("Erro ao salver");
            }

            return retorno;
        }
    }
}
