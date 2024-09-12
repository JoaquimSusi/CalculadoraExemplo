namespace Calculadora.Tests
{
    public class CalculadoraTest
    {
        [Fact]
        public void Somar()
        {
            Assert.Equal(4, ClassLibrary1.Calculadora.Somar(2, 2));
            Assert.Equal(1, ClassLibrary1.Calculadora.Subtrair(3, 2));
            Assert.Equal(9, ClassLibrary1.Calculadora.Multiplicar(3, 3));
            Assert.Equal(3, ClassLibrary1.Calculadora.Dividir(9, 3));
        }

    }
}