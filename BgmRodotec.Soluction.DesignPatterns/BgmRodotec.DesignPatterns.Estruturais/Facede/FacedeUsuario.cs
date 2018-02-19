using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.DesignPatterns.Estruturais.Facede
{
    public class FacedeUsuario
    {
        private IValidarUsuario _validarUsuario;
        private ISalvarUsuario _salvarUsuario;
        private IEnviarEmailUsuarioAtivo _enviarEmailUsuarioAtivo;

        public void SalvarUSuario(UsuarioModel usuario)
        {
            var validar = new ValidarUsuario();
            var retorno = validar.Validar(usuario);

            var salvo = new SalvarUsuario();
            var retornoSalvar = salvo.Salvar(usuario);

            var enviarEmail = new EnviarEmailUsuarioAtivo();
            enviarEmail.EnviarEmail(usuario);
        }
        
    }
}
