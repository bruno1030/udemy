using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        [RegularExpression(@"\s*\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*\s*", ErrorMessage="Digite um email valido")]
        public string Email { get; set; }

        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somente Letras e de 5 a 15 caracteres!")]
        [Required(ErrorMessage = "O login deve ser preenchido.")]
        [Remote("LoginUnico", "Usuario", ErrorMessage = "Este login ja existe")] // primeiro parametro eh a funcao que sera acessada, depois o nome da controller onde esta aquele metodo, e depois a mensagem que sera apresentada em caso de erro
        public string Login { get; set; }

        [Required(ErrorMessage = "Senha eh obrigatoria")]
        public string Senha { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "As senhas nao conferem")]
        public string ConfirmarSenha { get; set; }

    }
}