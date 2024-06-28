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
            ViewBag.RandomNumber = randomNumberGenerator.GenerateRandomNumber();
            ViewBag.RandomNumber2 = randomNumberGenerator2.GenerateRandomNumber();

            return View();
        }
    }
}
