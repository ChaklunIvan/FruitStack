using ArtSpawn.Models.Requests;
using FruitStack.Infrastructure.Interfaces;
using FruitStack.Models;
using Microsoft.Extensions.Caching.Memory;

namespace FruitStack.Infrastructure.Helpers
{
    public class CacheManager<TModel> : ICacheManager<TModel>
    {
        private readonly IMemoryCache _memoryCache;

        public CacheManager(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public async Task<PagedModel<TModel>> GetCache(string key, Func<Task<PagedModel<TModel>>> items, PagingRequest pagingRequest)
        {
            var output = await _memoryCache.GetOrCreateAsync(key, entry =>
            {
                return items.Invoke();
            });

            if (pagingRequest.PageSize != output.PageSize || pagingRequest.PageNumber != output.CurrentPage)
            {
                var fruits = await items.Invoke();
                output = _memoryCache.Set(key, fruits);
            }

            return output;
        }
    }
}
