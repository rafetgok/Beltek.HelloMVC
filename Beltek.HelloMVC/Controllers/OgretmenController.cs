using Microsoft.AspNetCore.Mvc;

namespace Beltek.HelloMVC.Controllers
{
    public class OgretmenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult AddTeacher()
        {
            return View();
        }

        //[HttpPost]



    }
}
