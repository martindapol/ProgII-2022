using Microsoft.AspNetCore.Mvc;
using WebAPIProgII.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIProgII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonedaController : ControllerBase
    {
        private static readonly List<Moneda> lst = new List<Moneda>();

        // GET: api/Moneda
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(lst);
        }

        // GET api/<Moneda>/Dolar
        [HttpGet("{nombre}")]
        public IActionResult Get(string nombre)
        {
            foreach(Moneda x in lst)
            {
                if (x.Nombre.Equals(nombre))
                {
                    return Ok(x);
                }
            }
            return NotFound("Moneda no registrada!");
        }

        // POST api/Moneda/Dolar
        [HttpPost]
        public IActionResult Post([FromBody] Moneda value)
        {
            if (value == null || string.IsNullOrEmpty(value.Nombre))
                return BadRequest("Error, objeto Moneda incorrecto");

            lst.Add(value);
            return Ok(value);
        }

       
    }
}
