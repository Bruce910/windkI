using Final10._14.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final10._14.Controllers.MatchControllers
{
    public class MController : Controller
    {

        private readonly WealthierAndKinderContext _context;
        public MController(WealthierAndKinderContext context)
        {
            _context = context;
        }
        public IActionResult List()
        {
            var q = _context.TMatches;
            return View(q);
        }

        public IActionResult Create()
        {
            return View();
        }

    }
}
