using System;

namespace ProgramaRetangulo
{
    internal class Retangulo
    {
        private double _Altura;
        private double _Largura;

        public double Altura
        {
            get
            {
                return _Altura;
            }
            set
            {
                _Altura = value;
            }
        }

        public double Largura
        {
            get
            {
                return _Largura;
            }
            set
            {
                _Largura = value;
            }
        }

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
