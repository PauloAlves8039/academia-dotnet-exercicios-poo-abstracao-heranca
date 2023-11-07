namespace Academia.Dotnet.POO.AH.Exercicio02
{
    public class Moto : Veiculo
    {
        public int Cilindrada { get; set; }

        public Moto(string marca, string modelo, int cilindrada) : base(marca, modelo)
        {
            Cilindrada = cilindrada;
        }

        public override void Dirigir()
        {
            Console.WriteLine($"Dirigindo a {Marca} {Modelo} com {Cilindrada} cilindradas");
        }
    }
}
