using FruitStack.Infrastructure.Interfaces;
using FruitStack.Models.Pagination;
using FruitStack.Models.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FruitStack.Controllers
{
    [Route("api/fruits")]
    [ApiController]
    public class FruitController : ControllerBase
    {
        private readonly IFruitService _fruitService;
        private readonly IMemoryCache _memoryCache;

        public FruitController(IFruitService fruitService, IMemoryCache memoryCache)
        {
            _fruitService = fruitService;
            _memoryCache = memoryCache;
        }

        [HttpGet]
        public async Task<ActionResult<FruitResponse>> GetAllFruits([FromQuery] PagingSettings pagingSettings, CancellationToken cancellationToken)
        {
            var cacheKey = string.Join(", ", pagingSettings.PageSize, pagingSettings.CurrentPage);

            var fruits = await _memoryCache.GetOrCreateAsync(cacheKey, async cache => await _fruitService.GetFruitListAsync(pagingSettings, cancellationToken));

            return Ok(fruits);
        }
    }
}
