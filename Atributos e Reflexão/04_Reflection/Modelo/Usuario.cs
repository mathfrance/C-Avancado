using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_Reflection.Modelo
{
    public class Usuario: ICloneable
    {
        public string Nome { get; set; }
        public string Senha { get; set; }

        public object Clone()
        {
            return new Usuario() { Nome = this.Nome, Senha = this.Senha};
        }
    }
}
