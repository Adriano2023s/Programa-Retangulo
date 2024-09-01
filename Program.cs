using System;

namespace ProgramaRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProgramaRetangulo pr = new ProgramaRetangulo(3, 8);

            Console.WriteLine($"A área do retângulo é de: {pr.CalculaArea()}");
            Console.WriteLine($"O perímetro do retângulo é de: {pr.CalculaPerimetro()}");
            Console.WriteLine($"A diagonal do retãngulo é de: {pr.CalculaDiagonal()}");
        }
    }
}
