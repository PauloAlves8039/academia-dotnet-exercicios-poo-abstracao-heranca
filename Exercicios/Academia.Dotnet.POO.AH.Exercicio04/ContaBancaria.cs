namespace Academia.Dotnet.POO.AH.Exercicio04
{
    public abstract class ContaBancaria
    {
        public double Saldo { get; protected set; }

        public ContaBancaria(double saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public abstract void Depositar(double valor);
        public abstract void Sacar(double valor);
    }
}
