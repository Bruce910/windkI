using Final10._14.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final10._14.Controllers
{
    public class MatchController : Controller
    {
        public IActionResult List()
        {
            WealthierAndKinderContext windki =new WealthierAndKinderContext();
            var datas=from p in windki.
            return View();
        }

        public IActionResult Add()
        {
            
            return View();
            
        }
    }
}
