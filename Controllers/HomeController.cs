using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using System.Threading.RateLimiting;

namespace rate_limiting.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        public HomeController() { }

        [HttpGet("action")]
        [EnableRateLimiting("fixed")]
        public IActionResult GetList()
        {
            var list = new List<Person>()
            {
                new Person()
                {
                    Id = 1,
                    Age = 20,
                    Name = "A",
                },
                new Person()
                {
                    Id = 2,
                    Age = 21,
                    Name = "B",
                },
                new Person()
                {
                    Id = 3,
                    Age = 22,
                    Name = "C",
                },
            };

            return Ok(list);
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
