using Microsoft.AspNetCore.Mvc;

namespace CaramoissantApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CaramoissantController : ControllerBase
    {

        private readonly ILogger<CaramoissantController> _logger;

        public CaramoissantController(ILogger<CaramoissantController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Caramoissant>> GetCaramoissant(int id)
        {
            return Ok(new Caramoissant());
        }

        [HttpGet]
        public async Task<ActionResult<List<Caramoissant>>> GetAllCaramoissants()
        {
            return Ok(new List<Caramoissant>());
        }

        [HttpPost]
        public async Task<ActionResult<Caramoissant>> CreateCaramoissant(Caramoissant caramoissant)
        {
            return Ok(caramoissant);
        }

        [HttpPut]
        public async Task<ActionResult<Caramoissant>> UpdateCaramoissant(Caramoissant caramoissant)
        {
            return Ok(caramoissant);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Caramoissant>> DeleteCaramoissant(int id)
        {
            return Ok(new Caramoissant());
        }
    }
}