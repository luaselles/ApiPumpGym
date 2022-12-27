using Microsoft.EntityFrameworkCore;
using Pump.Domain.Entity;

namespace Pump.Infra.Data
{
    internal class ElementoPumpDBContext : DbContext
    {
        public DbSet<ElementoPumpEntity> Elemento => Set<ElementoPumpEntity>();

        public ElementoPumpDBContext(DbContextOptions options)
            : base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ElementoPumpDBContext).Assembly);
        }
    }
}