using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjeto
{
    public abstract class Comandos
    {
        protected Robo _robo;

        public Comandos(Robo robo)
        {
            _robo = robo;
        }
        public abstract void Executar();
    }
}
