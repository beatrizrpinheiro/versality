using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Versality.Data;
using Versality.Models;

namespace Versality.Controllers
{
    public class ActiveMethodsController : Controller
    {
        private readonly VersalityContext _context;

        public ActiveMethodsController(VersalityContext context)
        {
            _context = context;
        }

        // GET: ActiveMethods
        public async Task<IActionResult> Index()
        {
            return View(await _context.ActiveMethods.ToListAsync());
        }

        // GET: ActiveMethods/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activeMethods = await _context.ActiveMethods
                .FirstOrDefaultAsync(m => m.Id == id);
            if (activeMethods == null)
            {
                return NotFound();
            }

            return View(activeMethods);
        }

        // GET: ActiveMethods/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ActiveMethods/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] ActiveMethods activeMethods)
        {
            if (ModelState.IsValid)
            {
                _context.Add(activeMethods);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(activeMethods);
        }

        // GET: ActiveMethods/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activeMethods = await _context.ActiveMethods.FindAsync(id);
            if (activeMethods == null)
            {
                return NotFound();
            }
            return View(activeMethods);
        }

        // POST: ActiveMethods/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description")] ActiveMethods activeMethods)
        {
            if (id != activeMethods.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(activeMethods);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActiveMethodsExists(activeMethods.Id))
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
            return View(activeMethods);
        }

        // GET: ActiveMethods/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activeMethods = await _context.ActiveMethods
                .FirstOrDefaultAsync(m => m.Id == id);
            if (activeMethods == null)
            {
                return NotFound();
            }

            return View(activeMethods);
        }

        // POST: ActiveMethods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var activeMethods = await _context.ActiveMethods.FindAsync(id);
            _context.ActiveMethods.Remove(activeMethods);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActiveMethodsExists(int id)
        {
            return _context.ActiveMethods.Any(e => e.Id == id);
        }
    }
}
