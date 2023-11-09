using Academia.Dotnet.POO.AH.Exercicio10;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Empresa *****");

        Console.WriteLine("\nDigite os dados do(a) Funcionario(a): ");

        Console.Write("Nome: ");
        string nomeDoFuncionario = Console.ReadLine();

        Console.Write("Salário: ");
        double salarioDoFuncionario = double.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite os dados do(a) Gerente: ");

        Console.Write("Nome: ");
        string nomeDoGerente = Console.ReadLine();

        Console.Write("Salário: ");
        double salarioDoGerente = double.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite os dados do(a) Desenvolvedor(a): ");

        Console.Write("Nome: ");
        string nomeDoDesenvolvedor = Console.ReadLine();

        Console.Write("Salário: ");
        double salarioDoDesenvolvedor = double.Parse(Console.ReadLine());

        Console.WriteLine("---------- Resultado ----------");

        Funcionario funcionario = new Funcionario(nomeDoFuncionario, salarioDoFuncionario);
        Gerente gerente = new Gerente(nomeDoGerente, salarioDoGerente);
        Desenvolvedor desenvolvedor = new Desenvolvedor(nomeDoDesenvolvedor, salarioDoDesenvolvedor);

        Console.WriteLine($"Nome: {funcionario.Nome}" );
        Console.WriteLine($"Salário: {funcionario.Salario}");
        Console.WriteLine($"Bônus: {funcionario.CalcularBonus()}");
        Console.WriteLine($"Função: {funcionario.MostrarFuncao()}");

        Console.WriteLine();

        Console.WriteLine($"Nome: {gerente.Nome}");
        Console.WriteLine($"Salário: {gerente.Salario}");
        Console.WriteLine($"Bônus: {gerente.CalcularBonus()}");
        Console.WriteLine($"Função: {gerente.MostrarFuncao()}");

        Console.WriteLine();

        Console.WriteLine($"Nome: {desenvolvedor.Nome}");
        Console.WriteLine($"Salário: {desenvolvedor.Salario}");
        Console.WriteLine($"Bônus: {desenvolvedor.CalcularBonus()}");
        Console.WriteLine($"Função: {desenvolvedor.MostrarFuncao()}");

        Console.ReadKey();
    }
}