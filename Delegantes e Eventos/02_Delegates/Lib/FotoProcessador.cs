using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_Delegates.Lib
{
    public class FotoProcessador
    {
        public delegate void FotoFiltroHandler(Foto foto);

        public static FotoFiltroHandler filtros;
        
        public static void Processador(Foto foto)
        {
            filtros(foto);

            //var filtros = new FotoFiltro();
            //filtros.Colorir(foto);
            //filtros.PetroBranco(foto);
            //filtros.GerarThumb(foto);
        }

    }
}
