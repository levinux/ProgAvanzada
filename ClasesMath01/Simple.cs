using System;

// Numeros del 0-255

namespace ClasesMath01
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
    }
}