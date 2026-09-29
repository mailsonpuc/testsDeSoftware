namespace Demo.Tests;

public class AssertStringsTests
{
    [Fact]
    public void StringsTools_UnirNome_retornarNomeCompleto()
    {
        //Arrange
        var sut = new StringsTools();
        //Act
        var nomeCompleto = sut.Unir("Mailson", "Costa");
        //Assert
        Assert.Equal("Mailson Costa", nomeCompleto);
    }
    
  
    [Fact]
    public void StringsTools_UnirNome_DeveIgnorarCase()
    {
        //Arrange
        var sut = new StringsTools();
        //Act
        var nomeCompleto = sut.Unir("Mailson", "Costa");
        //Assert
        Assert.Equal("MAILSOn COSTA", nomeCompleto, true);
    }
    
    
    [Fact]
    public void StringsTools_UnirNome_DeveConterTrecho()
    {
        //Arrange
        var sut = new StringsTools();
        //Act
        var nomeCompleto = sut.Unir("Mailson", "Costa");
        //Assert
        Assert.Contains("Costa", nomeCompleto);
    }
    
    
    [Fact]
    public void StringsTools_UnirNome_DeveComecarCom()
    {
        //Arrange
        var sut = new StringsTools();
        //Act
        var nomeCompleto = sut.Unir("Mailson", "Costa");
        //Assert
        Assert.StartsWith("Ma", nomeCompleto);
    }
    
    
    [Fact]
    public void StringsTools_UnirNome_DeveAcabarCom()
    {
        //Arrange
        var sut = new StringsTools();
        //Act
        var nomeCompleto = sut.Unir("Mailson", "Costa");
        //Assert
        Assert.EndsWith("ta", nomeCompleto);
    }
    
    [Fact]
    public void StringsTools_UnirNome_ValidarExpressaoRegular()
    {
        //Arrange
        var sut = new StringsTools();
        //Act
        var nomeCompleto = sut.Unir("Mailson", "Costa");
        //Assert
        Assert.Matches("^[A-Z]{1}", nomeCompleto);
    }
}