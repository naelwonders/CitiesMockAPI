using Microsoft.AspNetCore.Mvc;
using CityInfo.API.Models;

namespace CityInfo.API.Controllers
{
    //this is an attribute (=tag) used to mark a controller class: this helps returning problems when they occur automatically
    [ApiController]

    //using the rout attributes allows to not repeat it later next to httpget
    //the name cities, matches the name of our controller, so we could write [controller] instead of cities here (but not the best in api because if we change the class name, this will be annoying)
    [Route("api/cities/{cityId}/pointsofinterest")]

    public class PointsOfInterestController : Controller
    {
        
        [HttpGet]
        public ActionResult<IEnumerable<PointsOfInterestsDto>> GetPointsOfInterest(int cityId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (city == null)
            {
                return NotFound();
            }

            return Ok(city.PointsOfInterest);
        }

        [HttpGet("{pointofinterestid}")]
        public ActionResult<IEnumerable<PointsOfInterestsDto>> GetOnePointOfInterest(int cityId, int pointOfInterestId)
        {
            //first we need to check that the city exists indeed
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (city == null)
            {
                return NotFound();
            }

            //then if the point of interest exists
            var pointOfInterest = city.PointsOfInterest.FirstOrDefault(p => p.Id == pointOfInterestId);

            if (pointOfInterest == null)
            {
                return NotFound();
            }

            return Ok(pointOfInterest);
        }

    }
}
