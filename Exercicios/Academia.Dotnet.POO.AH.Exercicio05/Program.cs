using Academia.Dotnet.POO.AH.Exercicio05;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Produtos *****");

        Console.WriteLine("\nDigite os dados do Livro: ");

        Console.Write("Nome: ");
        string nomeDoLivro = Console.ReadLine();

        Console.Write("Preço: ");
        double precoDoLivro = double.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite os dados do Eletrônico: ");

        Console.Write("Nome: ");
        string nomeDoEletronico = Console.ReadLine();

        Console.Write("Preço: ");
        double precoDoEletronico = double.Parse(Console.ReadLine());

        Livro livro = new Livro(nomeDoLivro, precoDoLivro);
        Eletronico eletronico = new Eletronico(nomeDoEletronico, precoDoEletronico);

        Console.WriteLine("\n---------- Resultado ----------");

        Console.WriteLine($"Desconto para o livro {livro.Nome}: {livro.CalcularDesconto():C}");
        Console.WriteLine($"Desconto para o eletrônico {eletronico.Nome}: {eletronico.CalcularDesconto():C}");

        Console.ReadKey();
    }
}