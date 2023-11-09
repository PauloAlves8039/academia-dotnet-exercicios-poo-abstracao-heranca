using Academia.Dotnet.POO.AH.Exercicio11;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Produtos *****");

        Console.WriteLine("\nDigite os dados do produto 1: ");

        Console.Write("Nome: ");
        string nomeDoProduto1 = Console.ReadLine();

        Console.WriteLine("\nDigite os dados do produto 2: ");

        Console.Write("Nome: ");
        string nomeDoProduto2 = Console.ReadLine();

        Console.Write("Preço: ");
        double precoDoProduto2 = double.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite os dados do produto 3: ");

        Console.Write("Nome: ");
        string nomeDoProduto3 = Console.ReadLine();

        Console.Write("Preço: ");
        double precoDoProduto3 = double.Parse(Console.ReadLine());

        Console.Write("Estoque: ");
        int estoqueDoProduto3 = int.Parse(Console.ReadLine());

        Console.WriteLine("---------- Resultado ----------");

        Produto produto1 = new Produto(nomeDoProduto1);
        Produto produto2 = new Produto(nomeDoProduto2, precoDoProduto2);
        Produto produto3 = new Produto(nomeDoProduto3, precoDoProduto3, estoqueDoProduto3);

        Console.WriteLine($"Produto 1 - Nome: {produto1.Nome}, Preço: {produto1.Preco}, Estoque: {produto1.Estoque}");
        Console.WriteLine($"Produto 2 - Nome: {produto2.Nome}, Preço: {produto2.Preco}, Estoque: {produto2.Estoque}");
        Console.WriteLine($"Produto 3 - Nome: {produto3.Nome}, Preço: {produto3.Preco}, Estoque: {produto3.Estoque}");

        Console.ReadKey();
    }
}