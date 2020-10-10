using System;

namespace StaticVsNonStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[] { 1, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37 };
            //FuncionesASecas f = new FuncionesASecas();
            //int enMedio = f.mediana(arreglo);
            int enMedio = FuncionesEstaticas.mediana(arreglo);
            Console.WriteLine("La mediana es: {0}", enMedio);
            aHuevo();
        }

        static void aHuevo() {
            Console.WriteLine("a huevooo...");
        }
    }

    public class FuncionesEstaticas
    {
        //Funcion o metodo estatico
        public static int mediana(int[] arregloOrdenado) {
            int size = arregloOrdenado.Length;
            int ombligo = size / 2;
            return arregloOrdenado[ombligo];
        }
    }

    public class FuncionesASecas
    {
        // Funcion o metodo de instancia
        public int mediana(int[] arregloOrdenado) {
            int size = arregloOrdenado.Length;
            int ombligo = size / 2;
            return arregloOrdenado[ombligo];
        }
    }
}
