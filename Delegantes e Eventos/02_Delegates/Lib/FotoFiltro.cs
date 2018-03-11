using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_Delegates.Lib
{
    public class FotoFiltro
    {
        public void Colorir(Foto foto)
        {
            Console.WriteLine("Filtro Ativado");
        }

        public void GerarThumb(Foto foto)
        {
            Console.WriteLine("Thumb Gerada");
        }

        public void PetroBranco(Foto foto)
        {
            Console.WriteLine("Preto e Branco Ativado");
        }

    }
}
