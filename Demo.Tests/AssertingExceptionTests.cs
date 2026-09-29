namespace Demo.Tests;

public class AssertingExceptionTests
{
    [Fact]
    public void Calculadora_Dividir_DeveRetornarErroDivisaoPorZero()
    {
        //Arrange
        var calculadora = new Calculadora();
        //act & assert 
        Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(10, 0));
    }
    
    [Fact]
    public void Funcionario_Salario_DeveRetornarErroSalarioInferiorPermitido()
    {
        //Arrange & Act Assert 
        var exception = Assert.Throws<Exception>(() => FuncionarioFactory.Criar("Mailson", 250));
        Assert.Equal("Salario inferior permitido", exception.Message);
    }
}