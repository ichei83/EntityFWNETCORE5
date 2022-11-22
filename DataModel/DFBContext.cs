using Microsoft.EntityFrameworkCore;

namespace DataModel
{
    public class DFBContext : DbContext
    {
        public DFBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarPool> CarPools { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Driver> Drivers { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=DfbDB;Trusted_Connection=True;");
        //    //base.OnConfiguring(optionsBuilder);
        //}

    }
}