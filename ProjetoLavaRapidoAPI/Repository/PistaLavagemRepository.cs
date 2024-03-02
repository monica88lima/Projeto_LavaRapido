using Entity;
using Entity.Enun;
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
    public class PistaLavagemRepository : IPistaLavagemRepository
    {
        private readonly AppDbContext _context;

        public PistaLavagemRepository(AppDbContext context)
        {
            _context = context;
        }
        public (string Placa, string StatusVeiculo, string NomeServico, int posicao) ConsultarPistas(int veiculoId)
        {


            var resultado = (from PistaLavagem in _context.PistaLavagens
                             join Veiculo in _context.Veiculos on PistaLavagem.VeiculoId equals Veiculo.Id
                             join TipoServico in _context.TipoServico on PistaLavagem.ServicoId equals TipoServico.Id
                             where Veiculo.Id == veiculoId
                             select new
                             {
                                 Placa = Veiculo.Placa,
                                 StatusVeiculo = PistaLavagem.Status.ToString(),
                                 NomeServico = TipoServico.Nome
                             }).FirstOrDefault();

            var posicao = _context.PistaLavagens.Where(x => x.Status == EStatus.Aguardando).OrderBy(x => x.CriadoEm).ToList();

            return (resultado.Placa, resultado.StatusVeiculo, resultado.NomeServico, posicao.FindIndex(x => x.VeiculoId == veiculoId) + 1 );
        }


    }



}

