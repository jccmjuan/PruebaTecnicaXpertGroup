using Application.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PruebaTecnicaXpertGroup.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GatosController(CatService _service) : ControllerBase
    {
        [HttpGet("breeds")]
        public async Task<IActionResult> GetBreeds() => Ok(await _service.GetAllBreeds());

        [HttpGet("breeds/{breed_id}")]
        public async Task<IActionResult> GetBreed(string breed_id) => Ok(await _service.GetBreed(breed_id));

        [HttpGet("breeds/search")]
        public async Task<IActionResult> Search([FromQuery] string q) => Ok(await _service.Search(q));
    }
}
