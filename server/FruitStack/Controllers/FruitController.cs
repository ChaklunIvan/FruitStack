using ArtSpawn.Models.Requests;
using FruitStack.Infrastructure.Interfaces;
using FruitStack.Models.Constans;
using FruitStack.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace FruitStack.Controllers
{
    [Route("api/fruits")]
    [ApiController]
    public class FruitController : ControllerBase
    {
        private readonly IFruitService _fruitService;
        private readonly ICacheManager<FruitResponse> _cacheManager;

        public FruitController(IFruitService fruitService, ICacheManager<FruitResponse> cacheManager)
        {
            _fruitService = fruitService;
            _cacheManager = cacheManager;
        }

        [HttpGet]
        public async Task<ActionResult<FruitResponse>> GetAllFruits([FromQuery]PagingRequest pagingRequest, CancellationToken cancellationToken)
        {
            var fruits = await _cacheManager.GetCache(CacheKeyConstans.FruitsKey, () => _fruitService.GetFruitListAsync(pagingRequest, cancellationToken), pagingRequest);

            return Ok(fruits);
        }
    }
}
