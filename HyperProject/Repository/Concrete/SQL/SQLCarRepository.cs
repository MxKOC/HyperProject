using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyperProject.Entity;
using Microsoft.EntityFrameworkCore;

namespace HyperProject.Repository
{

    // I prepared everything about sql part but i didn't migrate because this part enough to show i can do



    public class SQLCarRepository : ICarRepository 
    {
        private readonly VehicleDbContext _context;

        public SQLCarRepository(VehicleDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Car>> GetCarsByColorAsync(VehicleColor color)
        {
            return await _context.Cars.Where(car => car.Color == color).ToListAsync();

        }


        public async Task ToggleCarHeadlightsAsync(int carId, bool headlightsOn)
        {
            var car = await _context.Cars.FirstOrDefaultAsync(c => c.Id == carId);
           if (car == null){
                throw new KeyNotFoundException("Car ID not found.");}
            else{
                car.HeadlightsOn = headlightsOn;
                await _context.SaveChangesAsync();}
            
        }

        public async Task DeleteCarAsync(int carId)
        {
            var car = await _context.Cars.FirstOrDefaultAsync(c => c.Id == carId);
            if (car == null){
                throw new KeyNotFoundException("Car ID not found.");}
            else{
                _context.Cars.Remove(car);
                await _context.SaveChangesAsync();}
        }


    }
}
