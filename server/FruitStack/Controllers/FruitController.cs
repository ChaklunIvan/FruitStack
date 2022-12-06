using FruitStack.Models.Constans;
using FruitStack.Models.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FruitStack.Controllers
{
    [Route("api/fruits")]
    [ApiController]
    public class FruitController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public FruitController(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient.CreateClient(FruityviceConstans.Client);
        }

        [HttpGet]
        public async Task<ActionResult<FruitResponse>> GetAllFruits()
        {
            var result = await _httpClient.GetAsync("/api/fruit/all");
            var fruits = await result.Content.ReadFromJsonAsync<IEnumerable<FruitResponse>>();

            return Ok(fruits);
        }
    }
}
