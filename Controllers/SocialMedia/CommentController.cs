using Final10._14.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Final10._14.Controllers.SocialMedia
{
    public class CommentController : Controller
    {
        private readonly WealthierAndKinderContext _db;

        public CommentController(WealthierAndKinderContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> List()
        {
            var comments = await (from comment in _db.TComments
                                  join person in _db.TPersonMembers
                                  on comment.FUserId equals person.FPersonSid
                                  select new
                                  {
                                      Comment = comment,
                                      UserName = person.FUserName
                                  }).ToListAsync();

            return View(comments);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TComment comment)
        {
            if (ModelState.IsValid)
            {
                _db.TComments.Add(comment);
                _db.SaveChanges();
                return RedirectToAction(nameof(List));
            }
            return View(comment);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var comment = await _db.TComments
                .Include(c => c.FUser)  // 假設有一個 FUser 導航屬性
                .FirstOrDefaultAsync(c => c.FCommentId == id);

            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var comment = await _db.TComments.FindAsync(id);
            if (comment != null)
            {
                _db.TComments.Remove(comment);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(List));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var comment = await _db.TComments
                .Include(c => c.FUser)
                .FirstOrDefaultAsync(c => c.FCommentId == id);

            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FCommentId,FPostId,FUserId,FContent")] TComment comment)
        {
            if (id != comment.FCommentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _db.Update(comment);
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(List));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommentExists(comment.FCommentId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return View(comment);
        }

        private bool CommentExists(int id)
        {
            return _db.TComments.Any(e => e.FCommentId == id);
        }
    }
}
