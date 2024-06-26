using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyperProject.Entity;

namespace HyperProject.Repository
{

    public class InMemoryBoatRepository : IBoatRepository
    {

        private List<Boat> _boats = new()
    {
        new Boat { Id = 1, Color = VehicleColor.White },
        new Boat { Id = 2, Color = VehicleColor.Blue },
        new Boat { Id = 3, Color = VehicleColor.Red }
    };

        async Task<IEnumerable<Vehicle>> IBoatRepository.GetBoatsByColorAsync(VehicleColor color)
        {
            var boat = _boats.Where(boat => boat.Color == color);
            return await Task.FromResult(boat);

        }


    }

}