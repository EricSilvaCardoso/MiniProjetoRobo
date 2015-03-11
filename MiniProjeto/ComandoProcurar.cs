using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjeto
{
    public class ComandoProcurar : Comandos
    {
        public bool Procurando { get; set; }

        public ComandoProcurar(Robo robo) : base(robo) { }

        public override void Executar()
        {
            _robo.Procurar(Procurando);
        }
    }
}
