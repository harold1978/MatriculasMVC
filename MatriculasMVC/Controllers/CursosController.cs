using MatriculasMVC.Data;
using MatriculasMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MatriculasMVC.Controllers
{
    public class CursosController : Controller
    {
        private readonly AsistenciaDbContext _context;


        public CursosController(AsistenciaDbContext contexto)
        {
            _context = contexto;
        }

        // GET: CursosController1
        public async Task<IActionResult> GetCursos()
        {
            return View( await _context.Cursos.ToListAsync());
        }

        // GET: CursosController1/Details/5
        public async Task<IActionResult> DetalleCurso(int? id)
        {
            if (id==null) { return NotFound(); }
            var curso = await _context.Cursos.FindAsync(id);
            if (curso==null) { return NotFound(); }
            return View(curso);
        }

        // GET: CursosController1/Create
        public ActionResult CrearCurso()
        {
            return View();
        }

        // POST: CursosController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearCurso([Bind("Id,Nombre,Descripcion")] Cursos curso)
        {
            try
            {
                if (ModelState.IsValid) { 
                    _context.Cursos.Add(curso);
                   await _context.SaveChangesAsync();
                return RedirectToAction(nameof(GetCursos));
            }
            }
            catch
            {
                return View(null);
            }
            return View(curso);
        }

        // GET: CursosController1/Edit/5
        public async Task<IActionResult> EditarCurso(int? id)
        {
            if (id == null) {
                return NotFound();
            }
            var curso = await _context.Cursos.FindAsync(id);
            if (curso == null) {
                return NotFound();
            }

            return View(curso);
        }

        // POST: CursosController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditarCurso([Bind("Id,Nombre,Descripcion")] Cursos curso)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Cursos.Update(curso);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction(nameof(GetCursos));
            }
            catch
            {
                return View(null);
            }
        }

        // GET: CursosController1/Delete/5
        public async Task<IActionResult> EliminarCurso(int? id)
        {
            if (id == null) {
                return NotFound();
            }
            var curso = await _context.Cursos.FirstOrDefaultAsync(c=>c.Id==id);
            if (curso == null) {
                return NotFound();
            }
            return View(curso);
        }

        // POST: CursosController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EliminarCurso(int id)
        {
            try
            {
                var curso = await _context.Cursos.FindAsync(id);
                if (curso != null)
                {
                    _context.Cursos.Remove(curso);
                    _context.SaveChanges();
                }
                return RedirectToAction(nameof(GetCursos));
            }
            catch
            {
                return View(null);
            }
        }
    }
}
