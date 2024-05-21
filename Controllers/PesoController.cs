using EjerciciosRazorPages.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjerciciosRazorPages.Controllers
{
    public class PesoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Peso model)
        {
            if (ModelState.IsValid)
            {
                model.IMC = CalculateIMC(model.peso, model.altura);
                return View(model);
            }

            return View(model);
        }

        private double CalculateIMC(double peso, double altura)
        {
            if (altura > 0)
            {
                return peso / (altura * altura);
            }
            return 0;
        }
    }
}
