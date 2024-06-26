using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyperProject.Entity;

namespace HyperProject.Repository
{

    public class InMemoryBusRepository : IBusRepository
    {


        private List<Bus> _buses = new()
    {
        new Bus { Id = 1, Color = VehicleColor.Blue },
        new Bus { Id = 2, Color = VehicleColor.Black },
        new Bus { Id = 3, Color = VehicleColor.White }
    };



        async Task<IEnumerable<Vehicle>> IBusRepository.GetBusesByColorAsync(VehicleColor color)
        {
            var bus = _buses.Where(bus => bus.Color == color);
            return await Task.FromResult(bus);
        }


    }

}