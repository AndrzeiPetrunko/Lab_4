namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zadanie1();
        }
        static void Zadanie1()
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Shape(1, 2, 3, 4));
            shapes.Add(new Rectangle(12, 12, 12, 12));
            shapes.Add(new Triangle(13, 14, 15, 15));
            shapes.Add(new Circle(11, 10, 9, 8));
            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }
        }
        static void Zadanie2()
        {

        }
    }
}