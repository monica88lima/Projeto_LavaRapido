using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.DTOs;

namespace ProjetoLavaRapidoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpPost]
        public ActionResult CadastroCliente(ClienteDTO cliente)
        {
            try
            {
                if(cliente is null)
                {
                    return BadRequest("Dados inválidos");
                }


            }
            catch (Exception)
            {

                throw;
            }

        }
        [HttpPost]
        public ActionResult Login(string email, string senha)
        {

        }
       
    }
}
