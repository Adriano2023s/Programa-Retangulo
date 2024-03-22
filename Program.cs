using System;

namespace CalculaRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a altura do retângulo.");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura do retângulo");
            double largura = double.Parse(Console.ReadLine());

            double area = CalculaArea(altura, largura);
            double diagonal = DiagonalRetangulo(altura, largura);
            double perimetro = CalculaPerimetro(altura, largura);

            Console.WriteLine($" A área do retângulo é de: {area}");
            Console.WriteLine($"O perímetro do retângulo é de: {perimetro}");
        }
        public static double CalculaArea( double altura, double largura )
        {
            return altura * largura;
        }
        public static double DiagonalRetangulo( double altura, double largura )
        {
            return Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(largura, 2));
        }
        public static double CalculaPerimetro( double altura, double largura )
        {
            return Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(-largura, 2));
        }
    }
}
