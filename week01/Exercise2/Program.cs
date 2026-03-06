using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the grade? ");
        int userGrade = int.Parse(Console.ReadLine());
        string grade = "";
        string signal = "";

        if (userGrade >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else if (userGrade < 70)
        {
            Console.WriteLine("Don't Worry! Keep going!!");
        }

        if (userGrade >= 90)
        {
            grade = "A";
        }
        else if (userGrade >= 80)
        {
            grade = "B";
        }
        else if (userGrade >= 70)
        {
            grade = "C";

        }
        else if (userGrade >= 60)
        {
            grade = "D";
        }
        else if (userGrade < 60)
        {
            grade = "F";
        }

        if (userGrade % 10 >= 7)
        {
            if (grade == "A" || grade == "F")
            {
                signal = "";
            }
            else
            {
                signal = "+";
            }
        }
        else if (userGrade % 10 <= 3)
        {
            if (grade == "A" || grade == "F")
            {
                signal = "";
            }
            else
            {
                signal = "-";
            }
        }
        else
        {
            return;
        }

        Console.WriteLine($"Your grade is {grade}{signal}");

    }
}