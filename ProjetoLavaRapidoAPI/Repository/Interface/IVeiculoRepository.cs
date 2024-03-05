using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IVeiculoRepository
    {
        
        Veiculo ConsultaVeiculoPorPlaca(string placa);
    }
}
