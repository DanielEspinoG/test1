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

        //Hacer una función que se le pasen 3 enteros y que devuelva el mayor de los 3
        public static int ExEjercicio5(int a, int b, int c)
        {
            /*
            //Es la formula que hice yo
            if (a > b && a > c )
            {
                return a;
            }
            else if(a < b && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
            */

            // es la forma optima de hacerlo
            if (a > b)
            {
                if (a > c)
                    return a;
                else
                    return c;
            }
            else
            {
                if (b > c)
                    return b;
                else
                    return c;
            }
        }
             
        //Hacer una función que reciba 2 enteros y devuelva -1 si el primero es menor que el segundo,
        // 1 si el segundo es menor que el primero y 0 si son iguales
        public static int ExEjercicio6 (int a, int b)
        {
            if (a < b)
                return -1;
            else if (a > b)
                return 1;
            else
                return 0;
        }

        //hacer una función que reciba un codigo de error y muestre por pantalla lo siguiente "error grave" si el error es 0,
        //"error moderado" si es 1, "error leve" si es 2, "error desconocido" en cualquier otro caso
        public static void ExEjercicio7 (int code)
        {
            switch (code)
            {
                case 0:
                    System.Console.WriteLine ("Error grave");
                    break;
                case 1:
                    System.Console.WriteLine ("Error moderado");
                    break;
                case 2:
                    System.Console.WriteLine ("Error leve");
                    break;
                default:
                    System.Console.WriteLine ("Error desconocido");
                    break;
            }
        }

        //Hacer una función que reciba un número y es función de ese número imprima la siguiente serie:
        //función(10) => 0,3,6,9,    función(0) => 0,   función(12) => 0,3,6,9,12,
        public static void ExEjercicio8 (int x)
        {
            int i = 0;
            while (i < x)
            {
                System.Console.Write (i + ",");

                i+=3;
            }
            System.Console.WriteLine ("");
        }

        //Hacer una función que reciba un número entero e imprima todos los números desde el 0 hasta ese número (usar for)
        public static void ExEjercicio9 (int x)
        {
            int i = 0;

            while (i <= x)
            {
                System.Console.Write (i + ",");

                i++;
            }
        }
    }
}

