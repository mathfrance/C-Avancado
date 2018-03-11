using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace _02_Validacao
{
    public class Usuario
    {
        [Required (ErrorMessage = "O Campo Nome é Obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Idiomas.Linguagem) , ErrorMessageResourceName = "MSG_OBRIGATORIO")]
        public string Email { get; set; }

        [Required , StringLength(8 , MinimumLength = 6)]
        public string Senha { get; set; }
    }
}
