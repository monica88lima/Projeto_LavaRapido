using Service.DTOs;

namespace Service.Interface
{
    public interface IPistaLavagem
    {
        ConsultaPistaDTO ConsultaStatusVeiculo(string placa);
    }
}
