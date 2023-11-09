namespace Academia.Dotnet.POO.AH.Exercicio06
{
    public class ContaCorrente : ContaBancaria
    {
        private bool primeiroSaqueGratuito = true;

        public ContaCorrente(double saldoInicial) : base(saldoInicial) {}

        public override void Sacar(double valor)
        {
            if (primeiroSaqueGratuito)
            {
                Saldo -= valor;
                primeiroSaqueGratuito = false;
            }
            else
            {
                Saldo -= valor + 0.05;
            }
        }

        public override void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine("Saldo após depósito: " + Saldo);
        }
    }
}
