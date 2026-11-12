namespace AprendendoXUnit;

public class CalculadoraDesconto
{
    public decimal Calcular(decimal preco, decimal percentual)
{
    if (preco < 0 || percentual < 0 || percentual > 100)
        throw new ArgumentException("Valores inválidos.");

    var resultado = preco - (preco * percentual / 100);

    return Math.Round(resultado, 2, MidpointRounding.AwayFromZero);
}

}