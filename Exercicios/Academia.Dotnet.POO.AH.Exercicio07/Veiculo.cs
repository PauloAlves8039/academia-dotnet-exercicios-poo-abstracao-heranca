namespace Academia.Dotnet.POO.AH.Exercicio07
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public int Ano { get; set; }

        public Veiculo(string marca, int ano)
        {
            Marca = marca;
            Ano = ano;
        }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Marca: {Marca}, Ano: {Ano}");
        }
    }
}
