using Microsoft.EntityFrameworkCore;
using WSDomain.Entity;

namespace WSInfraestructure.Data
{
    public class InMemoryDbContext : DbContext
    {
        public InMemoryDbContext(DbContextOptions<InMemoryDbContext> options) : base(options)
        {
        }

        public DbSet<SingleCharacter> SingleCharacter { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SingleCharacter>().Property(e => e.Episode).HasConversion(
                v => string.Join(',', v),
                v => v.Split(',', System.StringSplitOptions.RemoveEmptyEntries));
            modelBuilder.Entity<SingleCharacter>().OwnsOne(x => x.Origin);
            modelBuilder.Entity<SingleCharacter>().OwnsOne(x => x.Location);


        }
    }
}
