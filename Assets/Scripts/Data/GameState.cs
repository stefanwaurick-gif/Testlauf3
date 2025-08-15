using System.Collections.Generic;

[System.Serializable]
public class HistoricalData
{
    public int Year;
    public string TeamName;
    public string DriverName;
    public int Position;

    public HistoricalData(int year, string team, string driver, int pos)
    {
        Year = year;
        TeamName = team;
        DriverName = driver;
        Position = pos;
    }
}

[System.Serializable]
public class GameState
{
    public string TeamName;
    public float Budget;
    public List<HistoricalData> CareerHistory;

    // Constructor to create dummy data for testing
    public GameState(bool populateWithTestData)
    {
        TeamName = "My Racing Team";
        Budget = 1000000f;
        CareerHistory = new List<HistoricalData>();

        if (populateWithTestData)
        {
            for (int i = 0; i < 5000; i++)
            {
                CareerHistory.Add(new HistoricalData(2026 + (i % 20), $"Team_{i % 10}", $"Driver_{i % 50}", (i % 20) + 1));
            }
        }
    }
}
