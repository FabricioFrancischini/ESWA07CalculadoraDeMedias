using System;

namespace ESWA07CalculadoraDeMedias
{
    public class Calculadora
    {
        public double CalcularMediaSemestral(double np1, double np2, double pim)
        {
            double media = (np1 * 0.4) + (np2 * 0.4) + (pim * 0.2);
            // Aplica o arredondamento matemático para uma casa decimal (Item 7)
            return Math.Round(media, 1, MidpointRounding.AwayFromZero);
        }

        public double CalcularMediaFinal(double ms, double exame)
        {
            double media = (ms + exame) / 2;
            // Aplica o arredondamento matemático para uma casa decimal (Item 7)
            return Math.Round(media, 1, MidpointRounding.AwayFromZero);
        }
    }
}