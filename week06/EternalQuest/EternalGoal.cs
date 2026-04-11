public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return Points;
    }

    public override string GetDisplay()
    {
        return "[∞] " + Name;
    }

    public override string SaveData()
    {
        return $"Eternal|{Name}|{Description}|{Points}";
    }
}