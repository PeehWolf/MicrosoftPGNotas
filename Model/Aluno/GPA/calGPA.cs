using System;

namespace MicrosoftPGNotas.Aluno.GPA
{
    public class CalculadoraDeMedias
    {
        public decimal CalcularGPA(int[] creditos, int[] notas)
        {
            int totalCreditos = 0;
            int totalPontosGrade = 0;

            for (int i = 0; i < creditos.Length; i++)
            {
                totalCreditos += creditos[i];
                totalPontosGrade += creditos[i] * notas[i];
            }

            decimal media = (decimal)totalPontosGrade / totalCreditos;
            return media;
        }
    }
}

