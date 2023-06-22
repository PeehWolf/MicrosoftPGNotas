using Microsoft.AspNetCore.Mvc;
using MicrosoftPGNotas.Models; // Importe o namespace do seu Model

namespace MicrosoftPGNotas.Controllers
{
    public class AlunoController : Controller
    {
        private readonly AlunoModel _alunoModel;

        public AlunoController(string nome, int idade, double nota)
        {
            _alunoModel = new AlunoModel(nome, idade, nota);
        }

        public IActionResult Index()
        {
            // Obtenha os alunos do Model
            var alunos = AlunoModel.GetAlunos();

            // Retorne a View correspondente, passando a lista de alunos como modelo
            return View(alunos);
        }
    }
}
