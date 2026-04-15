using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running run = new Running(new DateTime(2022, 11, 03), 30, 3.0);
        StationaryBicycle bike = new StationaryBicycle(new DateTime(2022, 11, 03), 30, 12.0);
        Swimming swim = new Swimming(new DateTime(2022, 11, 03), 30, 32);

        activities.Add(run);
        activities.Add(bike);
        activities.Add(swim);

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}