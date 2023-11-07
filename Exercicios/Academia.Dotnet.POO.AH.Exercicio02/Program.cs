using Academia.Dotnet.POO.AH.Exercicio02;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Veículo *****");

        Console.WriteLine("\nDigite os dados do Carro: ");

        Console.Write("Marca: ");
        string marcaDoCarro = Console.ReadLine();

        Console.Write("Modelo: ");
        string modeloDoCarro = Console.ReadLine();

        Console.Write("Portas: ");
        int quantidadeDePortas = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite os dados da Moto: ");

        Console.Write("Marca: ");
        string marcaDaMoto = Console.ReadLine();

        Console.Write("Modelo: ");
        string modeloDaMoto = Console.ReadLine();

        Console.Write("Cilindradas: ");
        int cilindradas = int.Parse(Console.ReadLine());

        Carro carro = new Carro(marcaDoCarro, modeloDoCarro, quantidadeDePortas);
        Moto moto = new Moto(marcaDaMoto, modeloDaMoto, cilindradas);

        Console.WriteLine("---------- Resultado ----------");

        Console.WriteLine("Carro:");
        carro.Dirigir();

        Console.WriteLine("\nMoto:");
        moto.Dirigir();

        Console.ReadKey();
    }
}