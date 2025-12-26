using Application.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PruebaTecnicaXpertGroup.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagenesController(ImageService _service) : ControllerBase
    {
        [HttpGet("imagesbybreedid")]
        public async Task<IActionResult> GetImages([FromQuery] string breedId)
        => Ok(await _service.GetImagesByBreed(breedId));
    }
}
