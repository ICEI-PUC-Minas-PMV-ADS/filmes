using CineviewsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CineviewsApp.Controllers
{
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
    }
}
