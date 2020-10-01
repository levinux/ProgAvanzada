using System;

namespace U1_Interfaces
{
    /*static class Mates : Math
    {
        //
    }*/

    public class Perro
    {
        public int edad;
        public string nombre;
        private string tipo_cola = "";

        public void guau()
        {
            Console.WriteLine("Guau guau");
        }
    }

    public class Labrador : Perro, Lenguaje
    {
        // Caracteristica nueva y/o unica
        public string color = "";

        // Sobreescritura de metodos
        public void guau()
        {
            Console.WriteLine("Ggrrrr guau guau guau");
        }

        public string habla() {
            return "guau guau";
        }
    }

    sealed class Shitzu : Perro
    {
        //
    }

    class Shitzu_americano : Labrador
    {
        //
    }

    public interface Lenguaje
    {
        public string habla();
    }
}