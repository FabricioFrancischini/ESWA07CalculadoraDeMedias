using Xunit;

namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
        // ✅ JÁ EXISTIA - Arredondamento
        [Fact]
        public void TestarArredondamentoMatematico()
        {
            var calc = new ESWA07CalculadoraDeMedias.Calculadora();
            double resultado = calc.CalcularMediaSemestral(5.5, 5.6, 5.6);
            Assert.Equal(5.6, resultado);
        }

        // ✅ JÁ EXISTIA - Soma dos pesos
        [Fact]
        public void TestarSomaDosPesos()
        {
            double somaPesos = 0.4 + 0.4 + 0.2;
            Assert.Equal(1.0, somaPesos);
        }

        // 1. Validação de notas (0 a 10)
        [Fact]
        public void TestarValidacaoNotaValida()
        {
            var validator = new OOPFoundation.NoteValidation();
            Assert.True(validator.DoubleIsValid(7.5, 10));
        }

        [Fact]
        public void TestarValidacaoNotaInvalida()
        {
            var validator = new OOPFoundation.NoteValidation();
            Assert.False(validator.DoubleIsValid(11.0, 10));
        }

        [Fact]
        public void TestarValidacaoNotaNegativa()
        {
            var validator = new OOPFoundation.NoteValidation();
            Assert.False(validator.DoubleIsValid(-1.0, 10));
        }

        // 2. Cálculo da Média Semestral
        [Fact]
        public void TestarMediaSemestralAprovado()
        {
            var calc = new ESWA07CalculadoraDeMedias.Calculadora();
            double resultado = calc.CalcularMediaSemestral(8.0, 8.0, 8.0);
            Assert.Equal(8.0, resultado);
        }

        [Fact]
        public void TestarMediaSemestralEmExame()
        {
            var calc = new ESWA07CalculadoraDeMedias.Calculadora();
            double resultado = calc.CalcularMediaSemestral(5.0, 5.0, 5.0);
            Assert.Equal(5.0, resultado);
        }

        // 3. Status da Média Semestral
        [Fact]
        public void TestarStatusAprovadoSemestral()
        {
            var calc = new ESWA07CalculadoraDeMedias.Calculadora();
            double ms = calc.CalcularMediaSemestral(8.0, 8.0, 8.0);
            Assert.True(ms >= 7.0); // APROVADO
        }

        [Fact]
        public void TestarStatusEmExame()
        {
            var calc = new ESWA07CalculadoraDeMedias.Calculadora();
            double ms = calc.CalcularMediaSemestral(5.0, 5.0, 5.0);
            Assert.True(ms < 7.0); // EM EXAME
        }

        // 4. Cálculo da Média Final
        [Fact]
        public void TestarMediaFinalAprovado()
        {
            var calc = new ESWA07CalculadoraDeMedias.Calculadora();
            double resultado = calc.CalcularMediaFinal(6.0, 6.0);
            Assert.Equal(6.0, resultado);
        }

        [Fact]
        public void TestarMediaFinalReprovado()
        {
            var calc = new ESWA07CalculadoraDeMedias.Calculadora();
            double resultado = calc.CalcularMediaFinal(3.0, 3.0);
            Assert.Equal(3.0, resultado);
        }

        // 5. Status da Média Final
        [Fact]
        public void TestarStatusAprovadoEmExame()
        {
            var calc = new ESWA07CalculadoraDeMedias.Calculadora();
            double mf = calc.CalcularMediaFinal(6.0, 6.0);
            Assert.True(mf >= 5.0); // APROVADO EM EXAME
        }

        [Fact]
        public void TestarStatusReprovado()
        {
            var calc = new ESWA07CalculadoraDeMedias.Calculadora();
            double mf = calc.CalcularMediaFinal(3.0, 3.0);
            Assert.True(mf < 5.0); // REPROVADO
        }
    }
}