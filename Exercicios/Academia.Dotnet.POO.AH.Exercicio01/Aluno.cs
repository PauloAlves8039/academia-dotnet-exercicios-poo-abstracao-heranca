namespace Academia.Dotnet.POO.AH.Exercicio01
{
    public class Aluno : Pessoa
    {
        public int Matricula { get; set; }

        public Aluno(string nome, int idade, int matricula) : base(nome, idade)
        {
            Matricula = matricula;
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Matrícula: {Matricula}");
        }
    }
}
