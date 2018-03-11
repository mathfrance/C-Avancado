using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_Reflection.Modelo
{
    public class Carro:ICloneable
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public object Clone()
        {
            return new Carro() { Marca = this.Marca, Modelo = this.Modelo }; ;
        }
    }
}
