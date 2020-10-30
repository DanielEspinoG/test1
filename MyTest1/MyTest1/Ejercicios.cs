using System;
using System.Collections.Generic;
using System.Text;

namespace MyTest1
{
    class Ejercicios
    {
        // Ejercicio: Hacer una función que imprima por pantalla
        // los números del 0 al 99
        public static void Ejercicio1()
        {
            int contador = 0;
            while (contador < 100)
            {
                System.Console.WriteLine(contador);
                // contador = contador + 1;
                // son lo mismo
                contador++;
            }
        }
        // Ejercicio: Haz una función que imprima por pantalla todos los números pares desde el 0 hasta n
        public static void Ejercicio2(int n)
        {   // se suele utilizar en vucles i, j o k
            int i = 0;
            while (i < n)
            {
                if (Utils.IsEven(i))
                    System.Console.WriteLine(i);
                i++;
            }
        }
        // Hacer una función que diga si es número primo o no
        public static void Ejercicio3(int numero)
        {
            bool es_primo = Utils.IsPrime(numero);


            if (es_primo)
                System.Console.WriteLine("este numero" + numero + "es primo");
            else
                System.Console.WriteLine("este numero" + numero + "NO es primo");
        }
        public static void EjercicioSerie1()
        {
            int i = 0;
            while (i < 100)
            {
                System.Console.WriteLine(i);
                i++;
            }
        }
        public static void EjercicioSerie2()
        {
            int i = 0;
            while (i < 100)
            {
                System.Console.WriteLine(i * 2);

                i++;
            }
        }
        public static void EjercicioSerie3()
        {
            int i = 0;
            while (i < 100)
            {
                System.Console.WriteLine(i * 3 + 1);

                i++;
            }
        }
        public static void EjercicioSerie4()
        {
            int i = 0;
            while (i < 100)
            {
                System.Console.WriteLine(i * i);

                i++;
            }
        }
        //0 -1 2 -3 4 -5 6 ...
        public static void EjercicioSerie5()
        {
            int i = 0;
            while (i < 100)
            {
                if (Utils.IsEven(i))

                    System.Console.WriteLine(i);
                else
                    System.Console.WriteLine(-i);

                i++;
            }
        }
        //0,1,1,2,3,5,8,13,21,34 da la suma de los 2 numeros anteriores menos los 2 primeros (0,1)
        public static void EjerciciosSerie6()
        {
            int i = 0;
            int a = 1;
            int aa = 0;
            System.Console.WriteLine(aa);
            System.Console.WriteLine(a);

            while (i < 100)
            {
                System.Console.WriteLine(a + aa);
                int aux = aa;
                aa = a;
                a = aux + aa;

                i++;

            }

        }
        //hacer una función que imprima todos los caracteres ascii
        public static void ImprimirAscii()
        {
            for (int i = 33; i <= 255; i++)
            {
                System.Console.Write(i);
                System.Console.Write(") es el caracter [");
                //convierte i a caracter ((a lo que quiero convertir)i)
                System.Console.Write((char)i);
                System.Console.WriteLine("]");

            }
        }
    }
}
