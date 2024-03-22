using System;

namespace CalculaRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();
            Console.WriteLine("Digite a altura do retângulo.");
            ret.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura do retângulo");
            ret.Largura = double.Parse(Console.ReadLine());

            double area = ret.CalculaArea();
            double perimetro = ret.CalculaPerimetro();
            double diagonal = ret.DiagonalRetangulo();

            Console.WriteLine($" A área do retângulo é de: {area}");
            Console.WriteLine($"O perímetro do retângulo é de: {perimetro}");
            Console.WriteLine($"A diagonal do retângulo é: {diagonal}");
        }
    }
}
