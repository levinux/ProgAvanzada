using System;
using System.IO;

namespace U2_CargarRegistro
{
    class Program
    {
        static void Main(string[] args)
        {
            //string registro = "../U2_RegistroBasico/registro.csv";
            string registro = "Program.cs";
            bool existe = File.Exists(registro);

            if(existe) {
                // Leerlo
                using(StreamReader contenido = File.OpenText(registro)) {
                    string linea = "";
                    while( (linea = contenido.ReadLine()) != null ) {
                        Console.WriteLine("Linea de texto: {0}", linea);
                    }
                }
            } else {
                Console.WriteLine("El archivo {0} no existe", registro);
            }
        }
    }
}
