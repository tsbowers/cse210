public class Goal
{
    public string Name;
    public string Description;
    public int Points;

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public virtual int RecordEvent()
    {
        return 0;
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDisplay()
    {
        return "[ ] " + Name;
    }

    public virtual string SaveData()
    {
        return "";
    }
}