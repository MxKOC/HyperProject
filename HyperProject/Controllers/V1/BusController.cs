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
    public class BusController : ControllerBase
    {
        readonly IBusRepository _busrepository;
        readonly IMapper _mapper;
        public BusController(IBusRepository busrepository, IMapper mapper)
        {
            _busrepository = busrepository;
            _mapper = mapper;
        }


        [HttpGet("{color}")]
        public async Task<ActionResult<IEnumerable<VehicleDTO>>> GetBusesByColorAsync(VehicleColor color)
        {
            var bus = await _busrepository.GetBusesByColorAsync(color);
            var busDTO = _mapper.Map<IEnumerable<VehicleDTO>>(bus);

            return Ok(busDTO);
        }

        





    }
}
