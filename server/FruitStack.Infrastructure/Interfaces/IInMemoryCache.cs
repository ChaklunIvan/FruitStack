using FruitStack.Models.Constans;

namespace FruitStack.Infrastructure.Interfaces
{
    public interface IInMemoryCache<TModel> where TModel : class
    {
        Task<IEnumerable<TModel>> GetCacheModelsAsync(Func<string, int, IEnumerable<TModel>> predicate, string key);
    }
}
