namespace Academia.Dotnet.POO.AH.Exercicio05
{
    public class Livro : Produto
    {
        public Livro(string nome, double preco) : base(nome, preco) {}

        public override double CalcularDesconto()
        {
            return Preco * 0.05;
        }
    }
}
