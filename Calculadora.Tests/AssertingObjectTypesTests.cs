namespace Calculadora.Tests;

public class AssertingObjectTypesTests
{
    // Verifica que a fábrica cria um objeto do tipo Funcionario.
    [Fact]
    public void FuncionarioFactory_Criar_DeveRetornarTipoFuncionario()
    {
        //Arrange
        var funcionario =  FuncionarioFactory.Criar("Eduardo", 10000);
        //Assert
        Assert.IsType<Funcionario>(funcionario);
        //Act
    }


    // Verifica que o objeto criado é compatível com o tipo Funcionario.
    [Fact]
    public void FuncionarioFactory_Criar_DeveRetornaTipoDeDerivadoPessoa()
    {
        //Arrange e act
        var funcionario = FuncionarioFactory.Criar("Eduardo", 10000);
        
        //Assert
        //IsAssignableFrom significa a class funcionario herda de pessoa?
        Assert.IsAssignableFrom<Funcionario>(funcionario);
    }
}