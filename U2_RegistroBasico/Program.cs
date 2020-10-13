using System;
using System.IO;

namespace U2_RegistroBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre="";
            string identif="";
            string registro = "registro.csv";
            bool existe = File.Exists(registro);

            Console.WriteLine("Cual es tu ID: ");
            identif = Console.ReadLine();
            Console.WriteLine("Cual es tu nombre?: ");
            nombre = Console.ReadLine();

            if(existe) {
                Agrega(nombre, identif, registro);
            } else {
                Crea(nombre, identif, registro);
            }

            Console.WriteLine("archivo creado");
        }

        public static void Crea(string nombre, string id, string registro) {
            using(StreamWriter salida = File.CreateText(registro)) {
                salida.WriteLine("{0},{1}", id, nombre);
            }
        }

        public static void Agrega(string nombre, string id, string registro) {
            using(StreamWriter salida = File.AppendText(registro)) {
                salida.WriteLine("{0},{1}", id, nombre);
            }
        }
    }
}
