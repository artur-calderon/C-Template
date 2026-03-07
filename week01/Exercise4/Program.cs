using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        int stop = 10;
        int number = 0;
        int total = 0;
        double average = 0;
        int max = 0;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (stop != 0)
        {
            Console.WriteLine("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break;
            }

            numbers.Add(number);

        }

        int lowerPositive = int.MaxValue;

        foreach (int num in numbers)
        {
            total += num;
            if (num > 0 && num < lowerPositive)
            {
                lowerPositive = num;
            }

            if (max < num)
            {
                max = num;
            }
        }

        average = (double)total / numbers.Count;

        numbers.Sort();

        Console.WriteLine($"The sum is {total}");
        Console.WriteLine($"The Average is {average}");
        Console.WriteLine($"The largest number is {max}");
        Console.WriteLine($"The smallest positive number is {lowerPositive}");

        Console.WriteLine($"The Sorted List is: ");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}