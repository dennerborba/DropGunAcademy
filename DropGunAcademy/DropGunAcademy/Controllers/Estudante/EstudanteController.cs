using System.ComponentModel.DataAnnotations;
using DropGunAcademy.Models.Estudante;
using Microsoft.AspNetCore.Mvc;

namespace DropGunAcademy.Controllers.Estudante
{
    public class EstudanteController : Controller
    {
        public List<EstudanteModel> ListaEstudantes = new List<EstudanteModel>() {
                new EstudanteModel() {id = 1, nome = "Ana Carolina", cpf = "460.760.860-25", dataNascimento = DateTime.Parse("02/06/1982"), endereco = "Rua das Gaivotas, 150", telefone = "(47) 99158-4525", email = "anacarolina@gmail.com", status = 1},
                new EstudanteModel() {id = 2, nome = "Elisangela Fraga", cpf = "429.536.610-26", dataNascimento = DateTime.Parse("04/03/1984"), endereco = "Rua das Bromelias, 700", telefone = "(47) 99158-6060", email = "elisangelafraga@gmail.com", status = 0},
                new EstudanteModel() {id = 3, nome = "Rafael Rodrigues", cpf = "656.853.720-94", dataNascimento = DateTime.Parse("10/07/1985"), endereco = "Rua das Acassias, 230", telefone = "(47) 99158-8047", email = "rafaelrodrigues@gmail.com", status = 1},
                new EstudanteModel() {id = 4, nome = "Roberta Silveira", cpf = "879.028.910-29", dataNascimento = DateTime.Parse("25/09/1987"), endereco = "Rua das Orquideas, 111", telefone = "(47) 99158-3236", email = "robertasilveira@gmail.com", status = 1},
                new EstudanteModel() {id = 5, nome = "Gabriella Guerra", cpf = "958.496.050-45", dataNascimento = DateTime.Parse("11/11/1986"), endereco = "Rua das Rosas, 840", telefone = "(47) 99158-7456", email = "gabriellaguerra@gmail.com", status = 0},
                new EstudanteModel() {id = 6, nome = "Emerson Alves", cpf = "240.066.890-63", dataNascimento = DateTime.Parse("16/05/1988"), endereco = "Rua dos Girassois, 990", telefone = "(47) 99158-4444", email = "emersonalves@gmail.com", status = 1}
        };

        //Exibir a lista de Alunos
        public IActionResult Index()
        {
            var model = new EstudantesModel()
            {
                Estudantes = ListaEstudantes
            };

            return View(model);
        }

        // Adiciona um novo Aluno
        //[HttpPost]       
        public IActionResult Create(EstudanteModel estudante)
        {
            if (ModelState.IsValid)
            {
                //_context.Estudante.Add(estudante);
                //_context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(estudante);
        }

        //Alterar dodos do Aluno
        public IActionResult Editar(long id)
        {
            var carroAtual = ListaEstudantes.FirstOrDefault(estudante => estudante.id == id);
            return View(carroAtual);
        }

        // Exclui um Aluno
        public IActionResult Delete(int id)
        {
           // var estudante = _context.estudante.Find(id);
          //  if (estudante == null)
          //  {
            //    return NotFound();
          //  }

          //  _context.Categorias.Remove(estudante);
          //  _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
