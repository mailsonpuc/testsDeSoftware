namespace Calculadora.Tests;

public class AssertStringsTests
{
    // Verifica que unir nomes retorna a string completa com espaço.
    [Fact]
    public void StringdTools_UnirNomes_RetornarNomeCompleto()
    {
        //Arrage
        var sut = new StringsTools();
        //Act
        var nomeCompleto = sut.Unir("Eduardo", "Pires");
        //Assert
        Assert.Equal("Eduardo Pires", nomeCompleto);
    }
    
    
    // Verifica que a união de nomes compare corretamente ignorando letras maiúsculas e minúsculas.
    [Fact]
    public void StringdTools_UnirNomes_DeveIgnorarCase()
    {
        //Arrage
        var sut = new StringsTools();
        //Act
        var nomeCompleto = sut.Unir("Eduardo", "Pires");
        //Assert
        Assert.Equal("Eduardo Pires", nomeCompleto, true);
    }
    
    
    // Verifica que o nome completo contém o trecho esperado.
    [Fact]
    public void StringdTools_UnirNomes_DeveConterTrecho()
    {
        //Arrage
        var sut = new StringsTools();
        //Act
        var nomeCompleto = sut.Unir("Eduardo", "Pires");
        //Assert
        Assert.Contains("ardo", nomeCompleto);
    }
    
    
    
    // Verifica que o nome completo começa com o prefixo esperado.
    [Fact]
    public void StringdTools_UnirNomes_DeveComecarCom()
    {
        //Arrage
        var sut = new StringsTools();
        //Act
        var nomeCompleto = sut.Unir("Eduardo", "Pires");
        //Assert
        Assert.StartsWith("Edu", nomeCompleto);
    }
    
    
    // Verifica que o nome completo termina com o sufixo esperado.
    [Fact]
    public void StringdTools_UnirNomes_DeveCabarCom()
    {
        //Arrage
        var sut = new StringsTools();
        //Act
        var nomeCompleto = sut.Unir("Eduardo", "Pires");
        //Assert
        Assert.EndsWith("res", nomeCompleto);
    }
    
    
    // Verifica que o nome completo corresponde ao formato esperado usando expressão regular.
    [Fact]
    public void StringdTools_UnirNomes_ValidarExpressaoRegular()
    {
        //Arrage
        var sut = new StringsTools();
        //Act
        var nomeCompleto = sut.Unir("Eduardo", "Pires");
        //Assert
        Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]", nomeCompleto);
    }
}