using Acdemico.Models;
using Microsoft.AspNetCore.Mvc;

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
    }
}
