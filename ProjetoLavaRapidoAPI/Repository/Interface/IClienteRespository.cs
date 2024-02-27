using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IClienteRespository
    {
        bool CadastrarCliente(Cliente cliente);
        bool Login(string email, string password);
        Cliente BuscaClienteID(int id);


    }
}
