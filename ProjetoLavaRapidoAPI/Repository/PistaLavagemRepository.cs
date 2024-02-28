using Entity;
using Microsoft.EntityFrameworkCore;
using Repository.Context;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PistaLavagemRepository :IPistaLavagemRepository
    {
        private readonly AppDbContext _context;

        public PistaLavagemRepository(AppDbContext context)
        {
            _context = context;
        }

        public PistaLavagem ConsultaStatus(string placa)
        {
            var consultaPista = _context.PistaLavagens
                 .Include(x => x.Veiculo.Where(x => x.Placa == placa))
                 .Include(x => x.TipoServico)
                 .FirstOrDefault();

            return consultaPista;

        }

        

    }
}
