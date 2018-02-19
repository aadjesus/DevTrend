using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.DesignPatterns.Estruturais.Facede
{
    public interface ISalvarUsuario
    {
        bool Salvar(UsuarioModel usuario);
    }
}
