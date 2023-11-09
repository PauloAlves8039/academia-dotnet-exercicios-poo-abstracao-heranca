namespace Academia.Dotnet.POO.AH.Exercicio06
{
    public class ContaBancaria
    {
        public double Saldo { get; protected set; }

        public ContaBancaria(double saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public virtual void Depositar(double valor)
        {
            Saldo += valor;
        }

        public virtual void Sacar(double valor)
        {
            Saldo -= valor;
        }
    }
}
