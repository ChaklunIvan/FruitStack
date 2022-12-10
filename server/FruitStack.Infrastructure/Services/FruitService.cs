using ArtSpawn.Models.Requests;
using AutoMapper;
using FruitStack.Infrastructure.Extensions;
using FruitStack.Infrastructure.Interfaces;
using FruitStack.Models;
using FruitStack.Models.Constans;
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

        public async Task<PagedModel<FruitResponse>> GetFruitListAsync(PagingRequest pagingRequest, CancellationToken cancellationToken)
        {
            var result = await _httpClient.GetAsync("/api/fruit/all", cancellationToken);
            var fruityvice = await result.Content.ReadFromJsonAsync<IEnumerable<FruityviceResponse>>();
            var fruits = _mapper.Map<IEnumerable<FruitResponse>>(fruityvice);

            var pagedFrutis = fruits.Paginate(pagingRequest);

            return pagedFrutis;
        }
    }
}
