using System;
using U0_Intro;
using System.Collections.Generic;

namespace U0_Intro
{
    class Program
    {
        static List<float> ReadValues()
        {
            float k = 0;
            List<float> valores = new List<float>();
            Console.WriteLine("Dame los valores (0 para terminar)");
            for(;;)
            {
                k = (float) Convert.ToDecimal(Console.ReadLine());
                if(k <= 0) break;
                else valores.Add(k);
            }
            return valores;
        }

        static void PrintResult(float resultado)
        {
            Console.WriteLine("El resultado fue: {0}", resultado);
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
        }

        static char PrintMenu()
        {
            char op;
            Console.Clear();
            Console.WriteLine("Opciones:\n");
            Console.WriteLine("\t1. Suma sencilla");
            Console.WriteLine("\t2. Sumatoria");
            Console.WriteLine("\t3. Multiplicacion sencilla");
            Console.WriteLine("\t4. Producto");
            Console.WriteLine("\t5. Salir!!!");
            Console.Write("Opcion: [...]\b\b\b");
            op = Convert.ToChar(Console.ReadLine());
            return op;
        }

        static void Main(string[] args)
        {
            char opcion;
            float resultado = 0;
            List<float> valores;
            Calculatron c = new Calculatron();
            do
            {
                opcion = PrintMenu();
                switch(opcion)
                {
                    case '1': break;
                    case '2':
                        valores = ReadValues();
                        resultado = c.Suma(valores);
                        PrintResult(resultado);
                        break;
                    case '3': break;
                    case '4': break;
                    case '5': Console.WriteLine("Bytes!"); break;
                    default:
                    Console.WriteLine("Opcion {0} no reconocida", opcion); break;
                }
            } while(opcion != '5');
        }
    }
}
