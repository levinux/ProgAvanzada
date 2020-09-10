using System;

namespace U1_Areas
{
    class Areas
    {
        public static double Triangulo(double baset, double altura)
        {
            return (baset * altura) / 2;
        }

        public static double Cuadrado(double lado)
        {
            return Math.Pow(lado, 2);
        }

        public static double Circunferencia(double radio)
        {
            return Math.Pow(radio, 2) * Math.PI;
        }
    }

    class AreasInst
    {
        public double Triangulo(double baset, double altura)
        {
            return (baset * altura) / 2;
        }

        public double Cuadrado(double lado)
        {
            return Math.Pow(lado, 2);
        }

        public double Circunferencia(double radio)
        {
            return Math.Pow(radio, 2) * Math.PI;
        }
    }
}