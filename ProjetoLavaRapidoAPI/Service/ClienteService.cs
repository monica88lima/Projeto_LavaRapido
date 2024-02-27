using AutoMapper;
using Entity;
using Repository.Interface;
using Service.DTOs;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ClienteService:IClienteService
    {
        private readonly IClienteRespository _clienteRepositorio;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRespository clienteRepositorio, IMapper mapper)
        {
            _clienteRepositorio = clienteRepositorio;
            _mapper = mapper;
        }

        public ClienteDTO CadastrarCliente(ClienteDTO clienteDTO)
        {
            var clienteNovo = _mapper.Map<Cliente>(clienteDTO);
           


            if (_clienteRepositorio.CadastrarCliente(clienteNovo))
                return clienteDTO;
            else
                throw new NullReferenceException();


        }

        public ClienteDTO ConsultaClienteID(int id)
        {
            var clienteId = _clienteRepositorio.BuscaClienteID(id);
            var clienteDto = _mapper.Map <ClienteDTO>(clienteId);
           
            return clienteDto;
        }
    }
}
