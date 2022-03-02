using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Versality.Data;
using Versality.Models;
using Versality.Models.ViewModels;
using Versality.Services;

namespace Versality.Controllers
{
    public class KnowledgesController : Controller
    {
        private readonly VersalityContext _context;
        private readonly TheProblemService _theProblemService;
        private readonly SectorService _sectorService;

        public KnowledgesController(VersalityContext context, TheProblemService theProblemService, SectorService sectorService)
        {
            _context = context;
            _theProblemService = theProblemService;
            _sectorService = sectorService;
        }

        // GET: Knowledges
        public async Task<IActionResult> Index()
        {
            return View(await _context.Knowledge.Include(x => x.Sector).Include(x => x.TheProblem).ToListAsync());
        }

        // GET: Knowledges/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var knowledge = await _context.Knowledge
                .FirstOrDefaultAsync(m => m.Id == id);
            if (knowledge == null)
            {
                return NotFound();
            }

            return View(knowledge);
        }

        // GET: Knowledges/Create
        public IActionResult Create()
        {
            var problems = _theProblemService.FindAll();
            var sectors = _sectorService.FindAll();
            var viewModel = new KnowledgeFormViewModel { TheProblem = problems, TheSectors = sectors };
           
 
            return View(viewModel);
        }

        // POST: Knowledges/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ActionLeader,TheProblemId, SectorId")] Knowledge knowledge)
        {
            if (ModelState.IsValid)
            {
                _context.Add(knowledge);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(knowledge);
        }

        // GET: Knowledges/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var knowledge = await _context.Knowledge.FindAsync(id);
            if (knowledge == null)
            {
                return NotFound();
            }
            return View(knowledge);
        }

        // POST: Knowledges/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ActionLeader")] Knowledge knowledge)
        {
            if (id != knowledge.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(knowledge);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KnowledgeExists(knowledge.Id))
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
            return View(knowledge);
        }

        // GET: Knowledges/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var knowledge = await _context.Knowledge
                .FirstOrDefaultAsync(m => m.Id == id);
            if (knowledge == null)
            {
                return NotFound();
            }

            return View(knowledge);
        }

        // POST: Knowledges/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var knowledge = await _context.Knowledge.FindAsync(id);
            _context.Knowledge.Remove(knowledge);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KnowledgeExists(int id)
        {
            return _context.Knowledge.Any(e => e.Id == id);
        }
    }
}
