using Microsoft.AspNetCore.Mvc;

namespace CaramoissantApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CroissantController : ControllerBase
    {

        private readonly ILogger<CroissantController> _logger;

        public CroissantController(ILogger<CroissantController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Croissant>> GetCroissant(int id)
        {
            return Ok(new Croissant());
        }

        [HttpGet]
        public async Task<ActionResult<List<Croissant>>> GetAllCroissants()
        {
            return Ok(new List<Croissant>());
        }

        [HttpPost]
        public async Task<ActionResult<Croissant>> CreateCroissant(Croissant croissant)
        {
            return Ok(croissant);
        }

        [HttpPut]
        public async Task<ActionResult<Croissant>> UpdateCroissant(Croissant croissant)
        {
            return Ok(croissant);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Croissant>> DeleteCroissant(int id)
        {
            return Ok(new Croissant());
        }
    }
}