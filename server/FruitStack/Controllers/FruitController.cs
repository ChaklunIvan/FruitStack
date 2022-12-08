using FruitStack.Infrastructure.Interfaces;
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
        private readonly IFruitService _fruitService;

        public FruitController(IFruitService fruitService)
        {
            _fruitService = fruitService;
        }

        [HttpGet]
        public async Task<ActionResult<FruitResponse>> GetAllFruits()
        {
            var fruits = await _fruitService.GetFruitListAsync();

            return Ok(fruits);
        }
    }
}
