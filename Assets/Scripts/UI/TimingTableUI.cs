using UnityEngine;
using System.Collections.Generic;

// Manages the timing table, which displays data for all drivers in the race.
public class TimingTableUI : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private GameObject timingRowPrefab;
    [SerializeField] private Transform contentParent;

    // Test data for a single driver's timing information
    private struct DriverTimingData
    {
        public int Position;
        public string DriverName;
        public string LapTime;
        public string Gap;
    }

    void Start()
    {
        PopulateWithTestData();
    }

    private void PopulateWithTestData()
    {
        foreach (Transform child in contentParent)
        {
            Destroy(child.gameObject);
        }

        List<DriverTimingData> testData = new List<DriverTimingData>
        {
            new DriverTimingData { Position = 1, DriverName = "HAM", LapTime = "1:21.345", Gap = "" },
            new DriverTimingData { Position = 2, DriverName = "VER", LapTime = "1:21.512", Gap = "+0.167" },
            new DriverTimingData { Position = 3, DriverName = "BOT", LapTime = "1:21.888", Gap = "+0.543" },
            // ... add more drivers as needed
        };

        foreach (var driverData in testData)
        {
            GameObject rowInstance = Instantiate(timingRowPrefab, contentParent);
            TimingRowUI rowUI = rowInstance.GetComponent<TimingRowUI>();

            if (rowUI != null)
            {
                rowUI.SetData(driverData.Position, driverData.DriverName, driverData.LapTime, driverData.Gap);
            }
            else
            {
                Debug.LogError("timingRowPrefab is missing the TimingRowUI component!");
            }
        }
    }
}
