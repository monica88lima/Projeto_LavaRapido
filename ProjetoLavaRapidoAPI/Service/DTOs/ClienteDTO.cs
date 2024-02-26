﻿using Entity;
using Entity.Enun;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs
{
    public class ClienteDTO
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

            
        public ICollection<Veiculo>? Veiculos { get; set; }
    }
}