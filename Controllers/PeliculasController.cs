using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PeliculasFede2023.Models;
using PeliculasFede2023.Servicios;

namespace PeliculasFede2023.Controllers
{
    public class PeliculasController : Controller
    {
        public IActionResult Index()
        {
            var peliculas =PeliculasServicios.GetPeliculas();
            return View(peliculas);
        }

        public IActionResult Detalles(string id)
        {
            var pelicula = PeliculasServicios.GetPelicula(id);
            if (pelicula == null)
            {
                return NotFound("Código de película no encontrado!");
            }
            return View(pelicula);
        }
        public IActionResult Nueva()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Nueva(Pelicula pelicula)
        {
            if (ModelState.IsValid)
            {
                PeliculasServicios.Agregar(pelicula);
                return RedirectToAction("Index");

            }
            else
            {
                return View(pelicula);
            }
        }

        public IActionResult Eliminar(string id)
        {
            var pelicula = PeliculasServicios.GetPelicula(id);
            if (pelicula == null)
            {
                return NotFound("Código de película no encontrado!");
            }
            return View(pelicula);

        }
        [HttpPost,ActionName("Eliminar")]
        public IActionResult ConfirmarEliminar(string id)
        {
            PeliculasServicios.Eliminar(id);
            return RedirectToAction("Index");
        }
    }
}
