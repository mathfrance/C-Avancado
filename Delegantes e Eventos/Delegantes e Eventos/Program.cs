using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegantes_e_Eventos
{
    class Program
    {
        delegate int Calcula(int a, int b);
        static void Main(string[] args)
        {
            Calcula calc = new Calcula(Soma);
            int so = calc(10, 20);

            Console.WriteLine("Soma: "+so);
            Console.WriteLine("Subtração: ");

            Console.ReadKey();
        }
        static int Soma(int a, int b)
        {
            return a + b;
        }
        static int Subtrai(int a, int b)
        {
            return a - b;
        }
    }    
}
