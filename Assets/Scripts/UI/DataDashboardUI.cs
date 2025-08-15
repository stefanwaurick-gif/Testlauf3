using UnityEngine;

// Main controller for the in-race Data Dashboard.
// This script will hold references to the major components of the dashboard.
public class DataDashboardUI : MonoBehaviour
{
    [Header("Dashboard Components")]
    [SerializeField] private TimingTableUI timingTable;
    [SerializeField] private PlayerStatsUI playerStats;

    void Start()
    {
        // In a real implementation, this class would receive data updates from a
        // RaceManager and pass them down to the appropriate UI components.
        // For this prototype, the components will manage their own test data.
        Debug.Log("DataDashboardUI started. Child components should handle their own test data.");

        if (timingTable == null || playerStats == null)
        {
            Debug.LogError("DataDashboardUI is missing references to its child components (TimingTableUI or PlayerStatsUI)!");
        }
    }

    // Example of a method that would be called by a RaceManager
    public void UpdateDashboard(object raceData)
    {
        // timingTable.UpdateTable(raceData.TimingData);
        // playerStats.UpdateStats(raceData.PlayerCarData);
    }
}
