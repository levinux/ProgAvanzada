using System;
using System.IO;

namespace U2_ArchivoTxt
{
    class Program
    {
        static void Main(string[] args)
        {
            string archivo = "mocos.txt";
            //
            using(StreamWriter kk = File.CreateText(archivo)) {
                kk.WriteLine("come caca");
                kk.WriteLine("moco seco");
                kk.WriteLine("hasta aqui llego el archivo");
            }
            
            Console.WriteLine("Fin");
        }
    }
}
