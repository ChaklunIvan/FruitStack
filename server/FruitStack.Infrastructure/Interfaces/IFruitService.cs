using FruitStack.Models.Pagination;
using FruitStack.Models.Responses;

namespace FruitStack.Infrastructure.Interfaces
{
    public interface IFruitService
    {
        Task<PagedModel<FruitResponse>> GetFruitListAsync(PagingSettings pagingRequest, CancellationToken cancellationToken);
    }
}
