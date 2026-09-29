namespace Demo.Tests;

public class AssertingCollectionsTests
{
    [Fact]
    public void Funcionario_Habilidades_NaoDevePossuirHabilidadesVazias()
    {
        // Arrange & Act
        var funcionario = FuncionarioFactory.Criar("Mailson", 2000);

        // Assert
        Assert.NotEmpty(funcionario.Habilidades);

        Assert.All(
            funcionario.Habilidades,
            habilidade => Assert.False(string.IsNullOrWhiteSpace(habilidade))
        );
    }

    [Fact]
    public void Funcionario_Junior_DevePossuirApenasHabilidadesBasicas()
    {
        // Arrange & Act
        var funcionario = FuncionarioFactory.Criar("Junior", 1500);

        // Assert
        Assert.Contains("Logica de programaçao", funcionario.Habilidades);
        Assert.Contains("OOP", funcionario.Habilidades);

        Assert.DoesNotContain("Testes", funcionario.Habilidades);
        Assert.DoesNotContain("Microservices", funcionario.Habilidades);
    }

    [Fact]
    public void Funcionario_Pleno_DevePossuirHabilidadesBasicasETestes()
    {
        // Arrange & Act
        var funcionario = FuncionarioFactory.Criar("Pleno", 2000);

        // Assert
        Assert.Contains("Logica de programaçao", funcionario.Habilidades);
        Assert.Contains("OOP", funcionario.Habilidades);
        Assert.Contains("Testes", funcionario.Habilidades);

        Assert.DoesNotContain("Microservices", funcionario.Habilidades);
    }

    [Fact]
    public void Funcionario_Senior_DevePossuirTodasAsHabilidades()
    {
        // Arrange & Act
        var funcionario = FuncionarioFactory.Criar("Senior", 9000);

        var habilidadesEsperadas = new[]
        {
            "Logica de programaçao",
            "OOP",
            "Testes",
            "Microservices"
        };

        // Assert
        Assert.Equal(habilidadesEsperadas, funcionario.Habilidades);
    }
}