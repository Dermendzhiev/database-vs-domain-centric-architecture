namespace DomainCentric.Persistence
{
    using DomainCentric.Persistence.Models;
    using Microsoft.EntityFrameworkCore;

    public class DomainCentricDbContext : DbContext
    {
        public DomainCentricDbContext(DbContextOptions<DomainCentricDbContext> options)
            : base(options)
        {
        }

        public DbSet<CarDataModel> Cars { get; set; }
    }
}
