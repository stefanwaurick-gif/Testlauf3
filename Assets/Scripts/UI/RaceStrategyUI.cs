using UnityEngine;
using System.Collections.Generic;

// Manages the Race Strategy planning UI.
public class RaceStrategyUI : MonoBehaviour
{
    [Header("Timeline Settings")]
    [SerializeField] private GameObject lapMarkerPrefab;
    [SerializeField] private Transform timelineParent;
    [SerializeField] private int totalLaps = 50; // Example total laps

    // Data structure to hold the planned strategy.
    // Key: Lap number, Value: Tire compound to switch to.
    public Dictionary<int, TireCompound> plannedStops = new Dictionary<int, TireCompound>();

    void Start()
    {
        GenerateTimeline();
        // Add a default starting stint
        plannedStops.Add(0, TireCompound.Soft);
        UpdateStrategyDisplay();
    }

    // Creates the lap markers for the timeline.
    private void GenerateTimeline()
    {
        for (int i = 1; i <= totalLaps; i++)
        {
            GameObject markerInstance = Instantiate(lapMarkerPrefab, timelineParent);
            LapMarkerUI lapMarker = markerInstance.GetComponent<LapMarkerUI>();
            if (lapMarker != null)
            {
                lapMarker.Setup(this, i);
            }
        }
    }

    // This method is called by LapMarkerUI when a stop is added or removed.
    public void UpdatePitStop(int lapNumber, bool isStopping, TireCompound compound)
    {
        if (isStopping)
        {
            if (!plannedStops.ContainsKey(lapNumber))
            {
                plannedStops.Add(lapNumber, compound);
            }
            else
            {
                plannedStops[lapNumber] = compound;
            }
        }
        else
        {
            if (plannedStops.ContainsKey(lapNumber))
            {
                plannedStops.Remove(lapNumber);
            }
        }
        UpdateStrategyDisplay();
    }

    // A method to update some text display of the current strategy.
    private void UpdateStrategyDisplay()
    {
        // This is a placeholder for where you might display the full strategy.
        string strategyText = "Current Strategy:\n";
        // Order the stops by lap number
        List<int> sortedLaps = new List<int>(plannedStops.Keys);
        sortedLaps.Sort();

        foreach (int lap in sortedLaps)
        {
            strategyText += $"Lap {lap}: Pit for {plannedStops[lap]}\n";
        }
        Debug.Log(strategyText);
    }
}
