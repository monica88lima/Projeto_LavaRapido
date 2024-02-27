using Entity.Enun;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entity
{
   
    public class Cliente:Default
    {
       

        [Required(ErrorMessage = "Campo Obrigatório")]
        [MinLength(3, ErrorMessage = "O nome de possuir mais de {1} caracteres")]
        public string NomeCompleto { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Phone]
        [Required]
        public string Celular { get; set; }

        [Required]
        [PasswordPropertyText]
        [MinLength(6, ErrorMessage = "Sua Senha deve possuir mais de  {1} caracteres")]
        [MaxLength(10, ErrorMessage = "Sua Senha deve possuir ate  {1} caracteres")]
        public string Senha{ get; set; }

        [Required]
        public ETipoPessoa TipoPessoa { get; set;} 
        public string? Comentario { get; set; }

    }
}
