using MicrosoftPGNotas.Controllers;

namespace MicrosoftPGNotas
{
    public class Program
    {
        public static void Run()
        {
            // Instancie os controladores necessários
            GPAController notasController = new GPAController();
            GPAController gpaController = new GPAController();

            // Execute os métodos desejados nos controladores
            //GPAController.ExibirNotas();
            gpaController.MediaGeral();

            // Outras chamadas de métodos ou lógica do programa

            // Mantenha o console aberto para visualização
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Run();
        }
    }
}
