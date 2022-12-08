using AutoMapper;
using FruitStack.Infrastructure.Interfaces;
using FruitStack.Models.Constans;
using FruitStack.Models.Responses;
using System.Net.Http.Json;

namespace FruitStack.Infrastructure.Services
{
    public class FruitService : IFruitService
    {
        private readonly HttpClient _httpClient;
        private readonly IImageService _imageService;
        private readonly IMapper _mapper;

        public FruitService(IHttpClientFactory httpClient, IImageService imageService, IMapper mapper)
        {
            _httpClient = httpClient.CreateClient(FruityviceConstans.Client);
            _imageService = imageService;
            _mapper = mapper;
        }
        public async Task<IEnumerable<FruitResponse>> GetFruitListAsync()
        {
            var result = await _httpClient.GetAsync("/api/fruit/all");
            var fruityvice = await result.Content.ReadFromJsonAsync<IEnumerable<FruityviceResponse>>();

            var fruits = _mapper.Map<IEnumerable<FruitResponse>>(fruityvice);

            return fruits;
        }
    }
}
