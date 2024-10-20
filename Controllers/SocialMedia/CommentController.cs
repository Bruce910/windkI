using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.Json;
using System.Threading.Tasks;
using Final10._14.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Final10._14.Controllers.Controllers
{
    public class CommentController : Controller
    {
        private readonly WealthierAndKinderContext _context;

        public CommentController(WealthierAndKinderContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> List()
        {
            var datas = await _context.TComments.ToListAsync();
            return View(datas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FMemberId,FContent")] TComment comment)
        {
            if (ModelState.IsValid)
            {
                comment.FCratedAt = DateOnly.FromDateTime(DateTime.Now);
                _context.Add(comment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(List));
            }
            return View(comment);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.TComments.FindAsync(id);
            if (comment == null)
            {
                return NotFound();
            }
            return View(comment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FCommentId,FMemberId,FContent")] TComment comment)
        {
            if (id != comment.FCommentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var existingComment = await _context.TComments.FindAsync(id);
                    if (existingComment == null)
                    {
                        return NotFound();
                    }

                    existingComment.FContent = comment.FContent;
                    existingComment.FUpdateAt = DateOnly.FromDateTime(DateTime.Now);

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TCommentExists(comment.FCommentId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(List));
            }
            return View(comment);
        }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(int id)
    {
        var comment = await _context.TComments.FindAsync(id);
        if (comment == null)
        {
            return NotFound();
        }

        _context.TComments.Remove(comment);
        await _context.SaveChangesAsync();
        
        // 可以添加一個成功消息
        TempData["Message"] = "評論已成功刪除。";
        
        return RedirectToAction(nameof(List));
    }


        private bool TCommentExists(int id)
        {
            return _context.TComments.Any(e => e.FCommentId == id);
        }
    }
}
