public class ChecklistGoal : Goal
{
    public int Target;
    public int Current;
    public int Bonus;

    public ChecklistGoal(string name, string description, int points, int target)
        : base(name, description, points)
    {
        Target = target;
        Current = 0;
        Bonus = points * 5;
    }

    public override int RecordEvent()
    {
        if (Current < Target)
        {
            Current++;

            if (Current == Target)
                return Points + Bonus;

            return Points;
        }

        return 0;
    }

    public override bool IsComplete()
    {
        return Current >= Target;
    }

    public override string GetDisplay()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {Name} ({Current}/{Target})";
    }

    public override string SaveData()
    {
        return $"Checklist|{Name}|{Description}|{Points}|{Target}|{Current}";
    }
}