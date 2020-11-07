using System;
using System.IO;

namespace PetitDB
{
    class Program
    {
        static string archivo = "registros.db";

        static void Main(string[] args)
        {
            Check4database();
            int opcion = 0;
            
            do
            {
                opcion = menu();
                switch(opcion)
                {
                    case 1:
                        AgregarRegistro();
                        break;
                    case 2:
                    case 3:
                    case 4:
                        EliminarRegistro();
                        break;
                    case 5:
                        Console.WriteLine("bye bye!");
                        break;
                }
            } while (opcion != 5);
        }

        static void Check4database()
        {
            bool existe = File.Exists(archivo);
            if(!existe)
            {
                File.CreateText(archivo);
                Console.WriteLine(archivo + " creado!");
            }
        }

        static int menu() {
            Console.Clear();
            // CRUD
            Console.WriteLine("1. Insertar registro");   // Create - check
            Console.WriteLine("2. Mostrar todos");       // Read
            Console.WriteLine("3. Actualizar registro"); // Update
            Console.WriteLine("4. Eliminar registro");   // Delete
            Console.WriteLine("5. Salir");
            Console.WriteLine("\t\t\tOpcion [...]\b\b\b");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void AgregarRegistro()
        {
            string nocontrol = "";
            string nombre = "";
            string carrera = "";
            int edad = 0;

            Console.WriteLine("Dame el numero de control: ");
            nocontrol = Console.ReadLine();
            Console.WriteLine("Dame el nombre del alumne: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Dame la carrera del change: ");
            carrera = Console.ReadLine();
            Console.WriteLine("Dame la edad de individue: ");
            edad = Convert.ToInt32(Console.ReadLine());

            using(StreamWriter salida = File.AppendText(archivo)) {
                salida.WriteLine("{0},{1},{2},{3}", nocontrol, nombre, carrera, edad);
            }
        }

        static void EliminarRegistro()
        {
            string nocontrol;
            bool huboNuevoArchivo = false;
            Console.WriteLine("Que # de control quieres eliminar? ");
            nocontrol = Console.ReadLine();

            using(StreamReader entrada = File.OpenText(archivo)) {
                string linea = "";
                while((linea = entrada.ReadLine()) != null) //EOF
                {
                    string[] campos = linea.Split(',', 4, StringSplitOptions.None);
                
                    if(nocontrol != campos[0])
                    {
                        huboNuevoArchivo = true;
                        using(StreamWriter temp = File.AppendText("temporal.tmp")) {
                            temp.WriteLine(linea);
                        }
                    }
                }
            }

            if(huboNuevoArchivo)
            {
                // Eliminar registro.db
                // Renombrar temporal.tmp ==> registro.db
                // Todos felices
                File.Delete(archivo);
                File.Move("temporal.tmp", archivo);
            }
        }
    }
}
