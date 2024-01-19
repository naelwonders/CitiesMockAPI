using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/file")]
    public class FilesController : Controller
    {
        [HttpGet("{fileId}")]
        public IActionResult GetFile(string fileId)
        {
            // I placed a test PDF file in my project, I have modified the output properties to always copy

            var pathToFile = "charter.pdf";

            if (System.IO.File.Exists(pathToFile))
            {
                return NotFound();
            }

            var bytes = System.IO.File.ReadAllBytes(pathToFile);
            return File(bytes, "??", Path.GetFileName(pathToFile));
        }
    }
}
