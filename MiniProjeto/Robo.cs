using System;
using System.Threading;

namespace MiniProjeto
{
    public class Robo
    {
        public void Andar(bool Andando)
        {
            if (Andando)
                Console.WriteLine("O Robo esta andando por 15 segundos");
            Thread.Sleep(TimeSpan.FromSeconds(15));
        }      

        public void Procurar(bool procurando)
        {
            if  (procurando)
                Console.WriteLine("O Robo esta procurando por 25 segundos ");
            Thread.Sleep(TimeSpan.FromSeconds(25));
        }

        public void Extrair(bool extraindo)
        {
            if (extraindo)
                Console.WriteLine("O Robo esta Extraindo por 30 segundos ");
            Thread.Sleep(TimeSpan.FromSeconds(30));   
        }

        
    }

}
