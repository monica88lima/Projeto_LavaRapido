using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IClienteService
    {
        ClienteDTO CadastrarCliente(ClienteDTO clienteDTO);
        ClienteDTO ConsultaClienteID(int id);
    }
}
