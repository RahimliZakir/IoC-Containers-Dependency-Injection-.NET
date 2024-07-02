using Microsoft.AspNetCore.Mvc;
using Project.WebUI.AppCode;

namespace Project.WebUI.Controllers
{
    public class HomeController(IRandomNumberGenerator randomNumberGenerator, IRandomNumberGenerator randomNumberGenerator2) : Controller
    {
        readonly IRandomNumberGenerator randomNumberGenerator = randomNumberGenerator;
        readonly IRandomNumberGenerator randomNumberGenerator2 = randomNumberGenerator2;

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
