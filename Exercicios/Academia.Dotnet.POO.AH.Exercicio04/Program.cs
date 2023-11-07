using Academia.Dotnet.POO.AH.Exercicio04;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Conta Bancária *****");

        Console.WriteLine("\nDigite as operações para a Conta Corrente: ");

        Console.Write("Valor do depósito: ");
        double depositoContaCorrente = double.Parse(Console.ReadLine());

        Console.Write("Valor do saque: ");
        double saqueContaCorrente = double.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite as operações para a Conta Poupança: ");

        Console.Write("Valor do depósito: ");
        double depositoContaPoupanca = double.Parse(Console.ReadLine());

        Console.Write("Valor do saque: ");
        double saqueContaPoupanca = double.Parse(Console.ReadLine());

        Console.WriteLine("\n---------- Resultado ----------");

        ContaCorrente contaCorrente = new ContaCorrente(1000);
        ContaPoupanca contaPoupanca = new ContaPoupanca(500);

        Console.WriteLine("Conta Corrente: ");
        contaCorrente.Depositar(depositoContaCorrente);
        contaCorrente.Sacar(saqueContaCorrente);

        Console.WriteLine();

        Console.WriteLine("Conta Poupança: ");
        contaPoupanca.Depositar(depositoContaPoupanca);
        contaPoupanca.Sacar(saqueContaPoupanca);

        Console.ReadKey();
    }
}