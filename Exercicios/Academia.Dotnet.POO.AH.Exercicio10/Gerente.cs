namespace Academia.Dotnet.POO.AH.Exercicio10
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, double salario) : base(nome, salario)
        {
        }

        public override double CalcularBonus()
        {
            return Salario * 0.2;
        }

        public override string MostrarFuncao()
        {
            return "Gerente";
        }
    }
}
