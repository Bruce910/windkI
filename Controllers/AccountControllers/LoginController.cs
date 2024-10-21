using System.Text.Json;
using Final10._14.Models;
using Final10._14.TModels.MemberModels;
using Final10._14.TModels.MemberModels.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Final10._14.Controllers;

namespace Final10._14.Controllers.AccountControllers
{
    // ReSharper disable once InconsistentNaming
    public class LoginController(WealthierAndKinderContext context) : Controller
    {

        public IActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Login(CLoginViewModel vm)
        {

            //Console.WriteLine(vm);
            TEmployeeMember user = context.TEmployeeMembers.FirstOrDefault(
                t => t.FAccount.Equals(vm.txtAccount) && t.FPassword.Equals(vm.txtPassword));
            if ( (vm.txtAccount=="admin"&& vm.txtPassword == "1234") ||(user != null && user.FPassword.Equals(vm.txtPassword)) )
            {
                string json = JsonSerializer.Serialize(user);
                HttpContext.Session.SetString(CDictionary.SK_LOGIN_MEMBER, json);
                return RedirectToAction("Index","Home");
            }
            return View();
        }

    }
}
