using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _00_Biblioteca;
using System.IO;
using System.Xml.Serialization;

namespace _02_DeserializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader Stream = new StreamReader(@"C:\Users\matheus.pinheiro\Documents\Visual Studio 2010\Projects\C# Avançado\Serialização\01_SerializarXML.xml");    
            
            XmlSerializer Serializador = new XmlSerializer(typeof(Usuario));
            var Usuario = (Usuario) Serializador.Deserialize(Stream);

            Console.WriteLine("Nome: {0} - CPF: {1} - Email: {2}", Usuario.Nome, Usuario.CPF, Usuario.Email);

            Console.ReadKey();
        }
    }
}
