using System;

// Numeros del 0-255

namespace ClasesMath02
{
    public class Simple
    {
        private int valor;

        public Simple()
        {
            valor = 0;
        }

        public Simple(int n)
        {
            if(n < 0 || n > 255)
            {
                valor = 0;
            }
            else
            {
                valor = n;
            }
        }

        public int value()
        {
            return valor;
        }

        public void sumale(Simple otro)
        {
            valor = valor + otro.value();
        }

        public void restale(Simple otro)
        {
            valor = valor - otro.value();
        }

        public void multiplicale(Simple otro)
        {
            valor = valor * otro.value();
        }

        public void divideEntre(Simple otro)
        {
            valor = valor / otro.value();
        }

        public static Simple operator +(Simple a, Simple b)
        {
            Simple x = new Simple(a.value());
            x.sumale(b);
            return x;
        }

        public static Simple operator *(Simple a, Simple b)
        {
            Simple x = new Simple(a.value());
            x.multiplicale(b);
            return x;
        }
    }

    class Entero : Simple {
        private int valor = 0;
        public Entero(int n)
        {
            if(n < 0 || n > (int) Math.Pow(2, 32) - 1)
            {
                valor = 0;
            }
            else
            {
                valor = n;
            }
        }

        public int value()
        {
            return valor;
        }
        /*public static Entero operator *(Entero a, Entero b)
        {
            // aosidfpaoisdjfpoasjdpofjaposjfaposjdfa
        }*/

        public static Entero operator *(Entero a, Simple b)
        {
            Console.WriteLine("a vale = {0} y b vale = {1}", a.value(), b.value());
            int x = a.value() * b.value();
            return new Entero(x);
        }

        /*public static Entero operator *(Simple a, Entero b)
        {
            // aosidfpaoisdjfpoasjdpofjaposjfaposjdfa
        }

        public static Entero operator *(Simple a, Simple b)
        {
            // aosidfpaoisdjfpoasjdpofjaposjfaposjdfa
        }*/
    }
    class NumGrande : Simple {}
}