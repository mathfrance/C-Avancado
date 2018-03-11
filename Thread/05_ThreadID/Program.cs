using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _05_ThreadID
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadRepeticao);
                t1.Start(i);

            }
            Console.WriteLine("Programa Finalizado");
            Console.ReadKey();
        }

        //IO - Tela, Rede, Armazenamento.
        static void ThreadRepeticao(object id)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ID Thread: " +id+" Num: "+ i+" Id Interno: "+Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
