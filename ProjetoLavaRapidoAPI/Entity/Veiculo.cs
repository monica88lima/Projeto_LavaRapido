using Entity.Enun;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entity
{
    public class Veiculo : Default
    {
        
        [Required(ErrorMessage = "Campo Obrigatório")]
        [MinLength(7, ErrorMessage = "A placa deve possuir {1} caracteres")]
        [MaxLength(7, ErrorMessage = "A placa deve possuir {1} caracteres")]
        public string Placa {  get; set; }  
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int? Ano {  get; set; }
        public string? Observacao { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set;}
        
        
       
    }
}
