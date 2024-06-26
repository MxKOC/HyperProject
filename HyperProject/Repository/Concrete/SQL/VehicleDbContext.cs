using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyperProject.Entity;
using Microsoft.EntityFrameworkCore;

namespace HyperProject.Repository
{

    public class VehicleDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Boat> Boats { get; set; }

        public VehicleDbContext(DbContextOptions<VehicleDbContext> options) : base(options)
        {
        }
    }


}