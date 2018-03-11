using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_LINQ_JOIN
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Autor> listaAutor = new List<Autor>();
            listaAutor.Add(new Autor() { Id = 1, Nome = "Gearge RR Martin" });
            listaAutor.Add( new Autor() { Id = 2, Nome = "Anakin" });
            listaAutor.Add(new Autor() { Id = 3, Nome = "Blasckovit" });

            List<Livro> listaLivro = new List<Livro>();
            listaLivro.Add( new Livro() { Id = 1, AutorId = 2, Titulo = "Star Wars" });
            listaLivro.Add(new Livro() { Id = 2, AutorId = 1, Titulo = "Game Of Thrones" });
            listaLivro.Add(new Livro() { Id = 3, AutorId = 1, Titulo = "Win or Die" });
            listaLivro.Add(new Livro() { Id = 4, AutorId = 3, Titulo = "Nova Ordem" });

            var ListaJoin = from livros in listaLivro join autores in listaAutor on livros.AutorId equals autores.Id select new {livros, autores};

            foreach (var item in ListaJoin)
            {
                Console.WriteLine("LIVRO: " + item.livros.Titulo + " - AUTOR: " + item.autores.Nome); 
            }
            Console.ReadKey();
        }
    }
}
