using Acdemico.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Acdemico.Controllers
{
    public class AcademicoController : Controller
    {
        private static List<Aluno> alunos = new List<Aluno>()
        {
            new Aluno { Id = 1, Nome = "Peter Park", Email="aranha@marvel.net", DataNascimento = new DateTime(1980, 10, 08) }
        };
        public IActionResult Index()
        {
            return View(alunos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Aluno aluno)
        {
            var nextId = alunos.Any() ? alunos.Max(a => a.Id) + 1 : 1;
            // VARIAVEL = CONDICIONAL ? VERDADEIRO : FALSO
            aluno.Id = nextId;
            alunos.Add(aluno);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            if(id == null)
            {
                return NotFound();
            }
            return View(alunos.Where(a => a.Id == id).FirstOrDefault());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Aluno aluno)
        {
            alunos.Remove(alunos.Where(a => a.Id == aluno.Id).FirstOrDefault());
            alunos.Add(aluno);
            return RedirectToAction("Index");
        }
    }
}
