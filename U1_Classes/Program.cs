using System;

namespace U1_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia
            Perro x = new Perro();
            x.edad = 7;
            x.nombre = "Firulais";

            Console.WriteLine("{0} tiene {1} anios de edad", x.nombre, x.edad);
            Console.WriteLine("Y el perro hace asi:");
            x.habla();

            Calculatron2077 calc = new Calculatron2077();
            Console.WriteLine("Dame 2 numeros a multiplicar:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = calc.multiplica(a, b);
            Console.WriteLine("El resultado fue: {0}", c);
        }
    }

    class Perro
    {
        // Propiedades
        public int edad;
        public string nombre;

        // Constructor
        public Perro()
        {
            Console.WriteLine("Ha nacido un perro!");
        }

        // Metodo
        public void habla()
        {
            Console.WriteLine("guau guau");
        }
    }

    class Calculatron2077
    {
        public Calculatron2077()
        {
            Console.WriteLine("Se ha creado una nueva calculadora 2077");
        }
        
        public int suma(int a, int b)
        {
            return a + b;
        }

        public int multiplica(int a, int b)
        {
            return a * b;
        }
    }
}
