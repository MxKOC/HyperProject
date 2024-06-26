using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyperProject.Entity;

namespace HyperProject.DTOs
{
    public class CarDTO : VehicleDTO
    {
        public int Wheels { get; set; }
        public bool HeadlightsOn { get; set; }
    
        
    }
}

