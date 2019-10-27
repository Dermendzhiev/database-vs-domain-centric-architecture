namespace DomainCentric.Persistence.Repositories
{
    using System.Threading.Tasks;
    using DomainCentric.Application.Domain;
    using DomainCentric.Application.Interfaces.Repositories;
    using DomainCentric.Persistence.Models;

    public class CarRepository : ICarRepository
    {
        private readonly DomainCentricDbContext dbContext;

        public CarRepository(DomainCentricDbContext dbContext) => this.dbContext = dbContext;

        public async Task<int> CreateAsync(Car car)
        {
            var carDataModel = new CarDataModel
            {
                Make = car.Make,
                Model = car.Model,
                Type = car.Type,
                ExteriorColor = car.ExteriorColor,
                InteriorColor = car.InteriorColor
            };

            this.dbContext.Add(carDataModel);
            await this.dbContext.SaveChangesAsync();

            return carDataModel.Id;
        }
    }
}
