namespace Academia.Dotnet.POO.AH.Exercicio06
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(double saldoInicial) : base(saldoInicial) {}

        public override void Sacar(double valor)
        {
            Saldo -= valor + 0.10;
        }

        public override void Depositar(double valor)
        {
            Saldo += valor;
        }
    }
}
