namespace Calculadora.Tests;

public class AssertingExceptionsTests
{
    // Verifica que dividir por zero lança uma DivideByZeroException.
    [Fact]
    public void Calculadora_Dividir_DeveRetornarErroDivisaoPorZero()
    {
        //Arrange
        var calculadora = new Calculadora();
        
        //Act e assert
        Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(10, 0));
    }

    // Verifica que criar funcionário com salário abaixo do mínimo lança ArgumentException com mensagem esperada.
    [Fact]
    public void Funcionario_Salario_DeveRetornaErrosSalarioInferiorPermitido()
    {
        var exception = Assert.Throws<ArgumentException>(() => FuncionarioFactory.Criar("Eduardo", 250));
        
        Assert.Equal("Salário inferior ao permitido.", exception.Message);
    }
}