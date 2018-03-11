using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace _03_ValidacaoCustomizada
{
    public class Usuario
    {
        [Required(ErrorMessage = "O Campo Nome é Obrigatório!")]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }

        [Required, StringLength(8, MinimumLength = 6)]
        [MinhaValidacao(ErrorMessage = "O Campo 'Senha' Deve Possuir 8 caracteres")] 
        public string Senha { get; set; }
    }
}
