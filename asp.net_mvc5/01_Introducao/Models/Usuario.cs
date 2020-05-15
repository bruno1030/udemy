using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _01_Introducao.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O nome eh obrigatorio !")]
        public string Nome { get; set; }

        [StringLength(50, MinimumLength = 5, ErrorMessage = "Insira uma observacao de 5 a 50 caracteres")]
        public string Observacoes { get; set; }

        [Range(18,70, ErrorMessage = "A idade tem que estar entre 18 e 70 anos")]
        public int Idade { get; set; }

        [RegularExpression(@"^([a-z][a-z0-9]*[.][a-z][a-z0-9]*@march[.]com)$", ErrorMessage="Digite um email valido")]
        public string Email { get; set; }

        [RegularExpression(@"[a-zA-Z]{5, 15}", ErrorMessage = "Somente Letras e de 5 a 15 caracteres!")]
        [Required(ErrorMessage = "O login deve ser preenchido.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Senha eh obrigatoria")]
        public string Senha { get; set; }

        [Compare("Senha", ErrorMessage = "As senhas nao conferem")]
        public string ConfirmarSenha { get; set; }

    }
}