namespace Academia.Dotnet.POO.AH.Exercicio07
{
    public class Moto : Veiculo
    {
        public int Cilindrada { get; set; }

        public Moto(string marca, int ano, int cilindrada)
            : base(marca, ano)
        {
            Cilindrada = cilindrada;
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Moto - Marca: {Marca}, Ano: {Ano}, Cilindrada: {Cilindrada}cc");
        }
    }
}
