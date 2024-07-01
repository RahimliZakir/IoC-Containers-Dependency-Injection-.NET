using Microsoft.AspNetCore.Mvc;
using Project.WebUI.AppCode;

namespace Project.WebUI.Controllers
{
    public class HomeController : Controller
    {
        readonly RandomNumberGenerator randomNumberGenerator;
        readonly RandomNumberGenerator randomNumberGenerator2;
        public HomeController(RandomNumberGenerator randomNumberGenerator, RandomNumberGenerator randomNumberGenerator2)
        {
            this.randomNumberGenerator = randomNumberGenerator;
            this.randomNumberGenerator2 = randomNumberGenerator2;
        }

        public IActionResult Index()
        {
            ViewBag.RandomNumber = randomNumberGenerator.Random;
            ViewBag.RandomNumber2 = randomNumberGenerator2.Random;

            ViewBag.Guid = randomNumberGenerator.Guid;
            ViewBag.Guid2 = randomNumberGenerator2.Guid;

            return View();
        }
    }
}
