namespace Calculadora.Tests;

public class AssertingCollectionsTests
{
    // Verifica que todas as habilidades do funcionário são strings não vazias.
    [Fact]
    public void Funcionario_Habilidades_NaoDevePossuirHabilidadesVazias()
    {
        //Arrange e act
        var funcionario = FuncionarioFactory.Criar("Eduardo", 10000);
        
        //Assert
        Assert.All(funcionario.Habilidades, habilidades => Assert.False(string.IsNullOrWhiteSpace(habilidades)));
    }


    // Verifica que um funcionário júnior possui a habilidade básica "OOP".
    [Fact]
    public void Funcionario_Habilidades_JuniorDevePossuirHabilidadeBasica()
    {
        //Arrange e act
        var funcionario = FuncionarioFactory.Criar("Eduardo", 10000);
        
        //Assert
        Assert.Contains("OOP", funcionario.Habilidades);
    }

    // Verifica que um funcionário júnior não possui habilidades avançadas específicas.
    [Fact]
    public void Funcionario_Habilidades_JuniorNaoDevePossuirHabilidadesAvancada()
    {
        //Arrange e act
        var funcionario = FuncionarioFactory.Criar("Eduardo", 10000);
        
        //Assert
        Assert.DoesNotContain("Engenharia de Software", funcionario.Habilidades);
    }


    // Verifica que um funcionário sênior possui todas as habilidades esperadas.
    [Fact]
    public void Funcionario_Habilidades_SeniorDevePossuirTodasHabilidades()
    {
        //Arrange e act
        var funcionario = FuncionarioFactory.Criar("Eduardo", 10000);

        var habilidadesBasicas = new[]
        {
            "Logica de Programacao", "OOP", "Tests", "Microservices"
        };
        
        //Assert
        Assert.Equal(habilidadesBasicas, funcionario.Habilidades);
    }
    
}