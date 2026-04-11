using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    public List<Goal> Goals = new List<Goal>();
    public int Score = 0;

    public void AddGoal(Goal g)
    {
        Goals.Add(g);
    }

    public void ShowGoals()
    {
        for (int i = 0; i < Goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Goals[i].GetDisplay()}");
        }
    }

    public void RecordGoal(int index)
    {
        if (index >= 0 && index < Goals.Count)
        {
            Score += Goals[index].RecordEvent();
        }
    }

    public void ShowScore()
    {
        Console.WriteLine("Score: " + Score);
    }

    public void Save(string file)
    {
        using StreamWriter writer = new StreamWriter(file);

        writer.WriteLine(Score);

        foreach (Goal g in Goals)
        {
            writer.WriteLine(g.SaveData());
        }
    }

    public void Load(string file)
    {
        string[] lines = File.ReadAllLines(file);

        Score = int.Parse(lines[0]);
        Goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            if (parts[0] == "Simple")
            {
                Goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]))
                {
                    Completed = bool.Parse(parts[4])
                });
            }
            else if (parts[0] == "Eternal")
            {
                Goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (parts[0] == "Checklist")
            {
                Goals.Add(new ChecklistGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    int.Parse(parts[4]))
                {
                    Current = int.Parse(parts[5])
                });
            }
        }
    }
}