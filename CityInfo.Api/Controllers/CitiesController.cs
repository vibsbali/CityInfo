using CityInfo.API;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetCities()
        {
            var result = CitiesDataStore.Current.Cities;

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public JsonResult GetCity(int id)
        {
            var result = CitiesDataStore.Current.Cities.Where(c => c.Id == id);

            return new JsonResult(result);
        }
    }
}
