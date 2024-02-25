using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TipoServico : Default
    {
        [Required(ErrorMessage = "Campo Obrigatório")]
        [MinLength(3, ErrorMessage = "O nome de possuir mais de {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [MinLength(3, ErrorMessage = "A descricao deve conter mais de {1} caracteres")]
        [MaxLength(300)]
        public string Descricao { get; set; }

        [Range(1, 10000, ErrorMessage = "O preço deve estar entre {1} e {2}")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Preco {  get; set; }
    }
}
