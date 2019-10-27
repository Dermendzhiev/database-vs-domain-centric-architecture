namespace DatabaseCentric.Persistence.Repositories
{
    using System.Threading.Tasks;
    using DatabaseCentric.Persistence.Models;

    public class CarRepository
    {
        private readonly DatabaseCentricDbContext dbContext;

        public CarRepository(DatabaseCentricDbContext dbContext) => this.dbContext = dbContext;

        public async Task<int> CreateAsync(Car car)
        {
            this.dbContext.Add(car);
            await this.dbContext.SaveChangesAsync();

            return car.Id;
        }
    }
}
