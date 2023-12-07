using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Shape
    {
        protected double X;
        protected double Y;
        protected double Height;
        protected double Width;

        public Shape(double x, double y, double height, double width)
        {
            X = x;
            Y = y;
            Height = height;
            Width = width;
        }

        public virtual void Draw()
        {
            Console.WriteLine($"Narysowałeś figurę: Shape");
        }
    }
}
