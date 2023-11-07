namespace Academia.Dotnet.POO.AH.Exercicio01
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public abstract void Apresentar();
    }
}
