using Microsoft.AspNetCore.Mvc;

namespace Acdemico.Controllers
{
    public class ExemploController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
