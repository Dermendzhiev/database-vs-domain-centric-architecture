namespace DomainCentric.Application.Interfaces.Repositories
{
    using System.Threading.Tasks;
    using DomainCentric.Application.Domain;

    public interface ICarRepository
    {
        Task<int> CreateAsync(Car car);
    }
}
