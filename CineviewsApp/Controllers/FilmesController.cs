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

        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewData["NameSortParm"] = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DirectorSortParm"] = sortOrder == "Director" ? "director_desc" : "Director";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["ScoreSortParm"] = sortOrder == "Score" ? "score_desc" : "Score";

            var filmes = _context.Filmes.Where(f =>
                EF.Functions.Like(f.Nome, $"%{searchString}%") || EF.Functions.Like(f.Diretor, $"%{searchString}%"));

            switch (sortOrder)
            {
                case "name_desc":
                    filmes = filmes.OrderByDescending(f => f.Nome);
                    break;
                case "Director":
                    filmes = filmes.OrderBy(f => f.Diretor);
                    break;
                case "director_desc":
                    filmes = filmes.OrderByDescending(f => f.Diretor);
                    break;
                case "Date":
                    filmes = filmes.OrderBy(f => f.DataLancamento);
                    break;
                case "date_desc":
                    filmes = filmes.OrderByDescending(f => f.DataLancamento);
                    break;
                case "Score":
                    filmes = filmes.OrderBy(f => f.Score);
                    break;
                case "score_desc":
                    filmes = filmes.OrderByDescending(f => f.Score);
                    break;
                default:
                    filmes = filmes.OrderBy(f => f.Nome);
                    break;
            }

            return View(await filmes.ToListAsync());
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

        [HttpPost]
        public async Task<IActionResult> UpdateAssistidoStatus(int id, bool isChecked)
        {
            var filme = await _context.Filmes.FindAsync(id);

            if (filme == null)
            {
                return NotFound();
            }

            filme.IsAssistido = isChecked;
            await _context.SaveChangesAsync();

            return Json(new { success = true });
        }

        public IActionResult Search(string searchString)
        {
            // Retrieve your list of filmes from the database
            var filmes = _context.Filmes
                .Where(f => EF.Functions.Like(f.Nome, $"%{searchString}%") || EF.Functions.Like(f.Diretor, $"%{searchString}%"))
                .ToList();

            return View("Index", filmes);
        }

    }
}
