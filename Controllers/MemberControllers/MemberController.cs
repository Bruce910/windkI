using Castle.Core.Resource;
using Final10._14.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Net.WebRequestMethods;
using System.Security;

namespace Final10._14.Controllers.MemberControllers
{
    public class MemberController(WealthierAndKinderContext context) : Controller
    {
        // GET: MemberController
        public ActionResult Index()
        {
            IEnumerable<TEmployeeMember> datas = context.TEmployeeMembers;

            return View(datas);
        }
        public async Task<IActionResult> PartialList()
        {
            //Customer c = await _context.Customers.FindAsync(id);
            IEnumerable<TEmployeeMember> datas = context.TEmployeeMembers;
            return PartialView("_listPartial", datas);
        }
        // GET: MemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TEmployeeMember newEmp)
        {
            Console.WriteLine("callled!!!!!!!!!!");
            context.TEmployeeMembers.Add(newEmp);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<string> AjaxCreate(TEmployeeMember newEmp)
        {
            Console.WriteLine("callled!!!!!!!!!!");
            context.TEmployeeMembers.Add(newEmp);
            context.SaveChanges();
            return "succ";

        }
        // GET: MemberController/Edit/5
        public ActionResult Edit(int id)
        {
            TEmployeeMember ?r = context.TEmployeeMembers.FirstOrDefault(x => x.FEmployeeSid == id);
            if (r == null)
                return RedirectToAction("Index");
            return View(r);
        }

        // POST: MemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TEmployeeMember newEmp)
        {
            TEmployeeMember customerDb = context.TEmployeeMembers.FirstOrDefault(x => x.FEmployeeSid == id);
            if (customerDb != null)
            {
                customerDb.FMemberId = newEmp.FMemberId;
                customerDb.FAccount = newEmp.FAccount;
                customerDb.FPassword = newEmp.FPassword;
                customerDb.FUserName = newEmp.FUserName;
                customerDb.FFirstName = newEmp.FFirstName;
                customerDb.FLastName = newEmp.FLastName;
                customerDb.FEmail = newEmp.FEmail;
                customerDb.FIdentification = newEmp.FIdentification;
                customerDb.FSex = newEmp.FSex;
                customerDb.FStatus = newEmp.FStatus;
                customerDb.FPermissions = newEmp.FPermissions;
                customerDb.FIp = newEmp.FIp;
                customerDb.FMemberImagePath = newEmp.FMemberImagePath;
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // GET: MemberController/Delete/5
        public ActionResult Delete(int id)
        {
            if (id != null)
            {
                TEmployeeMember r = context.TEmployeeMembers.FirstOrDefault(x => x.FEmployeeSid == id);
                if (r != null)
                {
                    context.TEmployeeMembers.Remove(r);
                    context.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }

        // POST: MemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
