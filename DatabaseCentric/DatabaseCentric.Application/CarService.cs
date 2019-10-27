namespace DatabaseCentric.Application
{
    using System.Threading.Tasks;
    using DatabaseCentric.Persistence.Models;
    using DatabaseCentric.Persistence.Repositories;
    using DatabaseCentric.Application.Interfaces;
    using DatabaseCentric.Application.Models;
    using System;

    public class CarService : ICarService
    {
        private readonly CarRepository carRepository;

        public CarService(CarRepository carRepository) => this.carRepository = carRepository;

        public async Task<int> CreateAsync(CarInput input)
        {
            if (input.Year < 1990)
            {
                throw new Exception("Cannot create a car manufactured before 1990.");
            }

            var car = new Car
            {
                Make = input.Make,
                Model = input.Model,
                Type = input.Type,
                ExteriorColor = input.ExteriorColor,
                InteriorColor = input.InteriorColor
            };

            int id = await this.carRepository.CreateAsync(car);

            return id;
        }
    }
}