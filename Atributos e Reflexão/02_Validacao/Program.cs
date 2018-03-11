using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace _02_Validacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario User1 = new Usuario() { Nome =  "José", Email = "ja", Senha = "122" };

            ValidationContext contexto = new ValidationContext(User1, null, null);
            List<ValidationResult> resultados = new List<ValidationResult>();

            if (Validator.TryValidateObject(User1, contexto, resultados, true) == false)
            {
                //Mensagens

                foreach(var erro in resultados)
                {
                    Console.WriteLine(erro.ErrorMessage);
                }
            }

            Console.ReadKey();

        }
    }
}
