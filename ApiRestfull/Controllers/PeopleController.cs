using Microsoft.AspNetCore.Mvc;

namespace ApiRestfull.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult Get(string id) 
        {
            People people = new People();

            return Ok(new { people.Geolocalizacao, people.PeopleId });
        }
    }
}