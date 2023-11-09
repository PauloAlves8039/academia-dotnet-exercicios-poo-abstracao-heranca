namespace Academia.Dotnet.POO.AH.Exercicio08
{
    public class Calculadora
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Somar(int a, int b, int c)
        {
            return a + b + c;
        }

        public decimal Somar(decimal a, decimal b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Subtrair(int a, int b, int c)
        {
            return a - b - c;
        }

        public decimal Subtrair(decimal a, decimal b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Multiplicar(int a, int b, int c)
        {
            return a * b * c;
        }

        public decimal Multiplicar(decimal a, decimal b)
        {
            return a * b;
        }

        public int Dividir(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
                return 0;
            }

            return a / b;
        }

        public int Dividir(int a, int b, int c)
        {
            if (b == 0 || c == 0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
                return 0;
            }

            return a / (b * c);
        }

        public decimal Dividir(decimal a, decimal b)
        {
            if (b == 0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
                return 0;
            }

            return a / b;
        }
    }
}
