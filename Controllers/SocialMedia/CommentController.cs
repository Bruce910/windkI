using Final10._14.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final10._14.Controllers.SocialMedia
{
    public class CommentController : Controller
    {
        public IActionResult List()
        {
            WealthierAndKinderContext db = new WealthierAndKinderContext();

            var comments = from c in db.TComments
                           select c;

            return View(comments);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TComment comment)
        {
          return View();
        }

        public IActionResult Delete(int id)
        {
            WealthierAndKinderContext db = new WealthierAndKinderContext();
            var comment = db.TComments.Find(id);
            return View(comment);
        }
        
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            WealthierAndKinderContext db = new WealthierAndKinderContext();
            var comment = db.TComments.Find(id);
            if (comment != null)
            {
                db.TComments.Remove(comment);
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }

        public IActionResult Edit(int id)
        {
            WealthierAndKinderContext db = new WealthierAndKinderContext();
            var comment = db.TComments.Find(id);
            return View(comment);
        }

        [HttpPost]
        public IActionResult Edit(TComment comment)
        {
            
            return View();
        }       

        

    }
}
