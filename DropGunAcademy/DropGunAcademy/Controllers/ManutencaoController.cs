using DropGunAcademy.Models;
using Microsoft.AspNetCore.Mvc;

namespace DropGunAcademy.Controllers
{
    public class ManutencaoController : Controller
    {
        public List<ManutencaoModel> _Manutencoes = new List<ManutencaoModel>()
        {
            new ManutencaoModel()
            {
                Id = 1,
                IdAeronave = 1,
                DataInicio = new DateOnly(2025, 10, 12),
                DataConclusao = new DateOnly(2025, 12, 10),
                Descricao = "Motor super aquecido",
                TecResp = "Marcos"
            },
            new ManutencaoModel()
            {
                Id = 2,
                IdAeronave = 2,
                DataInicio = new DateOnly(2025, 10, 12),
                DataConclusao = new DateOnly(2025, 12, 10),
                Descricao = "Motor quebrado",
                TecResp = "José"
            },
            new ManutencaoModel()
            {
                Id = 3,
                IdAeronave = 3,
                DataInicio = new DateOnly(2025, 9, 20),
                DataConclusao = new DateOnly(2025, 10, 25),
                Descricao = "Troca de óleo necessária",
                TecResp = "Ana"
            },
            new ManutencaoModel()
            {
                Id = 4,
                IdAeronave = 4,
                DataInicio = new DateOnly(2025, 11, 5),
                DataConclusao = new DateOnly(2025, 12, 1),
                Descricao = "Freios danificados",
                TecResp = "Carlos"
            },
            new ManutencaoModel()
            {
                Id = 5,
                IdAeronave = 5,
                DataInicio = new DateOnly(2025, 8, 15),
                DataConclusao = new DateOnly(2025, 9, 10),
                Descricao = "Revisão geral",
                TecResp = "Fernanda"
            }
        };

        public IActionResult Manutencao()
        {
            var model = new ManutencoesModel() { Manutecoes = _Manutencoes };
            return View(model);
        }
    }
}
