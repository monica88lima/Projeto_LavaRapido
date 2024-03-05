using Entity;
using Entity.Enun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Service.DTOs
{
    public class PistaLavagemDTO
    {
        public int VeiculoId { get; set; }
        public int ServicoId { get; set; }

        public EStatus Status { get; set; }
     
       
    }
}
