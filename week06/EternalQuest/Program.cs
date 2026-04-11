using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Criar formas simples no estilo iniciante
        Square s = new Square("Red", 3.0);
        Rectangle r = new Rectangle("Blue", 4.0, 2.5);
        Circle c = new Circle("Green", 2.0);

        // Teste individual
        Console.WriteLine("Square: color=" + s.GetColor() + ", area=" + s.GetArea());
        Console.WriteLine("Rectangle: color=" + r.GetColor() + ", area=" + r.GetArea());
        Console.WriteLine("Circle: color=" + c.GetColor() + ", area=" + c.GetArea());

        // Lista de shapes
        List<Shape> shapes = new List<Shape>();
        shapes.Add(s);
        shapes.Add(r);
        shapes.Add(c);

        Console.WriteLine();
        Console.WriteLine("Looping through the list of shapes:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine("Color: " + shape.GetColor() + ", Area: " + shape.GetArea());
        }
    }
}