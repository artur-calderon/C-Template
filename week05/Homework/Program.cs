using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment mathAssignment = new Assignment("Artur", "Multiplication");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine();

        MathAssignment artur = new MathAssignment("7.3", "8-19", "Jaqueline", "Fractions");
        Console.WriteLine(artur.GetSummary());
        Console.WriteLine(artur.GetHomeworkList());
        Console.WriteLine();

        WriteAssignment livia = new WriteAssignment("The Causes of World War II", "Lívia", "Europear History");
        Console.WriteLine(livia.GetSummary());
        Console.WriteLine(livia.GetWritingInformation());
    }
}