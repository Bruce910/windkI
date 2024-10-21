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
    public class TOrdersController : Controller
    {
        private readonly WealthierAndKinderContext _context;

        public TOrdersController(WealthierAndKinderContext context)
        {
            _context = context;
        }

        // GET: TOrders
        public async Task<IActionResult> Index()
        {
            return View(await _context.TOrders.ToListAsync());
        }

        // GET: TOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tOrder = await _context.TOrders
                .FirstOrDefaultAsync(m => m.FOrderId == id);
            if (tOrder == null)
            {
                return NotFound();
            }

            return View(tOrder);
        }

        // GET: TOrders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FOrderId,FMemberId,FTotalHelpPoint,FStatus,FOrderTime,FExecStatus,FBeginTime,FFinishTime,FProof")] TOrder tOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tOrder);
        }

        // GET: TOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tOrder = await _context.TOrders.FindAsync(id);
            if (tOrder == null)
            {
                return NotFound();
            }
            return View(tOrder);
        }

        // POST: TOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FOrderId,FMemberId,FTotalHelpPoint,FStatus,FOrderTime,FExecStatus,FBeginTime,FFinishTime,FProof")] TOrder tOrder)
        {
            if (id != tOrder.FOrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TOrderExists(tOrder.FOrderId))
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
            return View(tOrder);
        }

        // GET: TOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tOrder = await _context.TOrders
                .FirstOrDefaultAsync(m => m.FOrderId == id);
            if (tOrder == null)
            {
                return NotFound();
            }

            return View(tOrder);
        }

        // POST: TOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tOrder = await _context.TOrders.FindAsync(id);
            if (tOrder != null)
            {
                _context.TOrders.Remove(tOrder);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TOrderExists(int id)
        {
            return _context.TOrders.Any(e => e.FOrderId == id);
        }
    }
}
