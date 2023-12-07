using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Triangle : Shape
    {
        public Triangle(double x, double y, double height, double width) : base(x, y, height, width)
        {
            this.Width = width;
            this.Height = height;
            this.X = x;
            this.Y = y;
        }
        public override void Draw()
        {
            Console.WriteLine("Narysowałeś figurę: Trójkąt");
        }
    }
}
