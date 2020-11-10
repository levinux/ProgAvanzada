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
                        ModificarRegistro();
                        break;
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

        static void ModificarRegistro()
        {
            string nocontrol;
            string new_nc;
            string new_nombre;
            string new_carrera;
            string new_edad;
            string new_linea;
            Console.WriteLine("Que # de control quieres modificar? ");
            nocontrol = Console.ReadLine();

            using(StreamReader entrada = File.OpenText(archivo)) {
                string linea = "";
                while((linea = entrada.ReadLine()) != null) //EOF
                {
                    string[] campos = linea.Split(',', 4, StringSplitOptions.None);
                
                    if(nocontrol == campos[0])
                    {
                        Console.WriteLine("({0}), Nuevo num. Control: ", campos[0]);
                        new_nc = Console.ReadLine();
                        Console.WriteLine("({0}), Nuevo nombre: ", campos[1]);
                        new_nombre = Console.ReadLine();
                        Console.WriteLine("({0}), Nueva carrera: ", campos[2]);
                        new_carrera = Console.ReadLine();
                        Console.WriteLine("({0}), Nueva edad: ", campos[3]);
                        new_edad = Console.ReadLine();
                        new_linea = new_nc + "," + new_nombre + "," + new_carrera + "," + new_edad;
                    }
                    else
                    {
                        new_linea = linea;
                    }

                    using(StreamWriter temp = File.AppendText("temporal.tmp")) {
                        temp.WriteLine(new_linea);
                    }
                }
            }

            // Eliminar registro.db
            // Renombrar temporal.tmp ==> registro.db
            // Todos felices
            File.Delete(archivo);
            File.Move("temporal.tmp", archivo);
        }
    }
}
