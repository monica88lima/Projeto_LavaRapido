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
    public class VeiculoRepository:IVeiculoRepository
    {
        private readonly AppDbContext _context;

        public VeiculoRepository(AppDbContext context)
        {
            _context = context;
        }

        public Veiculo ConsultaVeiculo(string placa)
        {
            var veiculo = _context.Veiculos.Where(x => x.Placa == placa).FirstOrDefault();
            return veiculo is null ? null : veiculo;
        }
    }
}
