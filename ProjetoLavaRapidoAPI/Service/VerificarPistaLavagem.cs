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

            if (veiculo is null)
            {
                throw new Exception();
            }
            var consultaPistaVeiculo = _LavagemRepo.ConsultarPistas(veiculo.Id);
            if (consultaPistaVeiculo.StatusVeiculo is null)
                throw new NullReferenceException();

            return new ConsultaPistaDTO() {
                NomeServico = consultaPistaVeiculo.NomeServico,
                StatusVeiculo = consultaPistaVeiculo.StatusVeiculo,
                Placa  = consultaPistaVeiculo.Placa,
                Posicao = consultaPistaVeiculo.posicao
            };
            
        }

        private ConsultaPistaDTO AtribuirCampos(int servico)
        {
            var statusPrenchido = new ConsultaPistaDTO();
            switch (servico)
            {
                case 1:
                    statusPrenchido.NomeServico = "Lavagem Simples";
                    break;
                case 2:
                    statusPrenchido.NomeServico = "Lavagem Express";
                    break;
                case 3:
                    statusPrenchido.NomeServico = "Lavagem Completa";
                    break;
                case 4:
                    statusPrenchido.NomeServico = "Polimento de Veiculos";
                    break;
                case 5:
                    statusPrenchido.NomeServico = "Higienização";
                    break;
                default:
                    statusPrenchido.NomeServico = "Não Localizado";
                    break;
            }

            return statusPrenchido;


        }
    }
}
