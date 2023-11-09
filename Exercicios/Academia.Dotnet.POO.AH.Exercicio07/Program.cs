using Academia.Dotnet.POO.AH.Exercicio07;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Lista de Veículos *****");

        List<Veiculo> veiculos = new List<Veiculo>();

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Digite os dados do {(i + 1)}º veículo(1° véiculo - 2° carro - 3° moto):");
            Console.Write("Marca: ");
            string marca = Console.ReadLine();
            Console.Write("Ano: ");
            if (int.TryParse(Console.ReadLine(), out int ano))
            {
                if (i == 0)
                {
                    veiculos.Add(new Veiculo(marca, ano));
                }
                else if (i == 1)
                {
                    Console.Write("Número de Portas: ");

                    if (int.TryParse(Console.ReadLine(), out int numeroDePortas))
                    {
                        veiculos.Add(new Carro(marca, ano, numeroDePortas));
                    }
                    else
                    {
                        Console.WriteLine("Número de Portas inválido. O veículo não foi adicionado.");
                    }
                }
                else if (i == 2)
                {
                    Console.Write("Cilindrada (cc): ");

                    if (int.TryParse(Console.ReadLine(), out int cilindrada))
                    {
                        veiculos.Add(new Moto(marca, ano, cilindrada));
                    }
                    else
                    {
                        Console.WriteLine("Cilindrada inválida. O veículo não foi adicionado.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Ano inválido. O veículo não foi adicionado.");
            }
        }

        Console.WriteLine("\n------------- Resultado -------------");

        foreach (var veiculo in veiculos)
        {
            veiculo.Apresentar();
        }

        Console.ReadKey();
    }
}