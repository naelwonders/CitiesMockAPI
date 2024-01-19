using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers

{
    //this is an attribute (=tag) used to mark a controller class: this helps returning problems when they occur automatically
    [ApiController]

    //using the rout attributes allows to not repeat it later next to httpget
    //the name cities, matches the name of our controller, so we could write [controller] instead of cities here (but not the best in api because if we change the class name, this will be annoying)
    [Route("api/cities")]


    //inherits from controllerBase, it contains basic features controllers need in an mvc architecturegsfsefvgfdgdf
    public class CitiesController : ControllerBase
    {
        //*** ACTIONS ***
        //methods that returns data

        //*** GET ALL CITIES ***
        [HttpGet]
        public ActionResult<IEnumerable<CityDto>> GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
            //else, return and empty list which is a valid resonse
        }
        //*** GET ONE CITY ***
        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id)
        {
            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);

            if (cityToReturn == null) 
            {
                return NotFound();
            }

            return Ok(cityToReturn);

        }
    }
}
