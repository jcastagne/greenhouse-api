using GreenHouseApp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Configuration;

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

         public GreenHouseContext()
            :base()
        { }        
    }
}
