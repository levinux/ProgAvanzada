using System;

namespace U1_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro p = new Perro();
            p.edad = 4;
            p.nombre = "Fido";
            p.guau();
            //p.tipo_cola = "paradita";
            //p.color = "Blanco con cafecito";

            Labrador l = new Labrador();
            l.edad = 5;
            l.nombre = "Lazie";
            l.guau();
            l.color = "Negro";

            Console.WriteLine("El perro {0} tiene {1} anios de edad de color {2}", l.nombre, l.edad, l.color);
        }
    }

    class Perro
    {
        public int edad;
        public string nombre;
        private string tipo_cola = "";

        public void guau()
        {
            Console.WriteLine("Guau guau");
        }
    }

    class Labrador : Perro
    {
        // Caracteristica nueva y/o unica
        public string color = "";

        // Sobreescritura de metodos
        public void guau()
        {
            Console.WriteLine("Ggrrrr guau guau guau");
        }
    }
}
