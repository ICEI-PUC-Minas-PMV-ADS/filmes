using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CineviewsApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace CineviewsApp.Controllers
{
    [Authorize]
    public class MeusfilmesController : Controller
    {
        private readonly AppDbContext _context;

        public MeusfilmesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Meusfilmes
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Meufilmes.Include(m => m.Filme);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Meusfilmes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Meufilmes == null)
            {
                return NotFound();
            }

            var meufilme = await _context.Meufilmes
                .Include(m => m.Filme)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (meufilme == null)
            {
                return NotFound();
            }

            return View(meufilme);
        }

        public IActionResult Create()
        {
            // Get only the checked movies
            var checkedFilmes = _context.Filmes.Where(f => f.IsAssistido).ToList();

            // Clear ViewBag to avoid duplication
            ViewBag.CheckedFilmes = null;

            ViewBag.CheckedFilmes = checkedFilmes;
            ViewData["FilmeId"] = new SelectList(checkedFilmes, "Id", "Nome");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MeuScore,FilmeId,Review")] Meufilme meufilme)
        {
            if (ModelState.IsValid)
            {
                _context.Add(meufilme);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FilmeId"] = new SelectList(_context.Filmes, "Id", "Nome", meufilme.FilmeId);
            return View(meufilme);
        }

        // GET: Meusfilmes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Meufilmes == null)
            {
                return NotFound();
            }

            var meufilme = await _context.Meufilmes.FindAsync(id);
            if (meufilme == null)
            {
                return NotFound();
            }
            ViewData["FilmeId"] = new SelectList(_context.Filmes, "Id", "Nome", meufilme.FilmeId);
            return View(meufilme);
        }

        // POST: Meusfilmes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MeuScore,FilmeId,Review")] Meufilme meufilme)
        {
            if (id != meufilme.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meufilme);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MeufilmeExists(meufilme.Id))
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
            ViewData["FilmeId"] = new SelectList(_context.Filmes, "Id", "Nome", meufilme.FilmeId);
            return View(meufilme);
        }

        // GET: Meusfilmes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Meufilmes == null)
            {
                return NotFound();
            }

            var meufilme = await _context.Meufilmes
                .Include(m => m.Filme)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (meufilme == null)
            {
                return NotFound();
            }

            return View(meufilme);
        }

        // POST: Meusfilmes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Meufilmes == null)
            {
                return Problem("Entity set 'AppDbContext.Meufilmes'  is null.");
            }
            var meufilme = await _context.Meufilmes.FindAsync(id);
            if (meufilme != null)
            {
                _context.Meufilmes.Remove(meufilme);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MeufilmeExists(int id)
        {
          return _context.Meufilmes.Any(e => e.Id == id);
        }
    }
}
