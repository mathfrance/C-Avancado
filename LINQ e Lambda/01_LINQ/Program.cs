using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ E LAMBDA

            // LAMBDA = (ENTRADA) => (EXPRESSÃO)
            
            int[] lista = {3, 20, 13, 16, 1, 12, 13, 9, 7, 69};

            //var ListaFiltrada = from a in lista where a > 10 orderby a select a;  

            var ListaFiltrada = lista.Where(numero => numero > 10).OrderBy(a => a).Select(a => a); //Outra Alternativa de LINQ
            
            foreach (var item in ListaFiltrada)
            {
            Console.WriteLine(item);                
            }
            Console.ReadKey();
        }
    }
}
