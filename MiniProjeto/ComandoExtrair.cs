using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjeto
{
    public class ComandoExtrair : Comandos
    {

        public bool Extraindo { get; set; }

        public ComandoExtrair(Robo robo) : base(robo) { }

        public override void Executar()
        {
            _robo.Extrair(Extraindo);
        }
    }
}
