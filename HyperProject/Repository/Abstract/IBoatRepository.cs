using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyperProject.Entity;

namespace HyperProject.Repository
{
    public interface IBoatRepository
    {

        Task<IEnumerable<Vehicle>> GetBoatsByColorAsync(VehicleColor color);

    }
    
}