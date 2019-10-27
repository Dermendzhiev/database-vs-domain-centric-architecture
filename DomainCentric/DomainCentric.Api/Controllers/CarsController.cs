namespace DomainCentric.Api.Controllers
{
    using System.Threading.Tasks;
    using DomainCentric.Api.Models;
    using DomainCentric.Application.Interfaces;
    using DomainCentric.Application.Models;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly ICarService carService;

        public CarsController(ICarService carService) => this.carService = carService;

        [HttpPost]
        public async Task<IActionResult> Post(CreateCarRequest request)
        {
            var carInput = new CarInput(request.Make, request.Model, request.Type, request.ExteriorColor, request.InteriorColor, request.Year);
            int id = await this.carService.CreateAsync(carInput);
            return this.Created(string.Empty, id);
        }
    }
}
