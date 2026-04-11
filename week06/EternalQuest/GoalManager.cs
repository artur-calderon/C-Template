using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void AddGoal(Goal g)
    {
        _goals.Add(g);
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine("\nYou have " + _score + " points.\n");
    }

    public void ListGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + _goals[i].GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("What type of goal? (1) Simple (2) Eternal (3) Checklist");
        string type = Console.ReadLine();
        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter description:");
        string desc = Console.ReadLine();
        Console.WriteLine("Enter points for this goal:");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            AddGoal(new SimpleGoal(name, desc, points));
        }
        else if (type == "2")
        {
            AddGoal(new EternalGoal(name, desc, points));
        }
        else if (type == "3")
        {
            Console.WriteLine("Enter how many times to complete this goal:");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter bonus points when target reached:");
            int bonus = int.Parse(Console.ReadLine());
            AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Unknown type, cancelling.");
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record.");
            return;
        }
        Console.WriteLine("Select a goal to record:");
        ListGoals();
        int choice = int.Parse(Console.ReadLine());
        if (choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }
        Goal g = _goals[choice - 1];
        int earned = g.RecordEvent();
        if (earned > 0)
        {
            _score += earned;
            Console.WriteLine("Thank you! You received " + earned + " points.");
        }
        else
        {
            Console.WriteLine("No points awarded (goal may already be complete).");
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                writer.WriteLine(g.GetStringRepresentation());
            }
        }
        Console.WriteLine("Saved goals to " + filename);
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found: " + filename);
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        if (lines.Length == 0)
        {
            Console.WriteLine("File empty.");
            return;
        }

        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split('|');
            if (parts[0] == "SimpleGoal")
            {
                string name = parts[1];
                string desc = parts[2];
                int points = int.Parse(parts[3]);
                bool complete = bool.Parse(parts[4]);
                SimpleGoal sg = new SimpleGoal(name, desc, points);
                if (complete)
                {
                    // record without awarding points
                    sg.RecordEvent();
                }
                AddGoal(sg);
            }
            else if (parts[0] == "EternalGoal")
            {
                string name = parts[1];
                string desc = parts[2];
                int points = int.Parse(parts[3]);
                AddGoal(new EternalGoal(name, desc, points));
            }
            else if (parts[0] == "ChecklistGoal")
            {
                string name = parts[1];
                string desc = parts[2];
                int points = int.Parse(parts[3]);
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                int amount = int.Parse(parts[6]);
                ChecklistGoal cg = new ChecklistGoal(name, desc, points, target, bonus);
                for (int k = 0; k < amount; k++)
                {
                    // record without awarding to score
                    cg.RecordEvent();
                }
                AddGoal(cg);
            }
        }
        Console.WriteLine("Loaded goals from " + filename);
    }
}
