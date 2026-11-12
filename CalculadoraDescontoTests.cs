using Xunit;

namespace AprendendoXUnit;

public class CalculadoraDescontoTests
{
    [Fact]
    public void TesteSimples()
    {
        Assert.Equal(2, 1 + 1);
    }

    [Theory]
    [InlineData(100, 10, 90)]
    [InlineData(200, 25, 150)]
    [InlineData(50, 0, 50)]
    [InlineData(80, 100, 0)]
    [InlineData(150, 20, 120)]
    public void Calcular_DeveAplicarDescontoCorretamente(
        decimal preco,
        decimal percentual,
        decimal esperado)
    {
        var calculadora = new CalculadoraDesconto();
        var resultado = calculadora.Calcular(preco, percentual);

        Assert.Equal(esperado, resultado);
    }

    [Theory]
    [InlineData(-100, 10)]
    [InlineData(100, -10)]
    [InlineData(100, 110)]
    public void Calcular_DeveRejeitarValoresInvalidos(
        decimal preco,
        decimal percentual)
    {
        var calculadora = new CalculadoraDesconto();

        Assert.Throws<ArgumentException>(() =>
            calculadora.Calcular(preco, percentual));
    }
}