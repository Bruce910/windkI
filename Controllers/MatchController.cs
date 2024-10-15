using Microsoft.AspNetCore.Mvc;

namespace Final10._14.Controllers
{
    public class MatchController : Controller
    {
        public IActionResult List()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
