using ArtSpawn.Models.Requests;
using FruitStack.Models;

namespace FruitStack.Infrastructure.Interfaces
{
    public interface ICacheManager<TModel>
    {
        Task<PagedModel<TModel>> GetCache(string key, Func<Task<PagedModel<TModel>>> items, PagingRequest pagingRequest);
    }
}
