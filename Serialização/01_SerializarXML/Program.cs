using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using _00_Biblioteca;
using System.Xml.Serialization;

namespace _01_SerializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario Usuario01 = new Usuario() { Nome = "Joel Costa" , CPF = "222.222.222-22" , Email = "joel@gmail.com" };

            //DUAS FORMAS DE PASSAR O TYPE
            XmlSerializer Serializador = new XmlSerializer(typeof(Usuario));
            //XmlSerializer serializador = new XmlSerializer(Usuario01.GetType());

            //O @ considera os caracteres especiais, no caso \"
            StreamWriter Stream = new StreamWriter(@"C:\Users\matheus.pinheiro\Documents\Visual Studio 2010\Projects\C# Avançado\Serialização\01_SerializarXML.xml");

            Serializador.Serialize(Stream, Usuario01);
        }
    }
}
