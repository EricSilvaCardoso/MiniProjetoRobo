using System.Threading;

namespace MiniProjeto
{
    public class ComandoAndar : Comandos
    {
        public bool Andando { get; set; }

        public ComandoAndar(Robo robo) : base(robo){}

        
        public override void Executar()
        {
            _robo.Andar(Andando);
        }
    }
}
