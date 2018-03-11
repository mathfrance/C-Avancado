using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _04_Reflection.Modelo;

namespace _04_Reflection
{
    public class Log
    {
        public static List<Object> objetos = new List<object>();

        public static void Gravar(object obj)
        {
            objetos.Add(obj);
        }

        public static void ApresentarLog()
        {
            foreach (object obj in objetos)
            {
                Console.WriteLine("-----------Nome da Classe: {0}---------------", obj.GetType().Name);
                foreach (var prop in obj.GetType().GetProperties())
                {
                    Console.WriteLine("{0} : {1}" ,prop.Name , prop.GetValue(obj , null));
                }
            }
        }


        /*public static List<Carro> Carros = new List<Carro>(); 
        public static List<Usuario> Usuarios = new List<Usuario>(); 

        public static void GravarUsuario(Usuario usuario)
        {
            Usuarios.Add((Usuario)usuario.Clone()) ;
        }

        public static void ApresentarLogUsuario()
        {
            foreach (var usuario in Usuarios)
            {
                Console.WriteLine("Nome: {0} - Senha: {1} ", usuario.Nome , usuario.Senha);
            }
        }
        
        public static void GravarCarro(Carro carro)
        {
            Carros.Add((Carro)carro.Clone());
        }

        public static void ApresentarLogCarro()
        {
            foreach (var carro in Carros)
            {
                Console.WriteLine("Marca: {0} - Modelo: {1} ", carro.Marca , carro.Modelo);
            }
        }*/
    }
}
