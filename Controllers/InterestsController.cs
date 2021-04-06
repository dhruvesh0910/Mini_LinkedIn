using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mini_linkedIn.Data;
using mini_linkedIn.Models;

namespace mini_linkedIn.Controllers
{
    public class InterestsController : Controller
    {
        private readonly LinkedInContext _context;

        public InterestsController(LinkedInContext context)
        {
            _context = context;
        }

        // GET: Interests
        public async Task<IActionResult> Index()
        {
            var linkedInContext = _context.Interests.Include(i => i.user);
            return View(await linkedInContext.ToListAsync());
        }

        // GET: Interests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interest = await _context.Interests
                .Include(i => i.user)
                .FirstOrDefaultAsync(m => m.HobbyID == id);
            if (interest == null)
            {
                return NotFound();
            }

            return View(interest);
        }

        // GET: Interests/Create
        public IActionResult Create()
        {
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserID");
            return View();
        }

        // POST: Interests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HobbyID,Name,UserID")] Interest interest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(interest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserID", interest.UserID);
            return View(interest);
        }

        // GET: Interests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interest = await _context.Interests.FindAsync(id);
            if (interest == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserID", interest.UserID);
            return View(interest);
        }

        // POST: Interests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HobbyID,Name,UserID")] Interest interest)
        {
            if (id != interest.HobbyID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(interest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InterestExists(interest.HobbyID))
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
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserID", interest.UserID);
            return View(interest);
        }

        // GET: Interests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interest = await _context.Interests
                .Include(i => i.user)
                .FirstOrDefaultAsync(m => m.HobbyID == id);
            if (interest == null)
            {
                return NotFound();
            }

            return View(interest);
        }

        // POST: Interests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var interest = await _context.Interests.FindAsync(id);
            _context.Interests.Remove(interest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InterestExists(int id)
        {
            return _context.Interests.Any(e => e.HobbyID == id);
        }
    }
}
