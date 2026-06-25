using Xunit;

namespace Calculadora.Tests;

public class AssertingRangesTests
{
    // Verifica que o salário do funcionário está dentro da faixa correta para seu nível profissional.
    [Theory]
    [InlineData(700)]
    [InlineData(1500)]
    [InlineData(2000)]
    [InlineData(7500)]
    [InlineData(8000)]
    [InlineData(15000)]
    public void Funcionario_Salario_FaixasSalariaisDevemRespeitarNivelProfissional(double salario)
    {
        // Arrange & Act
        var funcionario = new Funcionario("Eduardo", salario);
        
        // Assert
        if (funcionario.NivelProfissional == NivelProfissional.Junior)
        {
            // De 500 até a "borda" de 2000 (ex: 1999.99)
            Assert.InRange(funcionario.Salario, 500, 1999.99);
        }
        
        if (funcionario.NivelProfissional == NivelProfissional.Pleno)
        {
            Assert.InRange(funcionario.Salario, 2000, 7999.99);
        }
        
        if (funcionario.NivelProfissional == NivelProfissional.Senior)
        {
            Assert.InRange(funcionario.Salario, 8000, double.MaxValue);
        }
        
        // Garante que o salário nunca estará abaixo do mínimo permitido
        Assert.NotInRange(funcionario.Salario, 0, 499.99);
    }
}