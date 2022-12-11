using FruitStack.Infrastructure.Interfaces;
using FruitStack.Models.Constans;
using Microsoft.Extensions.Caching.Memory;

namespace FruitStack.Infrastructure.Helpers
{
    public class InMemoryCache<TModel> : IInMemoryCache<TModel> where TModel : class
    {
        private readonly IMemoryCache _memoryCache;

        public InMemoryCache(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public Task<IEnumerable<TModel>> GetCacheModelsAsync(Func<string, int, IEnumerable<TModel>> predicate, string key)
        {
            throw new NotImplementedException();
        }
    }
}
