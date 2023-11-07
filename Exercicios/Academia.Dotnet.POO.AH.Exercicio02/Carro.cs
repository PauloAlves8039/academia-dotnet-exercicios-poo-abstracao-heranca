namespace Academia.Dotnet.POO.AH.Exercicio02
{
    public class Carro : Veiculo
    {
        public int QuantidadeDePortas { get; set; }

        public Carro(string marca, string modelo, int quantidadeDePortas) : base(marca, modelo)
        {
            QuantidadeDePortas = quantidadeDePortas;
        }

        public override void Dirigir()
        {
            Console.WriteLine($"Dirigindo o {Marca} {Modelo} com {QuantidadeDePortas} portas");
        }
    }
}
