namespace Academia.Dotnet.POO.AH.Exercicio09
{
    public class Estudante : Pessoa
    {
        public string Matricula { get; set; }
        public string Curso { get; set; }

        public Estudante(string nome, int idade, string matricula, string curso)
            : base(nome, idade)
        {
            Matricula = matricula;
            Curso = curso;
        }
    }
}
