using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace ProjetoLavaRapidoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILogin _login;

        public LoginController(ILogin login)
        {
            _login = login;
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            try
            {
                
                if (!_login.LoginCliente(email, password))
                    return BadRequest("Dados inválidos");

                return Ok("Acesso Permitido.");

            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
            
        }
    }
}
