namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zadanie1();
            Zadanie2();
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
            Uczen u1 = new Uczen();  
            Uczen u2 = new Uczen();
            u1.SetPesel("07271578913");
            u2.SetPesel("15251203916");
            u1.SetCanGoHomeAlone();
            u2.SetCanGoHomeAlone();
            Nauczyciel n1 = new Nauczyciel();
            n1.AssignStudent(u1);
            n1.AssignStudent(u2);
            n1.WhichStudentCanGoHomeAlone();
            
        }
    }
}