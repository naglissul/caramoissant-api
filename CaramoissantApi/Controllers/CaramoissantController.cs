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
            return Ok(await _caramoissantService.GetAll());
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
            var caramoissantToUpdate = await _caramoissantService.Get(caramoissant.Id);
            if (caramoissantToUpdate == null)
            {
                return NotFound();
            }
            //_mapper.Map(caramoissant, caramoissantToUpdate);
            caramoissantToUpdate.Location = caramoissant.Location;
            caramoissantToUpdate.Date = caramoissant.Date;
            await _caramoissantService.SaveAll();
            return Ok(caramoissantToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Caramoissant>> DeleteCaramoissant(int id)
        {
            return Ok(await _caramoissantService.Delete(id));
        }
    }
}