﻿using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Service.DTOs
{
    public class VeiculoDTO
    {
        [Required(ErrorMessage = "Campo Obrigatório")]
        [MinLength(7, ErrorMessage = "A placa deve possuir {1} caracteres")]
        [MaxLength(7, ErrorMessage = "A placa deve possuir {1} caracteres")]
        public string Placa { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int Ano { get; set; } = 0;
       
    }
}
