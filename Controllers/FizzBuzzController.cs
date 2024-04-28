using Microsoft.AspNetCore.Mvc;
using FizzBuzzApp.Services; 

namespace FizzBuzzApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FizzBuzzController : ControllerBase
    {
        private readonly FizzBuzzService _fizzBuzzService;

        public FizzBuzzController(FizzBuzzServiceFactory fizzBuzzServiceFactory)
        {
            _fizzBuzzService = fizzBuzzServiceFactory.CreateFizzBuzzService();
        }

        [HttpGet("{inputValue}")]
        public IActionResult GetFizzBuzzResults(int inputValue)
        {
            if (inputValue <= 0)
            {
                return BadRequest("Please enter a positive integer.");
            }

            var results = _fizzBuzzService.GenerateFizzBuzzResults(inputValue);
            return Ok(results);
        }
    }
}
