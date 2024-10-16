using Microsoft.AspNetCore.Mvc;

namespace Final10._14.Controllers.AccountControllers
{
    // ReSharper disable once InconsistentNaming
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
