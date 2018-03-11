using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _07_AutoManual
{
    class Program
    {
        static ManualResetEvent Manual01;
        static AutoResetEvent Auto01; // Executa o Reset Automaticamente após o Set.


        static void Main(string[] args)
        {
            Manual01 = new ManualResetEvent(false); //Sinal Vermelho
            Thread t1 = new Thread(Executa01);
            t1.Start();

            Thread t2 = new Thread(Executa02);
            t2.Start();

            Thread.Sleep(5000);
            Manual01.Set(); // Sinal Verde
            Manual01.Reset(); // Sinal Vermelho Novamente
            
            
            Console.ReadKey();
        }

        static void Executa01()
        {
            Console.WriteLine("01 - Iniciado \"Executa 01\"");
            Manual01.WaitOne(); // Sinal Vermelho
            Console.WriteLine("02 - Execução 01 \"Executa 01\"");
            Console.WriteLine("03 - Execução 02 \"Executa 01\"");
            Console.WriteLine("04 - Finalizado \"Executa 01\"");

        }
        static void Executa02()
        {
            Console.WriteLine("01 - Iniciado \"Executa 02\"");
            Console.WriteLine("02 - Execução 01 \"Executa 02\"");
            Console.WriteLine("03 - Execução 02 \"Executa 02\"");
            Console.WriteLine("04 - Finalizado \"Executa 02\"");
        }

    }
}
