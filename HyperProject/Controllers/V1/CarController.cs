using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HyperProject.DTOs;
using HyperProject.Entity;
using HyperProject.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HyperProject.Controllers
{
    [ApiController]
    [Route("api/V1/[controller]")]
    public class CarController : ControllerBase
    {
        readonly ICarRepository _carrepository;
        readonly IMapper _mapper;
        public CarController(ICarRepository carrepository, IMapper mapper)
        {
            _carrepository = carrepository;
            _mapper = mapper;
        }

        [HttpGet("{color}")]
        public async Task<ActionResult<IEnumerable<CarDTO>>> GetCarsByColorAsync(VehicleColor color)
        {
            var car = await _carrepository.GetCarsByColorAsync(color);
            var carDTO = _mapper.Map<IEnumerable<CarDTO>>(car);
            return Ok(carDTO);

        }
        



        [HttpPost("{carId}/toggle-headlights")]
        public async Task<IActionResult> ToggleCarHeadlightsAsync(int carId, [FromBody] bool headlightsOn)
        {
            try
            {
                await _carrepository.ToggleCarHeadlightsAsync(carId, headlightsOn);
                return Ok();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete("{carId}")]
        public async Task<IActionResult> DeleteCarAsync(int carId)
        {
            try
            {
            await _carrepository.DeleteCarAsync(carId);
            return Ok();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }




    }
}
