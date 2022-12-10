using ArtSpawn.Models.Requests;
using FruitStack.Models;
using FruitStack.Models.Responses;

namespace FruitStack.Infrastructure.Interfaces
{
    public interface IFruitService
    {
        Task<PagedModel<FruitResponse>> GetFruitListAsync(PagingRequest pagingRequest, CancellationToken cancellationToken);
    }
}
