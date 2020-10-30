using System;
using System.Collections.Generic;
using System.Text;

namespace MyTest1
{
    class EjerciciosExamen
    {
        //Hacer una función, que reciba 2 número enteros y devuelva la suma de los 2
        public static int ExEjercicio1(int x, int y)
        {
            int result;
            result = x + y;
            return result;
        }

        //lo mismo que Ej1 con resta y reales
        public static double ExEjercicio2(double x, double y)
        {
            return x - y;
        }

        //Hacer 2 funciones con reales, una devuelve el mayor y la otra la menor
        public static double ExEjercicio3(double x, double y)
        {
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
        public static double ExEjercicio4(double x, double y)
        {
            if (x > y)
            {
                return y;
            }
            else
            {
                return x;
            }

        }
    }
}

