using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CommuNeedy.Data;
using CommuNeedy.Models;

namespace CommuNeedy.Controllers
{
    public class NeedsController : Controller
    {
        private readonly MvcCommuNeedyContext _context;

        public NeedsController(MvcCommuNeedyContext context)
        {
            _context = context;
        }

        // GET: Needs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Needs.ToListAsync());
        }

        // GET: Needs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var need = await _context.Needs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (need == null)
            {
                return NotFound();
            }

            return View(need);
        }

        // GET: Needs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Needs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,ReleaseDate,Category")] Need need)
        {
            if (ModelState.IsValid)
            {
                _context.Add(need);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(need);
        }

        // GET: Needs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var need = await _context.Needs.FindAsync(id);
            if (need == null)
            {
                return NotFound();
            }
            return View(need);
        }

        // POST: Needs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,ReleaseDate,Category")] Need need)
        {
            if (id != need.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(need);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NeedExists(need.Id))
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
            return View(need);
        }

        // GET: Needs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var need = await _context.Needs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (need == null)
            {
                return NotFound();
            }

            return View(need);
        }

        // POST: Needs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var need = await _context.Needs.FindAsync(id);
            _context.Needs.Remove(need);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NeedExists(int id)
        {
            return _context.Needs.Any(e => e.Id == id);
        }
    }
}
