public class SimpleGoal : Goal
{
    public bool Completed;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        Completed = false;
    }

    public override int RecordEvent()
    {
        if (!Completed)
        {
            Completed = true;
            return Points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return Completed;
    }

    public override string GetDisplay()
    {
        return Completed ? "[X] " + Name : "[ ] " + Name;
    }

    public override string SaveData()
    {
        return $"Simple|{Name}|{Description}|{Points}|{Completed}";
    }
}