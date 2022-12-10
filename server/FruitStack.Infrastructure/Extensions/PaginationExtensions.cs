using ArtSpawn.Models.Requests;
using FruitStack.Models;
using Microsoft.EntityFrameworkCore;

namespace FruitStack.Infrastructure.Extensions
{
    public static class PaginationExtensions
    {
        public static async Task<PagedModel<T>> PaginateAsync<T>(this IQueryable<T> source, PagingRequest pagingRequest, CancellationToken cancellationToken) where T : class
        {
            var count = await source.CountAsync(cancellationToken);
            var items = await source.Skip((pagingRequest.PageNumber - 1) * pagingRequest.PageSize)
                                    .Take(pagingRequest.PageSize)
                                    .ToListAsync(cancellationToken);

            var page = new PagedModel<T>()
            {
                CurrentPage = pagingRequest.PageNumber,
                PageSize = pagingRequest.PageSize,
                TotalCount = count,
                TotalPages = pagingRequest.PageSize != 0 ? (int)Math.Ceiling(count / (double)pagingRequest.PageSize) : pagingRequest.PageSize,
                Items = items
            };

            return page;
        }

        public static PagedModel<T> Paginate<T>(this IEnumerable<T> source, PagingRequest pagingRequest) where T : class
        {
            var count = source.Count();
            var items = source.Skip((pagingRequest.PageNumber - 1) * pagingRequest.PageSize)
                              .Take(pagingRequest.PageSize);

            var page = new PagedModel<T>()
            {
                CurrentPage = pagingRequest.PageNumber,
                PageSize = pagingRequest.PageSize,
                TotalCount = count,
                TotalPages = pagingRequest.PageSize != 0 ? (int)Math.Ceiling(count / (double)pagingRequest.PageSize) : pagingRequest.PageSize,
                Items = items
            };

            return page;
        }
    }
}
