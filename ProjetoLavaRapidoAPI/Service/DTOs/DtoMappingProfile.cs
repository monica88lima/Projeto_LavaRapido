using AutoMapper;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs
{
    public class DtoMappingProfile:Profile
    {
        public DtoMappingProfile() {
            CreateMap<Cliente, ClienteDTO>().ReverseMap();
            CreateMap<Veiculo, VeiculoDTO>().ReverseMap();
            CreateMap<PistaLavagem, PistaLavagemDTO>().ReverseMap();
        }
    }
}
