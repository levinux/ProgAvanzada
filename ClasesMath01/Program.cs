using System;

namespace ClasesMath01
{
    class Program
    {
        static void Main(string[] args)
        {
            Simple uno = new Simple(9);
            Simple dos = new Simple();
            Console.WriteLine("El valor de la variable 'uno' es {0}", uno.value());
            Console.WriteLine("El valor de la variable 'dos' es {0}", dos.value());
            dos.sumale(new Simple(10));
            dos.sumale(uno);
            Console.WriteLine("El valor de la variable 'dos' es {0}", dos.value());
            Console.WriteLine("Dame un numero: ");
            Simple unNumero = new Simple(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Dame otro numero: ");
            Simple otroNumero = new Simple(Convert.ToInt32(Console.ReadLine()));
            unNumero.multiplicale(otroNumero);
            Console.WriteLine("El resultado de la multiplicacion es {0}", unNumero.value());
        }
    }
}
