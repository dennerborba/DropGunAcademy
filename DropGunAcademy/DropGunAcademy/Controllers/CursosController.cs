using DropGunAcademy.Models.Cursos;
using Microsoft.AspNetCore.Mvc;

namespace DropGunAcademy.Controllers
{
    public class CursosController : Controller
    {
        public IActionResult Index()
        {
            var curso = new List<CursoModel>() {
                new CursoModel() { ID = 1, Tipo = "João", Duracao = "Em curso", Preco = 51.990 },
                new CursoModel() { ID = 2, Tipo = "Maria", Duracao = "Em curso", Preco = 20.980 },
                new CursoModel() { ID = 3, Tipo = "Ana", Duracao = "Em curso", Preco = 37.600 },
            };
        
            var model = new CursosModel()
            {
                Cursos = curso,
            };

            return View(model);
        }
    }
}
