using Academia.Dotnet.POO.AH.Exercicio08;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Calculadora *****");

        Calculadora calculadora = new Calculadora();

        Console.WriteLine("\nDigite os valores inteiros: ");
        
        Console.Write("Valor inteiro 1: ");
        int numeroInteiro1 = int.Parse(Console.ReadLine());

        Console.Write("Valor inteiro 2: ");
        int numeroInteiro2 = int.Parse(Console.ReadLine());

        Console.Write("Valor inteiro 3: ");
        int numeroInteiro3 = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite os valores decimais: ");

        Console.Write("Valor decimal 1: ");
        decimal numeroDecimal1 = decimal.Parse(Console.ReadLine());

        Console.Write("Valor decimal 2: ");
        decimal numeroDecimal2 = decimal.Parse(Console.ReadLine());

        Console.WriteLine("\n---------- Resultado ----------");

        int somaInteira = calculadora.Somar(numeroInteiro1, numeroInteiro2);
        decimal somaDecimal = calculadora.Somar(numeroDecimal1, numeroDecimal2);
        int somaInteiraTres = calculadora.Somar(numeroInteiro1, numeroInteiro2, numeroInteiro3);

        Console.WriteLine($"Soma Inteira: {somaInteira}");
        Console.WriteLine($"Soma Decimal: {somaDecimal}");
        Console.WriteLine($"Soma Inteira com 3 parâmetros: {somaInteiraTres}");

        int subtracaoInteira = calculadora.Subtrair(numeroInteiro1, numeroInteiro2);
        decimal subtracaoDecimal = calculadora.Subtrair(numeroDecimal1, numeroDecimal2);
        int subtracaoInteiraTres = calculadora.Subtrair(numeroInteiro1, numeroInteiro2, numeroInteiro3);

        Console.WriteLine($"Subtração Inteira: {subtracaoInteira}");
        Console.WriteLine($"Subtração Decimal: {subtracaoDecimal}");
        Console.WriteLine($"Subtração Inteira com 3 parâmetros: {subtracaoInteiraTres}");

        int multiplicacaoInteira = calculadora.Multiplicar(numeroInteiro1, numeroInteiro2);
        decimal multiplicacaoDecimal = calculadora.Multiplicar(numeroDecimal1, numeroDecimal2);
        int multiplicacaoInteiraTres = calculadora.Multiplicar(numeroInteiro1, numeroInteiro2, numeroInteiro3);

        Console.WriteLine($"Multiplicação Inteira: {multiplicacaoInteira}");
        Console.WriteLine($"Multiplicação Decimal: {multiplicacaoDecimal}");
        Console.WriteLine($"Multiplicação Inteira com 3 parâmetros: {multiplicacaoInteiraTres}");

        int divisaoInteira = calculadora.Dividir(numeroInteiro1, numeroInteiro2);
        decimal divisaoDecimal = calculadora.Dividir(numeroDecimal1, numeroDecimal2);
        int divisaoInteiraTres = calculadora.Dividir(numeroInteiro1, numeroInteiro2, numeroInteiro3);

        Console.WriteLine($"Divisão Inteira: {divisaoInteira}");
        Console.WriteLine($"Divisão Decimal: {divisaoDecimal}");
        Console.WriteLine($"Divisão Inteira com 3 parâmetros: {divisaoInteiraTres}");

        Console.ReadKey();
    }
}