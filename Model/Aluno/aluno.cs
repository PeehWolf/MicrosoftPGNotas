using System;

namespace MicrosoftPGNotas.Models
{
    public class AlunoModel
    {
        public string Nome { get; set; }
        public int Idade {get; set; }
        public double Nota {get; set; }

        // Construtor
        public AlunoModel(string nome, int idade, double nota)
        {
            Nome = nome;
            Idade = idade;
            Nota = nota;
        }
        
        public static List<AlunoModel> GetAlunos()
        {
            // Aqui você pode obter os alunos de uma base de dados ou de outra fonte de dados
            // Por enquanto, vamos retornar uma lista vazia
            return new List<AlunoModel>();
        }
    }
}