namespace DatabaseCentric.Persistence
{
    using DatabaseCentric.Persistence.Models;
    using Microsoft.EntityFrameworkCore;

    public class DatabaseCentricDbContext : DbContext
    {
        public DatabaseCentricDbContext(DbContextOptions<DatabaseCentricDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}
