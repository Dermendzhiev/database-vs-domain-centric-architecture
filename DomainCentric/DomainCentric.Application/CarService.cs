namespace DomainCentric.Application
{
    using System.Threading.Tasks;
    using DomainCentric.Application.Domain;
    using DomainCentric.Application.Interfaces;
    using DomainCentric.Application.Interfaces.Repositories;
    using DomainCentric.Application.Models;

    public class CarService : ICarService
    {
        private readonly ICarRepository carRepository;

        public CarService(ICarRepository carRepository) => this.carRepository = carRepository;

        public async Task<int> CreateAsync(CarInput input)
        {
            var car = new Car(input.Make, input.Model, input.Type, input.ExteriorColor, input.InteriorColor, input.Year);
            int id = await this.carRepository.CreateAsync(car);
            return id;
        }
    }
}
