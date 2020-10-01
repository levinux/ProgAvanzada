using System;

namespace ClasesMath02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Simple uno = new Simple(9);
            Simple dos = new Simple(5);
            Console.WriteLine("El valor de la variable 'uno' es {0}", uno.value());
            Console.WriteLine("El valor de la variable 'dos' es {0}", dos.value());
            dos = dos + new Simple(10);*/
            //Console.WriteLine("Aqui --> El valor de la variable 'dos' es {0}", dos.value());
            Console.WriteLine("Dame un numero: ");
            Simple unNumero = new Simple(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Dame otro numero: ");
            Simple otroNumero = new Simple(Convert.ToInt32(Console.ReadLine()));
            Simple m = unNumero * otroNumero;
            Console.WriteLine("El resultado de la multiplicacion es {0}", m.value());
        }
    }
}
