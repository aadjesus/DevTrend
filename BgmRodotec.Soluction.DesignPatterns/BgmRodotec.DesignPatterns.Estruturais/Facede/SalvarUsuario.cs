using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.DesignPatterns.Estruturais.Facede
{
    public class SalvarUsuario : ISalvarUsuario
    {
        private ISalvarUsuario _salvarUsuario;

        public SalvarUsuario(ISalvarUsuario salvarUsuario)
        {
            _salvarUsuario = salvarUsuario;
        }

        public bool Salvar(UsuarioModel usuario)
        {
            return true;
        }
    }
}
