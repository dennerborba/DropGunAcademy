using System.ComponentModel.DataAnnotations;
using DropGunAcademy.Models.Estudante;
using Microsoft.AspNetCore.Mvc;

namespace DropGunAcademy.Controllers.Estudante
{
    public class EstudanteController : Controller
    {
        public List<EstudanteModel> ListaEstudantes = new List<EstudanteModel>() {
                new EstudanteModel() {id_aluno = 1, id_cidade_naturalidade = 1, id_cidade_end= 1, nome = "Ana Carolina", endereco = "Rua das Gaivotas, 150", cpf = "460.760.860-25", data_nascimento = DateTime.Parse("02/06/1982"), end_cep="a", end_logradouro="a", end_complemento="a", end_numero=111, end_bairro="111", telefone = "(47) 99158-4525",  email = "anacarolina@gmail.com", data_cadastro= DateTime.Parse("30/01/2025"), data_alteracao= DateTime.Parse("30/01/2025"), situacao_registro=1},
                new EstudanteModel() {id_aluno = 2, id_cidade_naturalidade = 1, id_cidade_end= 1, nome = "Elisangela Fraga", endereco = "Rua das Bromelias, 700", cpf = "429.536.610-26", data_nascimento = DateTime.Parse("04/03/1984"), end_cep="a", end_logradouro="a", end_complemento="a", end_numero=111, end_bairro="111", telefone = "(47) 99158-6060",  email = "elisangelafraga@gmail.com", data_cadastro= DateTime.Parse("30/01/2025"), data_alteracao= DateTime.Parse("30/01/2025"), situacao_registro=1},
                new EstudanteModel() {id_aluno = 3, id_cidade_naturalidade = 1, id_cidade_end= 1, nome = "Rafael Rodrigues", endereco = "Rua das Acassias, 230", cpf = "656.853.720-94", data_nascimento = DateTime.Parse("10/07/1985"), end_cep="a", end_logradouro="a", end_complemento="a", end_numero=111, end_bairro="111", telefone = "(47) 99158-8047",  email = "rafaelrodrigues@gmail.com", data_cadastro= DateTime.Parse("30/01/2025"), data_alteracao= DateTime.Parse("30/01/2025"), situacao_registro=1},
                new EstudanteModel() {id_aluno = 4, id_cidade_naturalidade = 1, id_cidade_end= 1, nome = "Roberta Silveira", endereco = "Rua das Orquideas, 111", cpf = "879.028.910-29", data_nascimento = DateTime.Parse("25/09/1987"), end_cep="a", end_logradouro="a", end_complemento="a", end_numero=111, end_bairro="111", telefone = "(47) 99158-3236",  email = "robertasilveira@gmail.com", data_cadastro= DateTime.Parse("30/01/2025"), data_alteracao= DateTime.Parse("30/01/2025"), situacao_registro=1},
                new EstudanteModel() {id_aluno = 5, id_cidade_naturalidade = 1, id_cidade_end= 1, nome = "Gabriella Guerra", endereco = "Rua das Rosas, 840", cpf = "958.496.050-45", data_nascimento = DateTime.Parse("11/11/1986"), end_cep="a", end_logradouro="a", end_complemento="a", end_numero=111, end_bairro="111", telefone = "(47) 99158-7456",  email = "gabriellaguerra@gmail.com", data_cadastro= DateTime.Parse("30/01/2025"), data_alteracao= DateTime.Parse("30/01/2025"), situacao_registro=1},
                new EstudanteModel() {id_aluno = 6, id_cidade_naturalidade = 1, id_cidade_end= 1, nome = "Emerson Alves", endereco = "Rua dos Girassois, 990", cpf = "240.066.890-63", data_nascimento = DateTime.Parse("16/05/1988"), end_cep="a", end_logradouro="a", end_complemento="a", end_numero=111, end_bairro="111", telefone = "(47) 99158-4444",  email = "emersonalves@gmail.com", data_cadastro= DateTime.Parse("30/01/2025"), data_alteracao= DateTime.Parse("30/01/2025"), situacao_registro=1}
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
