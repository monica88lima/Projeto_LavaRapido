using Entity;
using Entity.Enun;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Service.DTOs
{
    public class ClienteDTO
    {
        [JsonIgnore]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [MinLength(3, ErrorMessage = "O nome de possuir mais de {1} caracteres")]
        public string NomeCompleto { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        [PasswordPropertyText]
        public string Senha { get; set; }

        [Phone]
        [Required]
        public string Celular { get; set; }
   
    }
}
