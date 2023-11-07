namespace Academia.Dotnet.POO.AH.Exercicio01
{
    public class Professor : Pessoa
    {
        public string Disciplina { get; set; }

        public Professor(string nome, int idade, string disciplina) : base(nome, idade)
        {
            Disciplina = disciplina;
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Disciplina: {Disciplina}");
        }
    }
}
