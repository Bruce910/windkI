using Final10._14.Models;
using Final10._14.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Final10._14.Controllers
{
    public class InvestmentAccountController : Controller
    {

        private readonly WealthierAndKinderContext _context;

        public InvestmentAccountController(WealthierAndKinderContext context)
        {
            _context = context;
        }

        public IActionResult InvestList(CKeywordViewModel vm)
        {
            string keyword = vm.txtKeyword;
            IEnumerable<Final10._14.Models.TCustomerInvestAccount> datas = null;
            List<TCustomerInvestAccount> list = null;
            if (string.IsNullOrEmpty(keyword))
                datas = from p in _context.TCustomerInvestAccounts
                        select p;
            else
                datas = _context.TCustomerInvestAccounts.Where(p => p.FMemberId.Contains(keyword) ||
                p.FMemberId.Contains(keyword) ||
                (p.FBrokerId.ToString()).Contains(keyword));
            return View(datas);

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(TCustomerInvestAccount p)
        {
            
            _context.TCustomerInvestAccounts.Add(p);
            _context.SaveChanges();
            return RedirectToAction("InvestList");
        }

        public IActionResult Delete(int? id)
        {

            TCustomerInvestAccount prod = _context.TCustomerInvestAccounts.FirstOrDefault(p => p.FInvestAccountId == id);
            if (prod != null)
            {
                _context.TCustomerInvestAccounts.Remove(prod);
                _context.SaveChanges();
            }
            return RedirectToAction("InvestList");
        }

        public ActionResult Edit(int? id)
        {
            TCustomerInvestAccount prod = _context.TCustomerInvestAccounts.FirstOrDefault(p => p.FInvestAccountId == id);
            if (prod == null)
            {
                return RedirectToAction("InvestList");
            }
            return View(prod);
           
        }

        [HttpPost]

        public ActionResult Edit(TCustomerInvestAccount inProd)
        {
            TCustomerInvestAccount dbprod = _context.TCustomerInvestAccounts.FirstOrDefault(p => p.FInvestAccountId == inProd.FInvestAccountId);
            if (dbprod == null)
                return RedirectToAction("InvestList");
            dbprod.FInvestAccount = inProd.FInvestAccount;
            dbprod.FBrokerId = inProd.FBrokerId;
            dbprod.FInvestPass = inProd.FInvestPass;            
            _context.SaveChanges();
            return RedirectToAction("InvestList");

        }


      


    }
}
