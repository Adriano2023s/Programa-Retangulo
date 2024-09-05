using System;

namespace ProgramaRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Digite a autura, e largura do retângulo \n");
            r.Altura = double.Parse(Console.ReadLine());
            r.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine($"A área do retãngulo é de: {r.CalculaArea()}");
            Console.WriteLine($"O perímetro do retângulo é de: {r.CalculaPerimetro()}");
            Console.WriteLine($"A diagonal do retângulo é de: {r.CalculaDiagonal()}");
        }
    }
}
