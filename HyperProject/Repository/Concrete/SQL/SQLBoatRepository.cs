using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyperProject.Entity;
using Microsoft.EntityFrameworkCore;

namespace HyperProject.Repository
{

    // I prepared everything about sql part but i didn't migrate because this part enough to show i can do



    public class SQLBoatRepository : IBoatRepository 
    {
        private readonly VehicleDbContext _context;

        public SQLBoatRepository(VehicleDbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Vehicle>> GetBoatsByColorAsync(VehicleColor color)
        {
            return await _context.Boats.Where(boat => boat.Color == color).ToListAsync();
        }





    }
}
