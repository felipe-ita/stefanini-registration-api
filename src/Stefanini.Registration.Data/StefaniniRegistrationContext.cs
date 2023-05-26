using Microsoft.EntityFrameworkCore;
using Stefanini.Registration.Data.Configurations;
using Stefanini.Registration.Domain.Entities;

namespace Stefanini.Registration.Data
{
    public class StefaniniRegistrationContext : DbContext
    {
        public StefaniniRegistrationContext() {}
        public StefaniniRegistrationContext(DbContextOptions<StefaniniRegistrationContext> options) : base(options) {}

        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Location>(new LocationConfiguration().Configure);
            modelBuilder.Entity<Event>(new EventConfiguration().Configure);
        }

    }
}
