using DropGunAcademy.Models;
using DropGunAcademy.Models.Aulas;
using Microsoft.AspNetCore.Mvc;

namespace DropGunAcademy.Controllers
{
    public class AulasController : Controller
    {
        public List<AulaModel> _Aulas = new List<AulaModel>()
        {
            new AulaModel() { Id = 1, NomeAula = "Navegação Aérea", DataAula = new DateOnly(2024, 12, 6)},
            new AulaModel() { Id = 2, NomeAula = "Aerodinâmica", DataAula = new DateOnly(2025, 5, 10)},
            new AulaModel() { Id = 3, NomeAula = "Comunicação Aeronáutica", DataAula = new DateOnly(2025, 9, 8)},
            new AulaModel() { Id = 4, NomeAula = "Navegação Aérea", DataAula = new DateOnly(2025, 10, 8)},
            new AulaModel() { Id = 5, NomeAula = "Simulação de Voo", DataAula = new DateOnly(2025, 12, 12)}
        };


        public IActionResult Index()
        {
            var model = new AulasModel() { Aulas = _Aulas } ;
            return View(model);
        }
    }
}
