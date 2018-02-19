using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.DesignPatterns.Estruturais.Facede
{
    public class EnviarEmailUsuarioAtivo : IEnviarEmailUsuarioAtivo
    {
        private IEnviarEmailUsuarioAtivo _enviarEmailUsuarioAtivo;
        public EnviarEmailUsuarioAtivo(IEnviarEmailUsuarioAtivo enviarEmailUsuarioAtivo)
        {
            _enviarEmailUsuarioAtivo = enviarEmailUsuarioAtivo;
        }

        public void EnviarEmail(UsuarioModel usuario)
        {
            ///aqui envia o email;
        }
    }
}
