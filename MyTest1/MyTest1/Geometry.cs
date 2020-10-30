using System;
using System.Collections.Generic;
using System.Text;

namespace MyTest1
{
    class Geometry
    {
        public static double GetVector2DLength(double vx, double vy)
        {
            double aux = vx * vx + vy * vy;
            return System.Math.Sqrt(aux);
        }
        public static double CalculateDistance2D(double x1, double y1, double x2, double y2)
        {
            double vx = x2 - x1;
            double vy = y2 - y1;
            return GetVector2DLength(vx, vy);
        }
        public static double GetVector3DLength(double vx, double vy, double vz)
        {
            double aux = vx * vx + vy * vy + vz * vz;
            return System.Math.Sqrt(aux);
        }
        public static double GetCircleArea(double r)
        {
            double aux = r * r;
            return System.Math.PI * aux;
        }
        public static double GetSphereVolume(double r)
        {
            double aux = r * r * r;
            return System.Math.PI * aux * 4 / 3;
        }
        public static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}
