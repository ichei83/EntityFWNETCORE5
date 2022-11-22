
using DFB.Models;
using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;

namespace DataModel
{
    public class DFBContext : DbContext
    {
        public DFBContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().ToTable("Car");
            modelBuilder.Entity<Organization>().ToTable("Organization");
            modelBuilder.Entity<CarEnrollment>().ToTable("CarEnrollment");
            modelBuilder.Entity<Driver>().ToTable("Driver");
            modelBuilder.Entity<CarModel>().ToTable("CarModel");
            modelBuilder.Entity<Manufacturer>().ToTable("Manufacturer");
        }


        public DbSet<Car> Cars { get; set; }
        public DbSet<CarEnrollment> CarPools { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Driver> Drivers { get; set; }


    }
}