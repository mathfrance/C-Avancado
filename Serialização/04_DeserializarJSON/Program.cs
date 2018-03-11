using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using _00_Biblioteca;
using Newtonsoft.Json;

namespace _04_DeserializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader Stream = new StreamReader(@"C:\Users\matheus.pinheiro\Documents\Visual Studio 2010\Projects\C# Avançado\Serialização\03_SerializarJSON.json");
            string LinhasDoArquivo = Stream.ReadToEnd();

            Usuario Usuario = JsonConvert.DeserializeObject<Usuario>(LinhasDoArquivo);

            Console.WriteLine("Nome: {0} - CPF: {1} - Email: {2}", Usuario.Nome, Usuario.CPF, Usuario.Email);

            Console.ReadKey();
        }
    }
}
