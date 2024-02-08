using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Rectangle
    {
        double A;
        double B;
        public Rectangle(double a, double b)
        {
            A = a; 
            B = b;   
        }

        public static Rectangle SumRectangles(Rectangle r1, Rectangle r2)
        {
            Rectangle r3 = new Rectangle(r1.A + r2.A, r1.B + r2.B);
            return r3;
        }

        public double GetPerimeter()
        {
            double perimetr = (A + B)*2;
            return perimetr;
        }
        public double GetSquare()
        {
            double square = A * B;
            return square;
        }

        public bool IsSquare()
        {
            return (A == B);
        }

        public override string ToString()
        {
            return $"A = {A} B = {B}";
        }


    }


}
