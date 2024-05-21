using EjerciciosRazorPages.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjerciciosRazorPages.Controllers
{
    public class OperacionController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Operacion());
        }

        [HttpPost]
        public IActionResult Index(Operacion model)
        {
            if (ModelState.IsValid)
            {
                model.CalculateResult();
            }
            return View(model);
        }
    }
}
