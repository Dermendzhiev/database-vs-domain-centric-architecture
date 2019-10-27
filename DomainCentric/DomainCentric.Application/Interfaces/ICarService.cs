namespace DomainCentric.Application.Interfaces
{
    using System.Threading.Tasks;
    using DomainCentric.Application.Models;

    public interface ICarService
    {
        Task<int> CreateAsync(CarInput input);
    }
}
