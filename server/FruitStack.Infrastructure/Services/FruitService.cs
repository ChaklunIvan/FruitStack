using AutoMapper;
using FruitStack.Infrastructure.Interfaces;
using FruitStack.Models.Constans;
using FruitStack.Models.Pagination;
using FruitStack.Models.Responses;
using System.Net.Http.Json;

namespace FruitStack.Infrastructure.Services
{
    public class FruitService : IFruitService
    {
        private readonly HttpClient _httpClient;
        private readonly IMapper _mapper;

        public FruitService(IHttpClientFactory httpClient, IMapper mapper)
        {
            _httpClient = httpClient.CreateClient(FruityviceConstans.Client);
            _mapper = mapper;
        }

        public async Task<PagedModel<FruitResponse>> GetFruitListAsync(PagingSettings pagingSettings, CancellationToken cancellationToken)
        {
            var result = await _httpClient.GetAsync("/api/fruit/all", cancellationToken);
            var apiResponse = await result.Content.ReadFromJsonAsync<IEnumerable<FruityviceResponse>>(cancellationToken: cancellationToken);

            var pagedApiResponse = apiResponse.Skip((pagingSettings.CurrentPage - 1) * pagingSettings.PageSize)
                                              .Take(pagingSettings.PageSize);

            var fruits = _mapper.Map<IEnumerable<FruitResponse>>(pagedApiResponse);

            var pagedModel = new PagedModel<FruitResponse>()
            {
                CurrentPage = pagingSettings.CurrentPage,
                PageSize = pagingSettings.PageSize,
                Items = fruits,
                TotalCount = apiResponse.Count(),
                TotalPages = (int)Math.Ceiling(apiResponse.Count() / (double)pagingSettings.PageSize)
            };

            return pagedModel;
        }
    }
}
