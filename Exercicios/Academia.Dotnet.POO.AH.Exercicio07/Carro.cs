namespace Academia.Dotnet.POO.AH.Exercicio07
{
    public class Carro : Veiculo
    {
        public int NumeroDePortas { get; set; }

        public Carro(string marca, int ano, int numeroDePortas)
            : base(marca, ano)
        {
            NumeroDePortas = numeroDePortas;
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Carro - Marca: {Marca}, Ano: {Ano}, Número de Portas: {NumeroDePortas}");
        }
    }
}
