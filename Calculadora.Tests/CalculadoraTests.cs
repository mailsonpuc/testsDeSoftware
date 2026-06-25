namespace Calculadora.Tests;

public class CalculadoraTests
{
    // Verifica que somar 5 e 5 retorna 10.
    [Fact]
    public void DeveSomar5Com5_E_Retorna10()
    {
        //Arrage
        var calculadora = new Calculadora();
        
        //Act
        var resultado = calculadora.Soma(5, 5);
        
        //Assert
        Assert.Equal(10, resultado);
    }
    
    // Verifica que a soma retorna o total esperado para vários pares de valores.
    [Theory]
    [InlineData(5, 5, 10)]
    [InlineData(1,1,2)]
    [InlineData(20,20,40)]
    [InlineData(100,100,200)]
    public void DeveSomarVariosValores(int num1, int num2, int total)
    {
        //Arrage
        var calculadora = new Calculadora();
        
        //Act
        var resultado = calculadora.Soma(num1, num2);
        
        //Assert
        Assert.Equal(total, resultado);
    }


    // Verifica que o resultado da soma não é um valor negativo.
    [Fact]
    public void Calculadora_Somar_NaoDeveSerNegativo()
    {
        //Arrange
        var calculadora = new Calculadora();
        //Act
        var result = calculadora.Soma(1.13123123123, 2.2312313123);
        //Assert
        Assert.NotEqual(3.3, result, 1);
    }
}