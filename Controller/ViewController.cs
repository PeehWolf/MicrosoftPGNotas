using Microsoft.AspNetCore.Mvc;

namespace MicrosoftPGNotas.Controllers
{
    public class NotasController : Controller
    {
        public IActionResult MediaGeral()
        {
            // Aqui você pode implementar a lógica para calcular a média geral dos alunos
            double mediaGeral = CalcularMediaGeral();
            return View(mediaGeral);
        }

        private double CalcularMediaGeral()
        {
            // Aqui você pode implementar a lógica para calcular a média geral dos alunos
            // e retornar o resultado
        }
    }
}
