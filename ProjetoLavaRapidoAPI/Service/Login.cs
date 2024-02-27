using AutoMapper;
using Repository.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public class Login:ILogin
    {
        private readonly IClienteRespository _clienteRepositorio;
        private readonly IMapper _mapper;

        public Login(IClienteRespository clienteRepositorio, IMapper mapper)
        {
            _clienteRepositorio = clienteRepositorio;
            _mapper = mapper;
        }

        public bool LoginCliente(string email, string password)
        { 
            return _clienteRepositorio.Login(email, password);
        }
    }
}
