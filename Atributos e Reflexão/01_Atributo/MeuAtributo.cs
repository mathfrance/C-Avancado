using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_Atributo
{
    public class MeuAtributo:Attribute
    {
        [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Method)]
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public MeuAtributo(string nome)
        {
            Nome = nome;
        }
    }
}
