using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.Agencia.Negocio._3_DIP.SolucaoCorreta
{
    public class ClasseTrabalhoDip
    {
        public ILog Log { get; }

        public ClasseTrabalhoDip(ILog log)
        {
            Log = log;
        }

        public void MetodoTrabalho()
        {
            // lógica do log
            Log.EscreveLog();
            // lógica do método em si
        }
    }
}
