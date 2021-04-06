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
    public class AchievementsController : Controller
    {
        private readonly LinkedInContext _context;

        public AchievementsController(LinkedInContext context)
        {
            _context = context;
        }

        // GET: Achievements
        public async Task<IActionResult> Index()
        {
            var linkedInContext = _context.Achievements.Include(a => a.user);
            return View(await linkedInContext.ToListAsync());
        }

        // GET: Achievements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var achievement = await _context.Achievements
                .Include(a => a.user)
                .FirstOrDefaultAsync(m => m.AchievementID == id);
            if (achievement == null)
            {
                return NotFound();
            }

            return View(achievement);
        }

        // GET: Achievements/Create
        public IActionResult Create()
        {
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserID");
            return View();
        }

        // POST: Achievements/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AchievementID,Title,Year,Description,UserID")] Achievement achievement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(achievement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserID", achievement.UserID);
            return View(achievement);
        }

        // GET: Achievements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var achievement = await _context.Achievements.FindAsync(id);
            if (achievement == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserID", achievement.UserID);
            return View(achievement);
        }

        // POST: Achievements/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AchievementID,Title,Year,Description,UserID")] Achievement achievement)
        {
            if (id != achievement.AchievementID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(achievement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AchievementExists(achievement.AchievementID))
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
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserID", achievement.UserID);
            return View(achievement);
        }

        // GET: Achievements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var achievement = await _context.Achievements
                .Include(a => a.user)
                .FirstOrDefaultAsync(m => m.AchievementID == id);
            if (achievement == null)
            {
                return NotFound();
            }

            return View(achievement);
        }

        // POST: Achievements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var achievement = await _context.Achievements.FindAsync(id);
            _context.Achievements.Remove(achievement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AchievementExists(int id)
        {
            return _context.Achievements.Any(e => e.AchievementID == id);
        }
    }
}
