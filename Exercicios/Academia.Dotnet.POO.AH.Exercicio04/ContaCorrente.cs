namespace Academia.Dotnet.POO.AH.Exercicio04
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(double saldoInicial) : base(saldoInicial) {}

        public override void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de {valor:C} na conta corrente realizado. Saldo atual: {Saldo:C}");
            }
            else
            {
                Console.WriteLine("O valor do depósito deve ser maior que zero.");
            }
        }

        public override void Sacar(double valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} da conta corrente realizado. Saldo atual: {Saldo:C}");
            }
            else
            {
                Console.WriteLine("Saque não permitido. Verifique o valor a ser sacado ou saldo insuficiente.");
            }
        }
    }
}
