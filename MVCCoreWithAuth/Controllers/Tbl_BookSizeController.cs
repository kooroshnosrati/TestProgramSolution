using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCCoreWithAuth.Data;
using MVCCoreWithAuth.Models;

namespace MVCCoreWithAuth.Controllers
{
    public class Tbl_BookSizeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Tbl_BookSizeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tbl_BookSize
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tbl_BookSizes.ToListAsync());
        }

        // GET: Tbl_BookSize/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbl_BookSize = await _context.Tbl_BookSizes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (tbl_BookSize == null)
            {
                return NotFound();
            }

            return View(tbl_BookSize);
        }

        // GET: Tbl_BookSize/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tbl_BookSize/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name")] Tbl_BookSize tbl_BookSize)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tbl_BookSize);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tbl_BookSize);
        }

        // GET: Tbl_BookSize/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbl_BookSize = await _context.Tbl_BookSizes.FindAsync(id);
            if (tbl_BookSize == null)
            {
                return NotFound();
            }
            return View(tbl_BookSize);
        }

        // POST: Tbl_BookSize/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name")] Tbl_BookSize tbl_BookSize)
        {
            if (id != tbl_BookSize.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tbl_BookSize);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Tbl_BookSizeExists(tbl_BookSize.ID))
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
            return View(tbl_BookSize);
        }

        // GET: Tbl_BookSize/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbl_BookSize = await _context.Tbl_BookSizes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (tbl_BookSize == null)
            {
                return NotFound();
            }

            return View(tbl_BookSize);
        }

        // POST: Tbl_BookSize/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tbl_BookSize = await _context.Tbl_BookSizes.FindAsync(id);
            _context.Tbl_BookSizes.Remove(tbl_BookSize);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Tbl_BookSizeExists(int id)
        {
            return _context.Tbl_BookSizes.Any(e => e.ID == id);
        }
    }
}
