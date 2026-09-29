namespace Demo.Tests;

public class CalculadoraTests
{
    [Fact]
    public void Calculadora_Somar_RetornarValorSoma()
    {
       //Arrange
       var calculadora = new Calculadora();
       //Act
       var resultado = calculadora.Somar(2, 2);
       //Assert
       //Assert.True(resultado == 4);
       Assert.Equal(4, resultado);
    }
    
    
    //InlineData pode passa muitos dados de uma vez.
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(5, 5, 10)]
    [InlineData(10, 10, 20)]
    //[InlineData(50, 50, 90)]
    public void Calculadora_Somar_RetornarValoresSomaCorretos(double valor1, double valor2, double total)
    {
        //Arrange
        var calculadora = new Calculadora();
        //Act
        var resultado = calculadora.Somar(valor1, valor2);
        //Assert
        Assert.Equal(total, resultado);
    }
    
    
    [Fact]
    public void Calculadora_Somar_NaoDeveSerIgual()
    {
        //Arrange
        var calculadora = new Calculadora();
        //Act
        var resultado = calculadora.Somar(1.13123123123, 2.2312313123 );
        //Assert
        Assert.NotEqual(3.3, resultado, 1);
    }
    
}