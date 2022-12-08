using FruitStack.Models.Responses;

namespace FruitStack.Infrastructure.Interfaces
{
    public interface IImageService
    {
        Task<IEnumerable<string>> GetImageAsync(string name, int items);
    }
}
