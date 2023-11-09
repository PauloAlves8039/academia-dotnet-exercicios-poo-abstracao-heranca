namespace Academia.Dotnet.POO.AH.Exercicio11
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }

        public Produto(string nome)
        {
            Nome = nome;
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }
    }
}
