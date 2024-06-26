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
    public class BoatController : ControllerBase
    {
        readonly IBoatRepository _boatrepository;
        readonly IMapper _mapper;
        public BoatController(IBoatRepository boatrepository, IMapper mapper)
        {
            _boatrepository = boatrepository;
            _mapper = mapper;
        }

        [HttpGet("{color}")]
        public async Task<ActionResult<IEnumerable<VehicleDTO>>> GetBoatsByColorAsync(VehicleColor color)
        {
            var boat = await _boatrepository.GetBoatsByColorAsync(color);
            var boatDTO = _mapper.Map<IEnumerable<VehicleDTO>>(boat);

            return Ok(boatDTO);
        }
        





    }
}
