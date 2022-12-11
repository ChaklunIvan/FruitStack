using ArtSpawn.Models.Requests;
using AutoMapper;
using FruitStack.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace FruitStack.Infrastructure.Extensions
{
    public static class PaginationExtensions
    {
        /// <summary>
        /// Asynchronous method to paginate list of TModel
        /// </summary>
        /// <typeparam name="TModel">Model taken from the database</typeparam>
        /// <param name="source">Queryble list of models</param>
        /// <param name="pagingRequest">Paging parameters</param>
        /// <param name="cancellationToken"></param>
        /// <returns>Paged list</returns>
        public static async Task<PagedModel<TModel>> PaginateAsync<TModel>(this IQueryable<TModel> source, PagingRequest pagingRequest, CancellationToken cancellationToken) where TModel : class
        {
            var count = await source.CountAsync(cancellationToken);
            var items = await source.ItemsOnPageQueryble(pagingRequest)
                                    .ToListAsync(cancellationToken);

            var page = items.ToPagedModel(pagingRequest, count);

            return page;
        }

        /// <summary>
        /// Paginate List of TModel
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="source">IEnumerable list of TModel</param>
        /// <param name="pagingRequest">Paging parameters</param>
        /// <returns>Paged list</returns>
        public static PagedModel<TModel> Paginate<TModel>(this IEnumerable<TModel> source, PagingRequest pagingRequest, int count) where TModel : class
        {
            var page = source.ToPagedModel(pagingRequest, count);

            return page;
        }

        /// <summary>
        /// Calculate items on page.
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="source">IEnumerable list of TModel</param>
        /// <param name="pagingRequest">Paging parameters</param>
        /// <returns>Items on the page </returns>
        public static IEnumerable<TModel> ItemsOnPage<TModel>(this IEnumerable<TModel> source, PagingRequest pagingRequest) where TModel : class
        {
            var items = source.Skip((pagingRequest.PageNumber - 1) * pagingRequest.PageSize)
                              .Take(pagingRequest.PageSize);
            return items;
        }

        /// <summary>
        /// Calculate items on page
        /// </summary>
        /// <typeparam name="TModel">Model taken from the database</typeparam>
        /// <param name="source">Queryble list of models</param>
        /// <param name="pagingRequest">Paging parameters</param>
        /// <returns>Queryable items on the page </returns>
        public static IQueryable<TModel> ItemsOnPageQueryble<TModel>(this IQueryable<TModel> source, PagingRequest pagingRequest) where TModel : class
        {
            var items = source.ItemsOnPage(pagingRequest).AsQueryable();
            return items;
        }

        /// <summary>
        /// Create instance of PageModel<TModel>
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="items">Items on page</param>
        /// <param name="pagingRequest">Paging parameters</param>
        /// <param name="count"></param>
        /// <returns>instance of PagedModel<TModel></returns>
        private static PagedModel<TModel> ToPagedModel<TModel>(this IEnumerable<TModel> items, PagingRequest pagingRequest, int count) where TModel : class
        {
            var page = new PagedModel<TModel>()
            {
                CurrentPage = pagingRequest.PageNumber,
                PageSize = pagingRequest.PageSize,
                TotalCount = count,
                TotalPages = (int)Math.Ceiling(count / (double)pagingRequest.PageSize),
                Items = items
            };

            return page;
        }
    }
}
