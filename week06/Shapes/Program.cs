using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Criar algumas formas simples (do jeito de um iniciante)
        Square s = new Square("Red", 3.0);
        Rectangle r = new Rectangle("Blue", 4.0, 2.5);
        Circle c = new Circle("Green", 2.0);

        // Testando GetColor() e GetArea() individualmente
        Console.WriteLine("Square: color=" + s.GetColor() + ", area=" + s.GetArea());
        Console.WriteLine("Rectangle: color=" + r.GetColor() + ", area=" + r.GetArea());
        Console.WriteLine("Circle: color=" + c.GetColor() + ", area=" + c.GetArea());

        // Colocar todas as formas em uma lista de Shape
        List<Shape> shapes = new List<Shape>();
        shapes.Add(s);
        shapes.Add(r);
        shapes.Add(c);

        Console.WriteLine();
        Console.WriteLine("Percorrendo a lista de formas:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine("Color: " + shape.GetColor() + ", Area: " + shape.GetArea());
        }
    }
}