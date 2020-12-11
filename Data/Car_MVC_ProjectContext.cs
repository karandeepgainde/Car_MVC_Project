using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Car_MVC_Project.Models;

namespace Car_MVC_Project.Data
{
    public class Car_MVC_ProjectContext : DbContext
    {
        public Car_MVC_ProjectContext (DbContextOptions<Car_MVC_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Car_MVC_Project.Models.Staff> Staff { get; set; }

        public DbSet<Car_MVC_Project.Models.Customer> Customer { get; set; }

        public DbSet<Car_MVC_Project.Models.Car> Car { get; set; }

        public DbSet<Car_MVC_Project.Models.Buy> Buy { get; set; }
    }
}
