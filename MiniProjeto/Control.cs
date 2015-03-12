using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjeto
{
    public class Control
    {
        public Queue<Comandos> comandos;

        public Control()
        {
            comandos = new Queue<Comandos>();   
        }

        public void ExecuteComandos()
        {
            Console.WriteLine("Executando Comando(s).");
            while(comandos.Count > 0)
            {
                Comandos comando = comandos.Dequeue();
                comando.Executar(); 
            }
            Console.WriteLine("Comando(s) executado(s) com sucesso.");
        }
    }
}
