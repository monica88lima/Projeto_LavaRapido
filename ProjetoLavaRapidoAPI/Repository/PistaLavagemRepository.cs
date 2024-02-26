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
    public class PistaLavagemRepository : IPistaLavagemRepository
    {
        private readonly AppDbContext _context;

        public PistaLavagemRepository(AppDbContext context)
        {
            _context = context;
        }

        public PistaLavagem ConsultaStatus(int idVeiculo)
        {
            var statusVeiculo = _context.PistaLavagens.Where(x => x.VeiculoId == idVeiculo).FirstOrDefault();
        }
    }
}
