using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace ProjetoLavaRapidoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class PistaLavagemController : ControllerBase
    {
        [HttpGet]
        public ActionResult ConsultaStatusVeiculo (string placa)
        {
            
            

        }
    }
}
