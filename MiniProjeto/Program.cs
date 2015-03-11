using System;
using System.Threading;

namespace MiniProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Robo robo = new Robo();
            Control controle = new Control();

            
            ComandoAndar andar = new ComandoAndar(robo);
            andar.Andando = true;
            controle.comandos.Enqueue(andar);

            ComandoAndar andar1 = new ComandoAndar(robo);
            andar1.Andando = true;
            controle.comandos.Enqueue(andar1);

            ComandoProcurar procurar = new ComandoProcurar(robo);
            procurar.Procurando = true;
            controle.comandos.Enqueue(procurar);

            ComandoExtrair extrair = new ComandoExtrair(robo);
            extrair.Extraindo = true;
            controle.comandos.Enqueue(extrair);

            controle.ExecuteComandos();

            Console.ReadKey();

        }
    }
}
