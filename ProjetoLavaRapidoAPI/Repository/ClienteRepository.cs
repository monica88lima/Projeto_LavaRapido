using Entity;
using Repository.Context;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClienteRepository:IClienteRespository
    {
        private readonly AppDbContext _context;

        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool CadastrarCliente(Cliente cliente)
        {
            //verificar se dados ja estao cadastrados


            //salvar novo
            _context.Clientes.Add(cliente);
            var sucesss = _context.SaveChanges();
            return sucesss == 1;
        }
        public Cliente BuscaClienteID(int id)
        {
            return _context.Clientes.FirstOrDefault(x => x.Id == id);
        }


        public bool Login(string email, string password)
        {
            return  _context.Clientes.Any(x => x.Email == email && x.Senha == password);
        }
        public bool ValidarEmailUnico(string email)
        {
            return _context.Clientes.Any(x => x.Email == email );
        }
    }
}
