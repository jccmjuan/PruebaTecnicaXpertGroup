using Application.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PruebaTecnicaXpertGroup.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController(UserService _service) : ControllerBase
    {
        [HttpGet("login")]
        public async Task<IActionResult> Login([FromQuery] string username, [FromQuery] string password)
        {
            var user = await _service.Login(username, password);
            if (user == null) return Unauthorized("Credenciales inválidas");
            return Ok(user);
        }

        [HttpGet("Register")]
        public async Task<IActionResult> Register([FromQuery] string username, [FromQuery] string password)
        {
            await _service.Register(username, password);
            return Ok(new { Message = "Usuario registrado exitosamente" });
        }
    }
}
