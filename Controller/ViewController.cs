using Microsoft.AspNetCore.Mvc;
using MicrosoftPGNotas.Aluno.GPA;

namespace MicrosoftPGNotas.Controllers
{
    public class ViewController : Controller
    {
        private readonly CalculadoraDeMedias _calculadora;

        public ViewController()
        {
            _calculadora = new CalculadoraDeMedias();
        }

        public IActionResult MediaGeral()
        {
            int[] creditos = { 3, 4, 3, 4 }; // Exemplo de créditos das disciplinas
            int[] notas = { 8, 9, 7, 8 }; // Exemplo de notas das disciplinas

            decimal mediaGeral = _calculadora.CalcularGPA(creditos, notas);

            ViewData["MediaGeral"] = mediaGeral;

            return View();
        }
    }
}