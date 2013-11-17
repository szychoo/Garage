using Garage.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Garage
{
    public class CarContext : DbContext
    {
        public CarContext()
            : base("CarDbConnection")
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<Make> Makes { get; set; }
    }
}