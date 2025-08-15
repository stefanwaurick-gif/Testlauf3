using UnityEngine;
using System.Collections.Generic;

// Manages the Driver Academy UI panel.
public class DriverAcademyUI : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private GameObject juniorDriverRowPrefab;
    [SerializeField] private Transform contentParent;

    // Test data structure for a junior driver
    private struct JuniorDriverTestData
    {
        public string Name;
        public int Age;
        public string Potential; // e.g., "A", "B+", "C"
        public int CurrentTrainingFocusIndex;
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

        List<JuniorDriverTestData> testData = new List<JuniorDriverTestData>
        {
            new JuniorDriverTestData { Name = "Alex Weber", Age = 17, Potential = "A-", CurrentTrainingFocusIndex = 0 },
            new JuniorDriverTestData { Name = "Sophie Maier", Age = 16, Potential = "B", CurrentTrainingFocusIndex = 1 },
            new JuniorDriverTestData { Name = "Tom Schmidt", Age = 18, Potential = "C+", CurrentTrainingFocusIndex = 2 }
        };

        foreach (var driverData in testData)
        {
            GameObject rowInstance = Instantiate(juniorDriverRowPrefab, contentParent);
            JuniorDriverRowUI rowUI = rowInstance.GetComponent<JuniorDriverRowUI>();

            if (rowUI != null)
            {
                rowUI.SetData(driverData.Name, driverData.Age, driverData.Potential, driverData.CurrentTrainingFocusIndex);
            }
            else
            {
                Debug.LogError("juniorDriverRowPrefab is missing the JuniorDriverRowUI component!");
            }
        }
    }
}
