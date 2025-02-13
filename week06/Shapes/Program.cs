using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square g1 = new Square("Black", 6);
        shapes.Add(g1);

        Rectangle g2 = new Rectangle("Yellow", 5, 7);
        shapes.Add(g2);

        Circle g3 = new Circle("Purple", 3);
        shapes.Add(g3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The shape is {color} with an area of {area}");
        }
    }
}