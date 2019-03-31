using GreenHouseApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace GreenHouseApp.Data
{
    public class GreenHouseContext:DbContext
    {
        public DbSet<Plant> Plants { get; set; }
        public DbSet<PlantType> PlantTypes { get; set; }
        public DbSet<GenericName> GenericNames { get; set; }
        public DbSet<SpecificName> SpecificNames { get; set; }
        public DbSet<Color> Colors { get; set; }

        public GreenHouseContext(DbContextOptions<GreenHouseContext> options)
            :base(options)
        { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(
        //        "Data Source=shadow-n81qhuih;Initial Catalog=GreenHousedb;Integrated Security=True");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
