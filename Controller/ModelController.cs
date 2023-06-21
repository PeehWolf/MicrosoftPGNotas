using Microsoft.AspNetCore.Mvc;
using MicrosoftPGNotas.Models; // Importe o namespace do seu Model

namespace MicrosoftPGNotas.Controllers
{
    public class AlunoController : Controller
    {
        private readonly AlunoModel _alunoModel;

        public AlunoController()
        {
            _alunoModel = new AlunoModel(); // Crie uma instância do Model necessário
        }

        public IActionResult Index()
        {
            // Obtenha os alunos do Model
            var alunos = _alunoModel.GetAlunos();

            // Retorne a View correspondente, passando a lista de alunos como modelo
            return View(alunos);
        }
    }
}
