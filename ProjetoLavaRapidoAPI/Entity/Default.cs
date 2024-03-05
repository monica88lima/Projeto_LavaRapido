using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Default
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CriadoEm { get; set; } = DateTime.Now;

        [DataType(DataType.DateTime)]
        public DateTime? AtualizadoEm { get; set; } 
    }
}
