using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _02_Delegates.Lib;

namespace _02_Delegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            Foto foto = new Foto () {Nome = "Foto.jpg" , TamanhoX= 1080 , TamanhoY = 720};
            //TELA - Cadastro de Cliente: Thumb.
            Console.WriteLine("CLIENTE");
            FotoProcessador.filtros = new FotoFiltro().GerarThumb;
            FotoProcessador.Processador(foto);
            Console.WriteLine();
            //TELA - Cadastro de Produto: Colorir + Thumb.
            Console.WriteLine("PRODUTO");
            FotoProcessador.filtros = new FotoFiltro().Colorir;
            FotoProcessador.filtros += new FotoFiltro().GerarThumb;            //SINISTRÃO
            FotoProcessador.Processador(foto);
            Console.WriteLine();

            //Tela - Album Retrô do Usuário: Preto e Branco.
            Console.WriteLine("ÁLBUM");
            FotoProcessador.filtros = new FotoFiltro().PetroBranco;
            FotoProcessador.Processador(foto);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
