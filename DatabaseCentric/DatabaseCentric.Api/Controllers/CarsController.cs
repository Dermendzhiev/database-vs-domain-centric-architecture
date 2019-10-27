namespace DatabaseCentric.Api.Controllers
{
    using System.Threading.Tasks;
    using DatabaseCentric.Api.Models;
    using DatabaseCentric.Application.Interfaces;
    using DatabaseCentric.Application.Models;
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
