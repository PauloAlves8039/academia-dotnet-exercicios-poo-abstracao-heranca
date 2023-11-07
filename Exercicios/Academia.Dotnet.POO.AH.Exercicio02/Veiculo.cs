﻿namespace Academia.Dotnet.POO.AH.Exercicio02
{
    public abstract class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Veiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public abstract void Dirigir();
    }
}
