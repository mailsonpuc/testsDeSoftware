namespace Demo.Tests;

public class AssertingObjectTypesTests
{
    [Fact]
    public void FuncionarioFactory_Criar_DeveRetornarTipoFuncionario()
    {
        //Arrange & Act
        var funcionario = FuncionarioFactory.Criar("Mailson", 2000);
        //assert
        Assert.IsType<Funcionario>(funcionario);
    }

    [Fact]
    public void FuncionarioFactory_Criar_DeveRetornarTipoDerivadoPessoa()
    {
        //Arrange & Act
        var funcionario = FuncionarioFactory.Criar("Mailson", 2000);
        
        //assert
        Assert.IsAssignableFrom<Pessoa>(funcionario); //funcionario herdam de pessoa?
    }
}