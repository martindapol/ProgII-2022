using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIProgII.Models;

namespace WebAPIProgII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FechaController : ControllerBase
    {
        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(new Fecha());
        }
    }
}
