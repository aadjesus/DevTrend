using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.DesignPatterns.Estruturais.Facede
{
    public class ValidarUsuario : IValidarUsuario
    {
        private IValidarUsuario _validarUsuario;

        public ValidarUsuario(IValidarUsuario validarUsuario)
        {
            _validarUsuario = validarUsuario;
        }

        public bool Validar(UsuarioModel usuario)
        {
            return !string.IsNullOrEmpty(usuario.Nome);
        }
    }
}
