using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CadastroCliente
    {
        private readonly IClienteRespository _clienteRepositorio;

        public CadastroCliente(IClienteRespository clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }
    }
}
