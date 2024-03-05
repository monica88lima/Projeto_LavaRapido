using Entity;
using Entity.Enun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs
{
    public class ConsultaPistaDTO
    {
        public string Placa{ get; set; }
        public string StatusVeiculo { get; set; }
        public string NomeServico{ get; set; }
        public int Posicao { get; set; }
    }
}
