using Academia.Dotnet.POO.AH.Exercicio01;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Curso *****");

        Console.WriteLine("\nDigite os dados do Aluno(a): ");

        Console.Write("Nome: ");
        string nomeDoAluno = Console.ReadLine();

        Console.Write("Idade: ");
        int idadeDoAluno = int.Parse(Console.ReadLine());

        Console.Write("Matricula: ");
        int matriculaDoAluno = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite os dados do Professor(a): ");

        Console.Write("Nome: ");
        string nomeDoProfessor = Console.ReadLine();

        Console.Write("Idade: ");
        int idadeDoProfessor = int.Parse(Console.ReadLine());

        Console.Write("Disciplina: ");
        string disciplina = Console.ReadLine();

        Aluno aluno = new Aluno(nomeDoAluno, idadeDoAluno, matriculaDoAluno);
        Professor professor = new Professor(nomeDoProfessor, idadeDoProfessor, disciplina);

        Console.WriteLine("----- Resultado -----");

        aluno.Apresentar();
        professor.Apresentar();

        Console.ReadKey();
    }
}