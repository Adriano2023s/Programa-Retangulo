using System;

namespace CalculaRetangulo
{
    public class Retangulo
    {
        public double Altura;
        public double Largura;
        public double Area;
        public double Diagonal;
        public double Perimetro;
        public double CalculaArea()
        {
            Area = Altura * Largura;
            return Area;
        }
        public double DiagonalRetangulo()
        {
            Diagonal = Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
            return Diagonal;
        }
        public double CalculaPerimetro()
        {
            Perimetro = Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
            return Perimetro;
        }
    }
}
