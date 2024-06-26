using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyperProject.Entity;
using Microsoft.EntityFrameworkCore;

namespace HyperProject.Repository
{

    // I prepared everything about sql part but i didn't migrate because this part enough to show i can do



    public class SQLBusRepository : IBusRepository 
    {
        private readonly VehicleDbContext _context;

        public SQLBusRepository(VehicleDbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Vehicle>> GetBusesByColorAsync(VehicleColor color)
        {
            return await _context.Buses.Where(bus => bus.Color == color).ToListAsync();

        }

    }
}
