using System.Collections.Generic;

namespace U0_Intro
{
    class Calculatron
    {
        public float Suma(float a, float b)
        {
            return a + b;
        }

        public float Suma(List<float> valores)
        {
            float suma = 0;
            foreach (var item in valores)
            {
                suma += item;
            }

            return suma;
        }

        public float Multiplica(float a, float b)
        {
            return a * b;
        }

        public float Multiplica(List<float> valores)
        {
            float prod = 1;
            foreach (var item in valores)
            {
                prod *= item;
            }

            return prod;
        }
    }
}