using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyperProject.Entity;

namespace HyperProject.Repository
{
    public interface ICarRepository
    {

        Task<IEnumerable<Car>> GetCarsByColorAsync(VehicleColor color);
        Task ToggleCarHeadlightsAsync(int carId, bool headlightsOn);
        Task DeleteCarAsync(int carId);
    }
}