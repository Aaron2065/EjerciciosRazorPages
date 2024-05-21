using Microsoft.AspNetCore.Mvc;

namespace EjerciciosRazorPages.Controllers
{
    public class NumerosController : Controller
    {
        public IActionResult Index()
        {
            // Generar arreglo de números aleatorios
            var random = new Random();
            var numeros = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                numeros.Add(random.Next(0, 101));
            }

            // Calcular la suma
            int suma = numeros.Sum();

            // Calcular el promedio
            double promedio = numeros.Average();

            // Calcular la moda
            var frecuencia = numeros.GroupBy(n => n).OrderByDescending(g => g.Count());
            int maxFrecuencia = frecuencia.First().Count();
            var moda = frecuencia.Where(g => g.Count() == maxFrecuencia).Select(g => g.Key).ToList();

            // Calcular la mediana
            var numerosOrdenados = numeros.OrderBy(n => n).ToList();
            double mediana;
            int n = numerosOrdenados.Count;
            if (n % 2 == 0)
            {
                mediana = (numerosOrdenados[n / 2 - 1] + numerosOrdenados[n / 2]) / 2.0;
            }
            else
            {
                mediana = numerosOrdenados[n / 2];
            }

            // Pasar los datos a la vista
            ViewBag.Numeros = numeros;
            ViewBag.Suma = suma;
            ViewBag.Promedio = promedio;
            ViewBag.Moda = moda;
            ViewBag.Mediana = mediana;
            ViewBag.NumerosOrdenados = numerosOrdenados;

            return View();
        }
    }
}
