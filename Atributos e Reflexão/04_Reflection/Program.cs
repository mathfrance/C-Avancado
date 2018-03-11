using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _04_Reflection.Modelo;

namespace _04_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {

            Usuario usuario = new Usuario() { Nome = "Joseph", Senha = "1234" };
            Log.Gravar(usuario.Clone());

            usuario.Nome = "José Campos";
            Log.Gravar(usuario.Clone());

            Carro carro = new Carro() { Marca = "Honda", Modelo = "Civic" };
            Log.Gravar(carro);

            Log.ApresentarLog();

            Console.ReadKey();
        }
    }
}
