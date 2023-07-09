using CityInfo.API;
using CityInfo.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly CitiesDataStore _citiesDataStore;

        public CitiesController(CitiesDataStore citiesDataStore)
        {
            _citiesDataStore = citiesDataStore;
        }

        [HttpGet]
        public ActionResult<CityDto> GetCities()
        {
            var result = _citiesDataStore.Cities;

            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id)
        {
            var result = _citiesDataStore.Cities.Where(c => c.Id == id);

            if (!result.Any())
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
