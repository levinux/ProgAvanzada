using System;

namespace U1_Areas
{
    class Program
    {
        static void Main(string[] args)
        {
            double baset = 0d;
            double altura = 0d;
            Console.WriteLine("Area de un triangulo");
            Console.WriteLine("Dame la base:");
            baset = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dame la altura:");
            altura = Convert.ToDouble(Console.ReadLine());
            double areat = Areas.Triangulo(baset, altura);

            Console.WriteLine("El area del triangulo fue {0}", areat);

            //AreasInst a = new AreasInst();
            //double areax = a.Triangulo(baset, altura);
        }
    }
}
