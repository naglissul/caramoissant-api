using AutoMapper;
using CaramoissantApi.Infrastructure;
using CaramoissantApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CaramoissantApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CaramoissantController : ControllerBase
    {

        private readonly ICaramoissantService _caramoissantService;
        private readonly IMapper _mapper;

        public CaramoissantController(ICaramoissantService caramoissantService, IMapper mapper)
        {
            _caramoissantService = caramoissantService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Caramoissant>> GetCaramoissant(int id)
        {
            var caramoissant = await _caramoissantService.Get(id);
            return Ok(caramoissant);
        }

        [HttpGet]
        public async Task<ActionResult<List<Caramoissant>>> GetAllCaramoissants()
        {
            return Ok(new List<Caramoissant>());
        }

        [HttpPost]
        public async Task<ActionResult<Caramoissant>> CreateCaramoissant(CaramoissantPostModel caramoissant)
        {
            var createdCaramoissant = _mapper.Map<Caramoissant>(caramoissant);
            await _caramoissantService.Add(createdCaramoissant);
            await _caramoissantService.SaveAll();

            return Ok(_mapper.Map<CaramoissantViewModel>(createdCaramoissant));
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