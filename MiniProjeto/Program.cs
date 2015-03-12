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

            robo.status = Status.Pronto;

            string[] script = new string[] { "A", "A","P","P", "A","P","P" };

            Console.WriteLine("Lendo Script de Comandos");

            for (int i = 0; i < script.Length; i++)
            {
                if (script[i] == "A")
                {
                    ComandoAndar andar = new ComandoAndar(robo);
                        andar.Andando = true;
                        controle.comandos.Enqueue(andar);
                }

                else if (script[i] == "P")
                {
                    ComandoProcurar procurar = new ComandoProcurar(robo);
                        procurar.Procurando = true;
                        controle.comandos.Enqueue(procurar);

                        ComandoExtrair extrair = new ComandoExtrair(robo);
                        extrair.Extraindo = true;
                        controle.comandos.Enqueue(extrair);
                }
               
                    
             
            }

            controle.ExecuteComandos();

            Console.ReadKey();

        }
    }
}
