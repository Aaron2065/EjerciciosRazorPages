using EjerciciosRazorPages.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjerciciosRazorPages.Controllers
{
    public class EncriptarController : Controller
    {
        // GET: Encriptar
        [HttpGet]
        public IActionResult Index()
        {
            // Inicializar el modelo
            var model = new Encriptar();
            return View(model);
        }

        // POST: Encriptar
        [HttpPost]
        public IActionResult Index(Encriptar model, string action)
        {
            if (ModelState.IsValid)
            {
                if (action == "Encriptar")
                {
                    model.Output = model.EncriptarMsj(model.Input, model.Shift);
                }
                else if (action == "Desencriptar")
                {
                    model.Output = model.Desencriptar(model.Input, model.Shift);
                }
            }

            return View(model);
        }
    }
}
