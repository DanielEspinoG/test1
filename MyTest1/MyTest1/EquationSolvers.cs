using System;
using System.Collections.Generic;
using System.Text;

namespace MyTest1
{
    class EquationSolvers
    {
        public static double SolveEquation2(double a, double b, double c)
        {
            double aux1, aux2, x;
            aux1 = b * b - 4.0 * a * c;
            aux2 = System.Math.Sqrt(aux1);
            x = (-b + aux1) / (2.0 * a);
            return x;
        }
        public static double SolveEquation1(double a, double b)
        {
            return -b / a;
        }
    }
}
