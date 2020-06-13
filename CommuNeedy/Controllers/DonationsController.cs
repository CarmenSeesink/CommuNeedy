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
    public class DonationsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MvcCommuNeedyContext _context;
        private readonly UserManager<User> _userManager;

        public DonationsController(ILogger<HomeController> logger, MvcCommuNeedyContext context, UserManager<User> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        // GET: Donations
        public async Task<IActionResult> Index()
        {
            // Test to see if the user is logged in
            if (User.Identity.IsAuthenticated)
            {
                // Get the id of the current loggedin user
                string id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                // Get all notes that belong to this user
                IEnumerable<Donation> donations = _context.Donation.ToList();
                //    // return the view with the notes passed in
                return View(donations);
                //}
                //return View(await _context.Donation.ToListAsync());
                //User currentUser = await _context.User
                //    .Include(n => n.Needs)
                //    .Include(n => n.DonationNeed)
                //        .ThenInclude(ut => ut.Needs)
                //    .FirstOrDefaultAsync(u => u.Id == id);

                //if (currentUser == null)
                //{
                //    return NotFound();
                //}

                // Get all notes that belong to this user
                //IEnumerable<Todo> todos = _context.Todo.Where(todo => todo.OwnerId == id).ToList();
                // return the view with the notes passed in
                //return View(currentUser);
            }
            return View(await _context.Donation.ToListAsync());


        }

        // GET: Donations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donation = await _context.Donation
                //.Include(d => d.DonationNeed)
                //.ThenInclude(dn => dn.Need)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (donation == null)
            {
                return NotFound();
            }

            return View(donation);
        }

        // GET: Donations/Create
        public IActionResult Create()
        {
            List<Need> allNeeds = _context.Needs.ToList();
            var selectAllNeeds = allNeeds.Select(x => new SelectListItem() { Text = x.Description, Value = x.Id.ToString()});
            ViewData["needs"] = new MultiSelectList(selectAllNeeds, "Value", "Text");
            return View();

        }

        // POST: Donations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,ReleasedDate,Category,NeedIds")] DonationViewModel donationModel)
        {

            // Make sure that the todo is related to the user on create
            if (ModelState.IsValid)
            {
                // 1. Create a new Todo object
                var donation = new Donation
                {
                    // 2. Set values from (todoModel) to the new todo keys
                    Id = donationModel.Id,
                    Description = donationModel.Description,
                    ReleasedDate = donationModel.ReleasedDate,
                    Category = donationModel.Category,
                    // Set the current user to the Owner field of the todo, our DbContext will be responsible for assigning the userID to OwnerID
                    // Remember to import the userManager class to get access to the current user, use dependency injection for this
                    Owner = _userManager.GetUserAsync(User).Result
                };

                //donation.Needs = new List<Need>();
                donation.DonationNeeds = new List<DonationNeed>();

                if (donationModel.NeedIds != null)
                {
                    List<Need> allNeeds = _context.Needs.Where(need => donationModel.NeedIds.Contains(need.Id)).ToList();

                    foreach (Need need in allNeeds)
                    {
                        donation.DonationNeeds.Add(new DonationNeed
                        {
                            Need = need,
                            Donation = donation

                        });
                    }

                    _context.Add(donation);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));

                } else
                {
                    _context.Add(donation);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }

            }
            return View(donationModel);

        }

        // GET: Donations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donation = await _context.Donation.FindAsync(id);
            if (donation == null)
            {
                return NotFound();
            }
            List<Need> allNeeds = _context.Needs.ToList();
            var selectAllNeeds = allNeeds.Select(x => new SelectListItem() { Text = x.Description, Value = x.Id.ToString(), Selected = true });
            ViewData["needs"] = new MultiSelectList(selectAllNeeds, "Value", "Text");

            var viewModel = new DonationViewModel();
            viewModel.Id = donation.Id;
            viewModel.Description = donation.Description;
            viewModel.Category = donation.Category;
            viewModel.Owner = _userManager.GetUserAsync(User).Result;
            //viewModel.DonationNeed = donation.DonationNeed;

            viewModel.NeedIds = new List<int>();
            return View(viewModel);
        }

        // POST: Donations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,ReleasedDate,Category,NeedIds")] DonationViewModel donation)
        {
            if (id != donation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(donation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DonationExists(donation.Id))
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

            //ViewData["OwnerId"] = new SelectList(_context.User, "Id", "Id", donation.OwnerId);
            return View(donation);
        }

        // GET: Donations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donation = await _context.Donation
                .Include(d => d.Owner)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (donation == null)
            {
                return NotFound();
            }

            return View(donation);
        }

        // POST: Donations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var donation = await _context.Donation.FindAsync(id);
            _context.Donation.Remove(donation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DonationExists(int id)
        {
            return _context.Donation.Any(e => e.Id == id);
        }
    }
}
