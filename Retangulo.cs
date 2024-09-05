using System;

namespace ProgramaRetangulo
{
    internal class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

public Retangulo()
        {

        }

        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }

      public double CalculaArea()
        {
            return Largura * Altura;
            }

        public double CalculaPerimetro()
        {
return 2 * (Altura + Largura);
            }

        public double CalculaDiagonal()
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }
    }
}
