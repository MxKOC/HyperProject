using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyperProject.Entity;

namespace HyperProject.Repository
{

    public class InMemoryCarRepository : ICarRepository
    {

        private List<Car> _cars = new()
    {
        new Car { Id = 1, Color = VehicleColor.Red, Wheels = 4, HeadlightsOn = false },
        new Car { Id = 2, Color = VehicleColor.Blue, Wheels = 4, HeadlightsOn = false },
        new Car { Id = 3, Color = VehicleColor.Black, Wheels = 2, HeadlightsOn = false },
        new Car { Id = 4, Color = VehicleColor.Red, Wheels = 2, HeadlightsOn = false },
        new Car { Id = 5, Color = VehicleColor.Red, Wheels = 2, HeadlightsOn = false }
    };


        public async Task<IEnumerable<Car>> GetCarsByColorAsync(VehicleColor color)
        {
            var car = _cars.Where(car => car.Color == color);
            return await Task.FromResult(car);
        }


        public async Task ToggleCarHeadlightsAsync(int carId, bool HeadlightON)
        {
            var car = _cars.FirstOrDefault(c => c.Id == carId);
            if (car == null){
                throw new KeyNotFoundException("Car ID not found.");}
            else{
                car.HeadlightsOn = HeadlightON;}
            
             await Task.CompletedTask;
        }

        public async Task DeleteCarAsync(int carId)
        {
            var car =  _cars.FirstOrDefault(c => c.Id == carId);
            
            if (car == null){
                throw new KeyNotFoundException("Car ID not found.");}
            else{
                _cars.Remove(car);}

            await Task.CompletedTask;

        }


    }

}