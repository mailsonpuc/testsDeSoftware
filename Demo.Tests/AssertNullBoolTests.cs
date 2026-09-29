namespace Demo.Tests;

public class AssertNullBoolTests
{
    [Fact]
    public void Funcionario_Nome_NaoDeveSerNuloOuVazio()
    {
        //arrange & Act
        var funcionario = new Funcionario("", 1500);
        //Assert
        Assert.False(string.IsNullOrEmpty(funcionario.Nome));
    }
    
    [Fact]
    public void Funcionario_Apelido_NaoDeveTerApelido()
    {
        //arrange & Act
        var funcionario = new Funcionario("mailson", 1500);
        //Assert
        Assert.Null(funcionario.Apelido);
        
        //Assert bool
        Assert.True(string.IsNullOrEmpty(funcionario.Apelido));
        Assert.False(funcionario.Apelido?.Length > 0);
    }
    
}