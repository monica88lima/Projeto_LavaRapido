using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.DTOs;
using Service.Interface;

namespace ProjetoLavaRapidoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService cadastroCliente)
        {
            _clienteService = cadastroCliente;
        }

        [HttpPost]
        public ActionResult CadastroCliente(ClienteDTO cliente)
        {
            try
            {
                if(cliente is null)
                {
                    return BadRequest("Dados inválidos");
                }
                var clienteNovo = _clienteService.CadastrarCliente(cliente);

                return new CreatedAtRouteResult("ObterCliente",
              new { id = clienteNovo.Id}, clienteNovo);

            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }

        }

        [HttpGet("{id:int}", Name = "ObterCliente")]
        public ActionResult<ClienteDTO> ConsultarClienteId(int id)
        {
            try
            {
                var cliente = _clienteService.ConsultaClienteID(id);
                if(cliente is null)
                    return NotFound($"Cliente de id:{id}, não localizado");
                cliente.Senha = "*******";
                return Ok(cliente);
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }
       
       
    }
}
