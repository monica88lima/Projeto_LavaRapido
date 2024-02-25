using Entity.Enun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public  class PistaLavagem: Default
    {
      
        public int VeiculoId { get; set; }
        public int ServicoId { get; set; }
        
        public EStatus Status { get; set; }
    }
}
