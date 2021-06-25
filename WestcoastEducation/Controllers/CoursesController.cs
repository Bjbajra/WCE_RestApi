using Microsoft.AspNetCore.Mvc;

namespace WestcoastEducation.Controllers
{
    [Route("courses")]
    public class CoursesController : Controller
    {
        [HttpGet()]
        [Route("index")]
        public IActionResult Index()
        {
            //return Content("Hej Hej");
            return View("Index");
        }
    }
}