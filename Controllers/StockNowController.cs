using Final10._14.Models;
using Final10._14.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Final10._14.Controllers
{
    public class StockNowController : Controller
    {

        private readonly WealthierAndKinderContext _context;

        public StockNowController(WealthierAndKinderContext context)
        {
            _context = context;
        }
        public IActionResult StockList(CKeywordViewModel vm)
        {
            string keyword = vm.txtKeyword;
            IEnumerable<Final10._14.Models.TStockInStock> datas = null;
            List<TStockInStock> list = null;
            if (string.IsNullOrEmpty(keyword))
                datas = from p in _context.TStockInStocks
                        select p;
            else
                datas = _context.TStockInStocks.Where(p => p.FMemberId.Contains(keyword) ||
                p.FStockName.Contains(keyword) ||
                (p.FStockId.ToString()).Contains(keyword));
            return View(datas);

        }

        public IActionResult Delete(int? id)
        {

            TStockInStock prod = _context.TStockInStocks.FirstOrDefault(p => p.FInStockId == id);
            if (prod != null)
            {
                _context.TStockInStocks.Remove(prod);
                _context.SaveChanges();
            }
            return RedirectToAction("StockList");
        }

        public ActionResult Edit(int? id)
        {
            TStockInStock prod = _context.TStockInStocks.FirstOrDefault(p => p.FInStockId == id);
            if (prod == null)
            {
                return RedirectToAction("StockList");
            }
            return View(prod);

        }

        [HttpPost]

        public ActionResult Edit(TStockInStock inProd)
        {
            TStockInStock dbprod = _context.TStockInStocks.FirstOrDefault(p => p.FInStockId == inProd.FInStockId);
            if (dbprod == null)
                return RedirectToAction("StockList");
            dbprod.FLeftStock = inProd.FLeftStock;
            dbprod.FStockNow = inProd.FStockNow;
            dbprod.FStockAdj = inProd.FStockAdj;
            dbprod.FStockTran = inProd.FStockTran;
            _context.SaveChanges();
            return RedirectToAction("Stock");

        }



    }
}
