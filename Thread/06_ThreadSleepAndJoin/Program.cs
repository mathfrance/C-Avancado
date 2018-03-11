using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _06_ThreadSleepAndJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa Iniciado!");
            Thread.Sleep(2000);

            Thread t1 = new Thread(ThreadRepeticao);            
            t1.Start(1);

            //t1.Join();
            
            Thread t2 = new Thread(ThreadRepeticao);
            t2.Start(2);

            //t1.Join();

            Thread t3 = new Thread(ThreadRepeticao);
            t3.Start(3);

            t1.Join();

            Console.WriteLine("Programa Finalizado!");
            Console.ReadKey();
        }

        //IO - Tela, Rede, Armazenamento.
        static void ThreadRepeticao(object id)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ID Thread: " + id + " Num: " + i + " Id Interno: " + Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
