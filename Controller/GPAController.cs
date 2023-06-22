using Microsoft.AspNetCore.Mvc;
using MicrosoftPGNotas.Aluno.GPA;
namespace MicrosoftPGNotas.Controllers
{
    public class GPAController : Controller
    {
        private readonly CalculadoraDeMedias _calculadora;

        public GPAController()
        {
            _calculadora = new CalculadoraDeMedias();
        }

        public IActionResult MediaGeral()
        {
            int[] creditos = {4, 3, 2, 3 };
            decimal[] notasDecimais = { 8.5m, 9.0m, 7.5m, 8.0m }; // Exemplo de notas
            
            int[] notas = Array.ConvertAll(notasDecimais, x=> (int)x);

            decimal mediaGeral = _calculadora.CalcularGPA(creditos, notas);

            ViewData["MediaGeral"] = mediaGeral;

            return View();
        }
    }
}
