using FruitStack.Models.Responses;

namespace FruitStack.Infrastructure.Interfaces
{
    public interface IFruitService
    {
        Task<IEnumerable<FruitResponse>> GetFruitListAsync(); 
    }
}
