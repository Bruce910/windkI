using Final10._14.Models;
using Final10._14.ViewModel.MatchViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

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
            var aaa = from p in _context.TMatches
                         join a in _context.THelps on p.FHelpId equals a.FHelpId
                         where p.FHelpId == a.FHelpId && a.FHelpStatus == 1
                         select new { a.FHelpId };
            

            ViewBag.kk = aaa.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(TProduct p)
        {
            if (ModelState.IsValid)
            {
                _context.TProducts.Add(p);
                _context.SaveChanges();
                return RedirectToAction("List");
            }
             return View(p);

        }

        public IActionResult Edit(int id)
        {
            TMatch p = _context.TMatches.FirstOrDefault(x => x.FMatchId == id);
            if(p==null)
                return RedirectToAction("List");
            return View(p);
        }
        [HttpPost]
        public IActionResult Edit(TMatch p)
        {
            TMatch p1 = _context.TMatches.FirstOrDefault(x => x.FMatchId == p.FMatchId);
            if(p1==null)
                return RedirectToAction("List");
           
            
            p1.FMatchDateTime = p.FMatchDateTime;
            p1.FMemberId = p.FMemberId;
            p1.FMatchDateTime = p.FMatchDateTime;
            p1.FPoint = p.FPoint;
            p1.FMatchStatus = p.FMatchStatus;
            p1.FGradeDateTime=p.FGradeDateTime;
            p1.FMessage = p.FMessage;
            _context.SaveChanges();

            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            TMatch p = _context.TMatches.FirstOrDefault(x => x.FMatchId == id);
            if(p==null)
                return RedirectToAction("List");
            _context.TMatches.Remove(p);
            _context.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
