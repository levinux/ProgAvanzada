using System;

namespace RepasoCsharp
{
    class Mocos
    {
        //static int f = 1; // Globales
        static void Main(string[] args)
        {
            Console.WriteLine("En Main()");
            //saluda("Mecatronica");
            Console.WriteLine("Otra vez en Main()");
            //Console.WriteLine("La suma es {0}", suma(5, 8));
            Console.WriteLine("Factorial de 9 es {0}", factorial(9));
            hacerArreglo();
        }

        static void saluda(string saludo)
        {
            Console.WriteLine("Hola {0}", saludo);
        }

        // modo, tipo a regresar, nombre de la funcion, parametros
        static      int             suma(int a, int b)
        {
            int resultado = a + b;
            return resultado;
        }

        static void hacerArreglo()
        {
            // Arreglo estatico
            int[] valores = { 3, 6, 9, 12, 15, 18, 21 };

            // Arreglo vacio
            int[] nose = new int[10];

            // Arreglo multidimensional (tabla o matrix)
            int[,] cuadrada = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[, ,] cubo = {
                {
                    {0, 1, 2},
                    {3, 4, 5},
                    {6, 7, 8}
                },
                {
                    {10, 11, 12},
                    {13, 14, 15},
                    {16, 17, 18}
                },
                {
                    {20, 21, 22},
                    {23, 24, 25},
                    {26, 27, 28}
                },
            };

            Console.WriteLine("arreglo estatico valor 4 es: {0} ", valores[4]);
            Console.WriteLine("arreglo vacio, valor 4 es: {0} ", nose[4]);
            Console.WriteLine("arreglo matricial valor en medio es: {0} ", cuadrada[2, 1]);
            Console.WriteLine("arreglo matricial valor en medio medio es: {0} ", cubo[1, 1, 1]);
        }

        static int factorial(int n)
        {
            int f = 1; // Vars locales
            for(int i = 1; i <= n; i++)
            {
                f = f * i;
            }

            return f;
        }
    }
}
