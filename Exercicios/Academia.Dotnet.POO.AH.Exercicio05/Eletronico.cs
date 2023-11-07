﻿namespace Academia.Dotnet.POO.AH.Exercicio05
{
    public class Eletronico : Produto
    {
        public Eletronico(string nome, double preco) : base(nome, preco) {}

        public override double CalcularDesconto()
        {
            return Preco * 0.125;
        }
    }
}
