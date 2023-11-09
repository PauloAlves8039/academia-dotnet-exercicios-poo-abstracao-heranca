using Academia.Dotnet.POO.AH.Exercicio06;

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
        ContaPoupanca contaPoupanca = new ContaPoupanca(1000);

        Console.WriteLine("Saldo Inicial da Conta Corrente: " + contaCorrente.Saldo);
        Console.WriteLine("Saldo Inicial da Conta Poupança: " + contaPoupanca.Saldo);

        contaCorrente.Depositar(depositoContaCorrente);
        contaPoupanca.Depositar(depositoContaPoupanca);

        Console.WriteLine("Saldo após depósito na Conta Corrente: " + contaCorrente.Saldo);
        Console.WriteLine("Saldo após depósito na Conta Poupança: " + contaPoupanca.Saldo);

        contaCorrente.Sacar(saqueContaCorrente);
        contaPoupanca.Sacar(saqueContaPoupanca);

        Console.WriteLine("Saldo após saque na Conta Corrente: " + contaCorrente.Saldo);
        Console.WriteLine("Saldo após saque na Conta Poupança: " + contaPoupanca.Saldo);

        Console.ReadKey();
    }
}