using Microsoft.AspNetCore.Mvc;
using SuperHeroWebAPI.Entities;

namespace SuperHeroWebAPI.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {

        [HttpGet]

        public async Task<IActionResult> GetAllHeros()
        {
            var heroes = new List<SuperHero>{
                new SuperHero
                {
                    Id = 1,
                    Name = "Spider-Man",
                    FirstName = "Peter",
                    LastName = "Parker",
                    Place = "New York City"
                }
            };

            return Ok(heroes);
        }
    }
}