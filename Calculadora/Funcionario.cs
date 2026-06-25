namespace Calculadora;

public class Pessoa
{
    public string Nome { get; protected set; }
    public string Apelido { get; set; }
}

public enum NivelProfissional
{
    Junior,
    Pleno,
    Senior
}

public class Funcionario : Pessoa
{
    public double Salario { get; private set; }
    public NivelProfissional NivelProfissional { get; private set; }
    public IList<string> Habilidades { get; private set; }

    public Funcionario(string nome, double salario)
    {
        Nome = string.IsNullOrWhiteSpace(nome) ? "Fulano" : nome;

        DefinirSalario(salario);
        DefinirHabilidades();
    }

    private void DefinirSalario(double salario)
    {
        if (salario < 500)
            throw new ArgumentException("Salário inferior ao permitido.");

        Salario = salario;

        if (salario < 2000)
            NivelProfissional = NivelProfissional.Junior;
        else if (salario < 8000)
            NivelProfissional = NivelProfissional.Pleno;
        else
            NivelProfissional = NivelProfissional.Senior;
    }

    private void DefinirHabilidades()
    {
        var habilidadesBasicas = new List<string>
        {
            "Logica de Programacao",
            "OOP"
        };

        Habilidades = habilidadesBasicas;

        switch (NivelProfissional)
        {
            case NivelProfissional.Pleno:
                Habilidades.Add("Tests");
                break;

            case NivelProfissional.Senior:
                Habilidades.Add("Tests");
                Habilidades.Add("Microservices");
                break;
        }
    }
}

public class FuncionarioFactory
{
    public static Funcionario Criar(string nome, double salario)
    {
        return new Funcionario(nome, salario);
    }
}