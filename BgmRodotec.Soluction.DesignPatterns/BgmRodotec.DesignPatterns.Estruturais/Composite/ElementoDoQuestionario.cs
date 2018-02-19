using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.DesignPatterns.Estruturais.Composite
{
    public abstract class ElementoDoQuestionario
    {
        protected string Descricao;

        protected ElementoDoQuestionario(string descricao)
        {
            Descricao = descricao;
        }

        public abstract void Exibir();
    }
}
