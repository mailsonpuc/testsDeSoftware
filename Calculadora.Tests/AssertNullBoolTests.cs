namespace Calculadora.Tests;

public class AssertNullBoolTests
{
    // Verifica que o nome do funcionário não fica nulo ou vazio quando criado com nome vazio.
    [Fact]
    public void Funcionario_Nome_NaoDeveSerNuloOuVazio()
    {
        //Arrange & Act
        var funcionario = new Funcionario("", 1000);
        
        //Assert
        Assert.False(string.IsNullOrEmpty(funcionario.Nome));
    }
    
    
    // Verifica que o apelido do funcionário é nulo e não possui conteúdo.
    [Fact]
    public void Funcionario_Apelido_NaoDeveTerApelido()
    {
        //Arrange & Act
        var funcionario = new Funcionario("Eduardo" , 1000);
        
        //Assert
        Assert.Null(funcionario.Apelido);
        
        //Assert bool
        Assert.True(string.IsNullOrEmpty(funcionario.Apelido));
        Assert.False(funcionario.Apelido?.Length > 0);
    }
    
}