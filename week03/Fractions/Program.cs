using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction();

        Fraction f2 = new Fraction(5);

        Fraction f3 = new Fraction(3, 4);

        Fraction f4 = new Fraction(1, 3);

        f.GetFraction();
        Console.WriteLine(f.GetDecimalValue());

        f2.GetFraction();
        Console.WriteLine(f2.GetDecimalValue());

        f3.GetFraction();
        Console.WriteLine(f3.GetDecimalValue());

        f4.GetFraction();
        Console.WriteLine(f4.GetDecimalValue());

    }
}