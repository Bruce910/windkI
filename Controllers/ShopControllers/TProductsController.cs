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
    public class TProductsController : Controller
    {

        private readonly WealthierAndKinderContext _context;

        public TProductsController(WealthierAndKinderContext context)
        {
            _context = context;
        }


        // GET: TProducts
        public async Task<IActionResult> Index(string SearchName)
        {
            var products = from p in _context.TProducts
                           select p;

            if (!string.IsNullOrEmpty(SearchName))
            {
                products = products.Where(p => p.FProductName.Contains(SearchName));
            }

            ViewData["SearchName"] = SearchName;

            return View(await products.ToListAsync());
        }
        // GET: TProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tProduct = await _context.TProducts
                .FirstOrDefaultAsync(m => m.FProductId == id);
            if (tProduct == null)
            {
                return NotFound();
            }

            return View(tProduct);
        }

        // GET: TProducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FProductId,FProductCategoryId,FSponsorId,FProductName,FDescription,FSales,FStock,FUnitlHelpPoint,FStatus")] TProduct tProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tProduct);
        }

        // GET: TProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tProduct = await _context.TProducts.FindAsync(id);
            if (tProduct == null)
            {
                return NotFound();
            }
            return View(tProduct);
        }

        // POST: TProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FProductId,FProductCategoryId,FSponsorId,FProductName,FDescription,FSales,FStock,FUnitlHelpPoint,FStatus")] TProduct tProduct)
        {
            if (id != tProduct.FProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TProductExists(tProduct.FProductId))
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
            return View(tProduct);
        }

        // GET: TProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tProduct = await _context.TProducts
                .FirstOrDefaultAsync(m => m.FProductId == id);
            if (tProduct == null)
            {
                return NotFound();
            }

            return View(tProduct);
        }

        // POST: TProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tProduct = await _context.TProducts.FindAsync(id);
            if (tProduct != null)
            {
                _context.TProducts.Remove(tProduct);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TProductExists(int id)
        {
            return _context.TProducts.Any(e => e.FProductId == id);
        }
    }
}
