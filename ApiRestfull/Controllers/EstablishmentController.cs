using Microsoft.AspNetCore.Mvc;

namespace ApiRestfull.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstablishmentController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string geolocalizacao) 
        {
            People people = new People();

            return Ok(new { people.Geolocalizacao, people.PeopleId});
        }
    }
}