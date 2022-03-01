using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Versality.Data;
using Versality.Models.ViewModels;

namespace Versality.Controllers
{
    public class TheProblemsController : Controller
    {
        private readonly VersalityContext _context;

        public TheProblemsController(VersalityContext context)
        {
            _context = context;
        }

        // GET: TheProblems
        public async Task<IActionResult> Index()
        {
            return View(await _context.TheProblem.ToListAsync());
        }

        // GET: TheProblems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theProblem = await _context.TheProblem
                .FirstOrDefaultAsync(m => m.Id == id);
            if (theProblem == null)
            {
                return NotFound();
            }

            return View(theProblem);
        }

        // GET: TheProblems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TheProblems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Sector,DateProblem")] TheProblem theProblem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(theProblem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(theProblem);
        }

        // GET: TheProblems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theProblem = await _context.TheProblem.FindAsync(id);
            if (theProblem == null)
            {
                return NotFound();
            }
            return View(theProblem);
        }

        // POST: TheProblems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Sector,DateProblem")] TheProblem theProblem)
        {
            if (id != theProblem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(theProblem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TheProblemExists(theProblem.Id))
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
            return View(theProblem);
        }

        // GET: TheProblems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theProblem = await _context.TheProblem
                .FirstOrDefaultAsync(m => m.Id == id);
            if (theProblem == null)
            {
                return NotFound();
            }

            return View(theProblem);
        }

        // POST: TheProblems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var theProblem = await _context.TheProblem.FindAsync(id);
            _context.TheProblem.Remove(theProblem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TheProblemExists(int id)
        {
            return _context.TheProblem.Any(e => e.Id == id);
        }
    }
}
