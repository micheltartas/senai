using Escola.Models;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Controllers
{
    public class ColegioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Novo()
        {
            var model = new ColegioModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Novo(ColegioModel model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }
            return View(model);
        }

    }
}
