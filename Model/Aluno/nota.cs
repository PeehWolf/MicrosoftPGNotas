using System;

namespace MicrosoftPGNotas.Services
{
    public class CalculadoraDeNotas
    {
        public static double CalcularMedia(double[] notas)
        {
            double soma = 0;
            foreach (var nota in notas)
            {
                soma += nota;
            }
            return soma / notas.Length;
        }
    }
}
