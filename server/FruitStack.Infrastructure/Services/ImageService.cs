using FruitStack.Infrastructure.Interfaces;
using FruitStack.Models.Constans;
using FruitStack.Models.Responses;
using FruitStack.Models.Settings;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Json;

namespace FruitStack.Infrastructure.Services
{
    public class ImageService : IImageService
    {
        private readonly string _accessKey;
        private readonly HttpClient _httpClient;

        public ImageService(IHttpClientFactory httpClient, IOptions<UnsplashSettings> options)
        {
            _httpClient = httpClient.CreateClient(UnsplashConstans.Client);
            _accessKey = options.Value.AccessKey;
        }

        public async Task<IEnumerable<string>> GetImageAsync(string name, int items)
        {
            var result = await _httpClient.GetAsync($"/search/photos?query={name}&page=1&per_page={items}&client_id={_accessKey}");
            var json = await result.Content.ReadAsStringAsync();
            var jObject = JObject.Parse(json);
            var image = jObject["results"].Select(x => x["urls"].Value<string>("raw"));

            return image;
        }



    }
}
