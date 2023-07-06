using CityInfo.API;
using CityInfo.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<CityDto> GetCities()
        {
            var result = CitiesDataStore.Current.Cities;

            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id)
        {
            var result = CitiesDataStore.Current.Cities.Where(c => c.Id == id);

            if (!result.Any())
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
