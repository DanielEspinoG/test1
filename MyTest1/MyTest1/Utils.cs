using System;
using System.Collections.Generic;
using System.Text;

namespace MyTest1
{
    class Utils
    {
        public static int GetMinValue1(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public static int GetMinValue2(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public static bool IsEven(int value)
        {
            if ((value % 2) == 0)
                return true;
            else
                return false;
        }
        //funcion que nos devuelve si es primo o no
        public static bool IsPrime(int number)
        {
            int i = 2;

            while (i < number)
            {
                if ((number % i) == 0)
                    return false;
                i++;
            }
            return true;
        }

    }
}
