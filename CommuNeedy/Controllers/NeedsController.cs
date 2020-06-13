using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CommuNeedy.Data;
using CommuNeedy.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.Extensions.Logging;

namespace CommuNeedy.Controllers
{
    public class NeedsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MvcCommuNeedyContext _context;
        private readonly UserManager<User> _userManager;

        public NeedsController(ILogger<HomeController> logger, MvcCommuNeedyContext context, UserManager<User> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        // GET: Needs
        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                // Get the id of the current loggedin user
                string id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                // Get all needs that belong to this user
                IEnumerable<Need> needs = _context.Needs.Where(need => need.OwnerId == id).ToList();
                // return the view with the needs passed in
                return View(needs);
            }
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
        public async Task<IActionResult> Create([Bind("Id,Description,ReleaseDate,Category")] Need needModel)
        {
            if (ModelState.IsValid)
            {
                // 1. Create a new object
                var need = new Need
                {
                    // 2. Set values from (todoModel) to the new todo keys
                    Id = needModel.Id,
                    Description = needModel.Description,
                    ReleaseDate = needModel.ReleaseDate,
                    Category = needModel.Category,
                    // Set the current user to the Owner field of the todo, our DbContext will be responsible for assigning the userID to OwnerID
                    // Remember to import the userManager class to get access to the current user, use dependency injection for this
                    Owner = _userManager.GetUserAsync(User).Result
                };
                _context.Add(need);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(needModel);

            //    _context.Add(need);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(need);
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
