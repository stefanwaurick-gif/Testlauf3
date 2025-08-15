using System;

[System.Serializable]
public class GameEvent
{
    public DateTime EventDate;
    public string Description;

    public GameEvent(DateTime date, string description)
    {
        EventDate = date;
        Description = description;
    }
}
