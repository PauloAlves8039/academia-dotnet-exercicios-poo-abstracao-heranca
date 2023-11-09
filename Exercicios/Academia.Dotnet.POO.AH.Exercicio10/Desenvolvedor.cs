namespace Academia.Dotnet.POO.AH.Exercicio10
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string nome, double salario) : base(nome, salario) {}

        public override double CalcularBonus()
        {
            return Salario * 0.15;
        }

        public override string MostrarFuncao()
        {
            return "Desenvolvedor";
        }
    }
}
