using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;
using System.Security.Cryptography.X509Certificates;

namespace ProjetoLavaRapidoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class PistaLavagemController : ControllerBase
    {
        private readonly IPistaLavagem _pistaLavagem;

        public PistaLavagemController(IPistaLavagem pistaLavagem)
        {
            _pistaLavagem = pistaLavagem;
        }
        [HttpGet]
        public ActionResult ConsultaStatusVeiculo(string placa)
        {
            try
            {
                var status = _pistaLavagem.ConsultaStatusVeiculo(placa);
                if (status is null)
                    return NotFound($"Nenhum veiculo localizado com a placa: {placa}");

                return Ok(status);
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
            


        }
    }
}
