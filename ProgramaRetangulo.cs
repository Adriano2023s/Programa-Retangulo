using System;

namespace ProgramaRetangulo
{
    internal class ProgramaRetangulo
    {
        public double Altura;
        public double Largura;

        public ProgramaRetangulo(double altura, double largura)
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
