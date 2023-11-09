using Academia.Dotnet.POO.AH.Exercicio09;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Curso *****");

        Console.WriteLine("\nDigite os dados do Aluno(a): ");

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Matricula: ");
        string matricula = Console.ReadLine();

        Console.Write("Curso: ");
        string curso = Console.ReadLine();

        Console.WriteLine("---------- Resultado ----------");

        Estudante estudante = new Estudante(nome, idade, matricula, curso);

        Console.WriteLine($"Nome: {estudante.Nome}");
        Console.WriteLine($"Idade: {estudante.Idade}");
        Console.WriteLine($"Matrícula: {estudante.Matricula}");
        Console.WriteLine($"Curso: {estudante.Curso}");

        Console.ReadKey();
    }
}