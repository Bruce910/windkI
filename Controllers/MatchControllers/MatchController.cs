using Microsoft.AspNetCore.Mvc;

namespace Final10._14.Controllers.MatchControllers
{
    public class MatchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
