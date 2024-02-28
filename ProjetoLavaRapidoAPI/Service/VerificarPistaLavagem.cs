using AutoMapper;
using Entity;
using Repository.Interface;
using Service.DTOs;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class VerificarPistaLavagem: IPistaLavagem
    {
        private readonly IVeiculoRepository _veiculoRepositorio;
        private readonly IPistaLavagemRepository _LavagemRepo;
        private readonly IMapper _mapper;

        public VerificarPistaLavagem(IVeiculoRepository veiculoRepositorio, IMapper mapper, IPistaLavagemRepository lavagemRepo)
        {
            _veiculoRepositorio = veiculoRepositorio;
            _mapper = mapper;
            _LavagemRepo = lavagemRepo;
        }

        public ConsultaPistaDTO ConsultaStatusVeiculo(string placa)
        {

            var consultaPistaVeiculo = _LavagemRepo.ConsultaStatus(placa);
            if (consultaPistaVeiculo is null)
                throw new NullReferenceException();

            var statusVeiculo = new ConsultaPistaDTO()
            {
                NomeServico = consultaPistaVeiculo.TipoServico.FirstOrDefault().Nome,
                Placa = consultaPistaVeiculo.Veiculo.FirstOrDefault().Placa,
                StatusVeiculo = consultaPistaVeiculo.Status.ToString(),
            };

            return statusVeiculo;
        }
    }
}
