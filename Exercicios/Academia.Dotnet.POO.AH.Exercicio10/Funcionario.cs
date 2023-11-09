namespace Academia.Dotnet.POO.AH.Exercicio10
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public virtual double CalcularBonus()
        {
            return Salario * 0.1;
        }

        public virtual string MostrarFuncao()
        {
            return "Funcionário genérico";
        }
    }
}
