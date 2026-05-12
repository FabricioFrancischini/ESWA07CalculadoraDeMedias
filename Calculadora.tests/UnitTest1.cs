using Xunit;

namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void TestarValidacaoNotaInvalida()
        {
            var validator = new OOPFoundation.NoteValidation();
            Assert.False(validator.DoubleIsValid(11.0, 10)); // nota 11 = inválida
        }

        [Fact]
        public void TestarValidacaoNotaNegativa()
        {
            var validator = new OOPFoundation.NoteValidation();
            Assert.False(validator.DoubleIsValid(-1.0, 10)); // nota -1 = inválida
        }
    }
}