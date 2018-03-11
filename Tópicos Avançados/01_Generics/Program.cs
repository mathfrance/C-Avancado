using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tópicos_Avançados.Modelo;

namespace Tópicos_Avançados
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro Carro01 = new Carro() { Marca = "Honda", Modelo = "Civic" };
            Casa Casa01 = new Casa() { Cidade = "Toronto", Endereco = "9ª Street Av" };
            Usuario Usuario01 = new Usuario() { Nome = "Matheus França", CPF = "007.478.961-94", Email = "mathfrance@hotmail.com" };

            Serializador.Serializar(Carro01);
            Serializador.Serializar(Casa01);
            Serializador.Serializar(Usuario01);

            Carro Carro02 = Serializador.Deserializar<Carro>();
            Casa Casa02 = Serializador.Deserializar<Casa>();
            Usuario Usuario02 = Serializador.Deserializar<Usuario>();

            Console.WriteLine("Carro 02: " + Carro02.Marca + " - " + Carro02.Modelo);
            Console.WriteLine("Casa 02: " + Casa02.Cidade + " - " + Casa02.Endereco);
            Console.WriteLine("Usuario 02: " + Usuario02.Nome + " - " + Usuario02.CPF + " - " + Usuario02.Email);


            Console.ReadKey();
        }
    }
}
