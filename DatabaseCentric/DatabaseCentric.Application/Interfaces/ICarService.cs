namespace DatabaseCentric.Application.Interfaces
{
    using System.Threading.Tasks;
    using DatabaseCentric.Application.Models;

    public interface ICarService
    {
        Task<int> CreateAsync(CarInput input);
    }
}
