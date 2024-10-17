using Final10._14.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final10._14.Controllers.MatchControllers
{
    public class MatchController : Controller
    {
        public IActionResult List()
        {
            WealthierAndKinderContext windki = new WealthierAndKinderContext();
            var datas = from p in windki.TMatches
                        select p;
            return View(datas);
        }

        public IActionResult Create()
        {

            return View();

        }
        [HttpPost]
        public IActionResult Create(TMatch p)
        {
            WealthierAndKinderContext windki = new WealthierAndKinderContext();
            windki.TMatches.Add(p);
            windki.SaveChanges();
            return RedirectToAction("List");
        }

        public IActionResult Edit(int id)
        {
            WealthierAndKinderContext windki = new WealthierAndKinderContext();
            TMatch data = windki.TMatches.FirstOrDefault(p => p.FMatchId == id);
            if (data == null)
                return RedirectToAction("List");
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(TMatch p)
        {
            WealthierAndKinderContext windki = new WealthierAndKinderContext();
            TMatch data = windki.TMatches.FirstOrDefault(x => x.FMatchId == p.FMatchId);
            if (data == null)
                return RedirectToAction("List");
            if (data != null)
            {
                data.FHelpId = p.FHelpId;
                data.FMemberId = p.FMemberId;
                data.FMatchDateTime = p.FMatchDateTime;
                data.FPoint = p.FPoint;
                data.FMatchStatus = p.FMatchStatus;
                data.FGrade = p.FGrade;
                data.FGradeDateTime = p.FGradeDateTime;
                data.FMessage = p.FMessage;
                windki.SaveChanges();
            }
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            WealthierAndKinderContext windki = new WealthierAndKinderContext();
            TMatch data = windki.TMatches.FirstOrDefault(p => p.FMatchId == id);
            if (data != null)
            {
                windki.TMatches.Remove(data);
                windki.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}
