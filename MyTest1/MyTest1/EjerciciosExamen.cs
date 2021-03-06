﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml.Schema;

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
        public static int ExEjercicio6(int a, int b)
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
        public static void ExEjercicio7(int code)
        {
            switch (code)
            {
                case 0:
                    System.Console.WriteLine("Error grave");
                    break;
                case 1:
                    System.Console.WriteLine("Error moderado");
                    break;
                case 2:
                    System.Console.WriteLine("Error leve");
                    break;
                default:
                    System.Console.WriteLine("Error desconocido");
                    break;
            }
        }

        //Hacer una función que reciba un número y es función de ese número imprima la siguiente serie:
        //función(10) => 0,3,6,9,    función(0) => 0,   función(12) => 0,3,6,9,12,
        public static void ExEjercicio8(int x)
        {
            int i = 0;
            while (i < x)
            {
                System.Console.Write(i + ",");

                i += 3;
            }
            System.Console.WriteLine("");
        }

        //Hacer una función que reciba un número entero e imprima todos los números desde el 0 hasta ese número (usar for)
        public static void ExEjercicio9(int x)
        {
            for (int i = 0; i <= x; i++)
                System.Console.Write(i + ",");

            System.Console.WriteLine("");

        }


        //lo mismo que el anterior, pero que no termine en ,
        public static void ExEjercicio10(int x)
        {
            for (int i = 0; i < x; i++)
                System.Console.Write(i + ",");


            if (x > 0)
                System.Console.Write(x);

        }

        //una función que devuelva el mayor de 6 enteros. esta funcion debe ocupar una linea
        public static int ExEjercicio11(int a, int b, int c, int d, int e, int f)
        {
            return ExEjercicio6(ExEjercicio5(a, b, c), ExEjercicio5(d, e, f));

        }

        //Hacer una función que se le pase un entero e imprima tantos asteriscos como ese entero que se le pasa. si se cuantas veces se repite es aconsejable
        // un for, si no lo se un while.
        public static void ExEjercicio12(int x)
        {
            for (int i = 0; i < x; i++)
                System.Console.Write("*");
        }

        //Lo mismo pero en vez de imprimir * imprime lo siguiente *+*+*
        public static void ExEjercicio13(int x)
        {
            for (int i = 0; i < x; i++)
                if ((i % 2) == 0)
                    System.Console.Write("*");
                else
                    System.Console.Write("+");
        }

        //lo mismo pero tiene que imprimir lo siguiente: *+-/*+-/
        public static void ExEjercicio14(int x)
        {
            for (int i = 0; i < x; i++)
            {

                int resto = i % 4;

                switch (resto)
                {
                    case 0:
                        System.Console.Write("*");
                        break;
                    case 1:
                        System.Console.Write("+");
                        break;
                    case 2:
                        System.Console.Write("-");
                        break;
                    case 3:
                        System.Console.Write("/");
                        break;
                }
            }
        }

        //hacer una función que reciba un numero y en función de ese número que imprima lo siguiente: si le paso un 3
        //***
        //***
        //***
        public static void ExEjercicio15(int x)
        {
            //este "for" controla la fila
            for (int f = 0; f < x; f++)
            {
                //este "for" controla la columna
                for (int c = 0; c < x; c++)
                    System.Console.Write("*");

                System.Console.WriteLine("");
            }
        }

        //lo mismo que antes: 3
        //***
        //+++
        //***
        public static void ExEjercicio16(int x)
        {
            for (int f = 0; f < x; f++)
            {
                for (int c = 0; c < x; c++)
                    if ((x % 2) == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write("+");
            }
            System.Console.WriteLine("");

        }

        //lo mismo que antes: 3
        //*+*
        //+*+
        //*+*
        public static void ExEjercicio17(int x)
        {
            for (int f = 0; f < x; f++)
            {
                for (int c = 0; c < x; c++)
                {
                    int flag = c + f;
                    if ((flag % 2) == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write("+");
                }
                System.Console.WriteLine("");
            }
        }

        // x = 3
        //*
        //**
        //***
        public static void ExEjercicio18(int x)
        {
            for (int f = 0; f < x; f++)
            {
                for (int c = 0; c <= f; c++)
                {
                    System.Console.Write("*");

                }
                System.Console.WriteLine("");
            }
        }

        //x = 4
        //   *
        //  **
        // ***
        //****
        public static void ExEjercicio19(int n)
        {
            for (int f = 0; f < n; f++)
            {
                int nEspacio = n - f - 1;
                int nAsterisco = f + 1;     /*también puede ser = n - nEspacio*/

                for (int c = 0; c < nEspacio; c++)
                    System.Console.Write(" ");

                for (int c = 0; c < nAsterisco; c++)
                    System.Console.Write("*");


                System.Console.WriteLine("");
            }
        }

        //n = 5
        //    **
        //   *  *
        //  *    *
        // *      *
        //*        *
        public static void ExEjercicio20(int n)
        {
            for (int f = 0; f < n; f++)
            {
                int nEspacio1 = n - f - 1;
                int nEspacio2 = f * 2;

                for (int c = 0; c < nEspacio1; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");

                for (int c = 0; c < nEspacio2; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");

                System.Console.WriteLine("");
            }

        }

        //n = 5
        //    *
        //   * *
        //  *   *
        // *     *
        //*       *
        public static void ExEjercicio21(int n)
        {
            for (int f = 0; f < n; f++)
            {
                int nEspacio1 = n - f - 1;
                int nEspacio2 = f * 2 - 1;
                // int nEspacio = MaxValue (0, 2 * f - 1) soluciona el problema del -1 en la primera fila

                for (int c = 0; c < nEspacio1; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");

                for (int c = 0; c < nEspacio2; c++)
                    System.Console.Write(" ");

                if (f != 0)
                    System.Console.Write("*");
                else
                    System.Console.Write("");

                System.Console.WriteLine("");
            }
        }

        //n = 5
        //*        *
        // *      *
        //  *    *
        //   *  *
        //    **
        public static void ExEjercicio22(int n)
        {
            for (int f = 0; f < n; f++)
            {
                int nEspacio1 = f;
                int nEspacio2 = (n - f - 1) * 2;

                for (int c = 0; c < nEspacio1; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");

                for (int c = 0; c < nEspacio2; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");

                System.Console.WriteLine("");
            }

        }

        public static void ExEjercicio23(int n)
        {
            for (int f = 0; f < n; f++)
            {
                int nEspacio1 = f;
                int nEspacio2 = ((n - f - 1) * 2) - 1;

                for (int c = 0; c < nEspacio1; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");

                for (int c = 0; c < nEspacio2; c++)
                    System.Console.Write(" ");

                if (f + 1 != n)
                    System.Console.Write("*");
                else
                    System.Console.Write(" ");

                System.Console.WriteLine("");
            }
        }

        //n = 4
        //   *
        //  * *
        // *   *
        //*     *
        //*     *
        // *   *
        //  * *
        //   *
        public static void ExEjercicio24(int n)
        {
            ExEjercicio21 (n);
            ExEjercicio23 (n);

        }

        //hacer bandera americana
        public static void ExEjercicio25 ()
        {
            for (int f = 0; f < 20; f++)
            {

                for (int c = 0; c <= 75; c++)
                {
                    int f2 = f / 2;

                    if (0 <= c && c <= 20 && 0 <= f && f <= 9)
                    {
                        int flag = c + f;

                        if ((flag % 2) == 0)
                            System.Console.Write("+");
                        else
                            System.Console.Write(" ");
                    
                    }
                    else if ((f2 % 2) == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write(" ");

                }
                System.Console.WriteLine("");
            }

        }

        //hacer bandera japonesa * es borde bandera
        public static void ExEjercicio26()
        {
            for (int f = 0; f < 20; f++)
            {
                for (int c = 0; c < 75; c++)
                {
                    if (c == 0 || c == 74 || f == 0 || f == 19)
                        System.Console.Write("*");
                    else if (Geometry.CalculateDistance2D(37, 10, c, f) < 5.0)
                        System.Console.Write("O");
                    else
                        System.Console.Write(" ");

                }
                System.Console.WriteLine("");
            }
        }

        //hacer una funcion que devuelva el sumatorio de un número de 6 = 1+2+3+4+5+6
        public static int ExEjercicio27 (int n)
        {
            int result = 0;
            for (int i = 1; i <= n; i++)
                result += i;

            return result;
        }

        //haz una función que devuelva 2 elevado a un número
        public static int ExEjercicio28 (int n)
        {
            int result = 1;
            for (int i = 0; i < n; i++)
                result *= 2;

            return result;
        }
        //forma correcta al elevar el número negativo
        public static double ExEjercicio29(double n)
        {
            bool invert_value = n < 0;
            if (invert_value)
                n = -n;

            double result = 1;
            for (int i = 0; i < n; i++)
                result *= 2.0;
            if (invert_value)
                result = 1.0 / result;
            return result;
        }

    }
}

