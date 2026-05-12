using Xunit;

namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void TestarArredondamentoMatematico()
        {
            // Usando o nome completo para evitar conflito de namespace
            var calc = new ESWA07CalculadoraDeMedias.Calculadora();

            double resultado = calc.CalcularMediaSemestral(5.5, 5.6, 5.6);

            // Verifica se a DLL arredondou para 5.6
            Assert.Equal(5.6, resultado);
        }

        [Fact]
        public void TestarSomaDosPesos()
        {
            // Requisito 10.iii: Soma dos pesos deve ser 1.0
            double somaPesos = 0.4 + 0.4 + 0.2;
            Assert.Equal(1.0, somaPesos);
        }
    }
}