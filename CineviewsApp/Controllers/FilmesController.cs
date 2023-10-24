using CineviewsApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CineviewsApp.Controllers
{
    [Authorize]
    public class FilmesController : Controller
    {
        private readonly AppDbContext _context;

        public FilmesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            var dados = await _context.Filmes.ToListAsync();

            return View(dados);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Filme filme)
        {

            if (ModelState.IsValid)
            {
                _context.Filmes.Add(filme);
                 await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(filme);
        }

        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null)
                return NotFound();

            var dados = await _context.Filmes.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Filme filme)
        {

            if (id != filme.Id)
                return NotFound();

            if (ModelState.IsValid)
            {

                _context.Filmes.Update(filme);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Filmes.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Filmes.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Filmes.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.Filmes.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Relatorio(int? id)
        {
            if (id == null)
                return NotFound();

            var filme = await _context.Filmes.FindAsync(id);

            if (filme == null)
                return NotFound();

            var meusfilmes = await _context.Meufilmes.Where(c => c.FilmeId == id).OrderByDescending(c => c.MeuScore).ToListAsync();

            ViewBag.Filme = filme;
            ViewBag.Meusfilmes = meusfilmes;

            return View(meusfilmes);
        }
    }
}
