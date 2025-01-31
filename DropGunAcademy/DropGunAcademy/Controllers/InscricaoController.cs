using Microsoft.AspNetCore.Mvc;

namespace DropGunAcademy.Controllers
{
    public class InscricaoController : Controller
    {
        public IActionResult Inscrever()
        {
            return View();
        }
    }
}
