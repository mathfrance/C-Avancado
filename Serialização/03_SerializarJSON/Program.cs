using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using _00_Biblioteca;
using Newtonsoft.Json;

namespace _03_SerializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario Usuario01 = new Usuario() { Nome = "Ellie Lima", CPF = "333.222.222-22", Email = "Ellie@gmail.com" };

            string ObjetoSerializado = JsonConvert.SerializeObject(Usuario01);

            StreamWriter Stream = new StreamWriter(@"C:\Users\matheus.pinheiro\Documents\Visual Studio 2010\Projects\C# Avançado\Serialização\03_SerializarJSON.json");
            Stream.WriteLine(ObjetoSerializado);
            Stream.Close();
        }
    }
}
