﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _02_MultiThread
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadRepeticao);
                t1.Start();

            }
            Console.WriteLine("Programa Finalizado**************************");
            Console.ReadKey();
        }

        //IO - Tela, Rede, Armazenamento.
        static void ThreadRepeticao()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread: " + i);
            }
        }
    }
}
