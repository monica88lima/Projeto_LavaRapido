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
            //fazer a busca pela placa para localizar o veiculo
            var veiculo = _veiculoRepositorio.ConsultaVeiculoPorPlaca(placa);

            if(veiculo is null)
            {
                throw new Exception();
            }
            var consultaPistaVeiculo = _LavagemRepo.ConsultaStatus(veiculo.Id);
            if (consultaPistaVeiculo is null)
                throw new NullReferenceException();

           //criar umas constntes p atribui valor a consulta da pista

            return statusVeiculo;
        }
    }
}
