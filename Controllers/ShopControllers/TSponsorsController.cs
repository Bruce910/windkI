using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Final10._14.Models;

namespace Final10._14.Controllers.ShopControllers
{
    public class TSponsorsController : Controller
    {
        private readonly WealthierAndKinderContext _context;

        public TSponsorsController(WealthierAndKinderContext context)
        {
            _context = context;
        }

        // GET: TSponsors
        public async Task<IActionResult> Index()
        {
            return View(await _context.TSponsors.ToListAsync());
        }

        // GET: TSponsors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tSponsor = await _context.TSponsors
                .FirstOrDefaultAsync(m => m.FSponsorId == id);
            if (tSponsor == null)
            {
                return NotFound();
            }

            return View(tSponsor);
        }

        // GET: TSponsors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TSponsors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FSponsorId,FSponsorName,FSponsorCategoryId,FAddress,FPhone,FCapital,FIntroduction,FStatus")] TSponsor tSponsor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tSponsor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tSponsor);
        }

        // GET: TSponsors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tSponsor = await _context.TSponsors.FindAsync(id);
            if (tSponsor == null)
            {
                return NotFound();
            }
            return View(tSponsor);
        }

        // POST: TSponsors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FSponsorId,FSponsorName,FSponsorCategoryId,FAddress,FPhone,FCapital,FIntroduction,FStatus")] TSponsor tSponsor)
        {
            if (id != tSponsor.FSponsorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tSponsor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TSponsorExists(tSponsor.FSponsorId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tSponsor);
        }

        // GET: TSponsors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tSponsor = await _context.TSponsors
                .FirstOrDefaultAsync(m => m.FSponsorId == id);
            if (tSponsor == null)
            {
                return NotFound();
            }

            return View(tSponsor);
        }

        // POST: TSponsors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tSponsor = await _context.TSponsors.FindAsync(id);
            if (tSponsor != null)
            {
                _context.TSponsors.Remove(tSponsor);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TSponsorExists(int id)
        {
            return _context.TSponsors.Any(e => e.FSponsorId == id);
        }
    }
}
