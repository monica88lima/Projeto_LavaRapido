using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IPistaLavagemRepository
    {

        (string Placa, string StatusVeiculo, string NomeServico, int posicao) ConsultarPistas(int veiculoId);
    }
}
