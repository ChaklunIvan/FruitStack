using ArtSpawn.Models.Requests;
using AutoMapper;
using FruitStack.Infrastructure.Extensions;
using FruitStack.Infrastructure.Interfaces;
using FruitStack.Models;
using FruitStack.Models.Constans;
using FruitStack.Models.Responses;
using Microsoft.Extensions.Caching.Memory;
using System.Net.Http.Json;
using System.Security.Cryptography;

namespace FruitStack.Infrastructure.Services
{
    public class FruitService : IFruitService
    {
        private readonly HttpClient _httpClient;
        private readonly IMapper _mapper;
        private readonly IMemoryCache _memoryCache;

        public FruitService(IHttpClientFactory httpClient, IMapper mapper, IMemoryCache memoryCache)
        {
            _httpClient = httpClient.CreateClient(FruityviceConstans.Client);
            _mapper = mapper;
            _memoryCache = memoryCache;
        }

        public async Task<PagedModel<FruitResponse>> GetFruitListAsync(PagingRequest pagingRequest, CancellationToken cancellationToken)
        {
            var result = await _httpClient.GetAsync("/api/fruit/all", cancellationToken);
            var apiResponse = await result.Content.ReadFromJsonAsync<IEnumerable<FruityviceResponse>>(cancellationToken: cancellationToken);

            var pagedApiResponse = apiResponse.ItemsOnPage(pagingRequest);

            var fruits = _mapper.Map<IEnumerable<FruitResponse>>(pagedApiResponse);
            
            var pagedFruits = fruits.Paginate(pagingRequest);

            return pagedFruits;
        }
    }
}
