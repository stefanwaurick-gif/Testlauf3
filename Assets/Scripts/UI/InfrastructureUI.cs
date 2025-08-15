using UnityEngine;
using System.Collections.Generic;

// Manages the Infrastructure Panel, populating it with facility tiles.
public class InfrastructureUI : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private GameObject facilityTilePrefab;
    [SerializeField] private Transform contentParent; // e.g., a Grid Layout Group

    // Test data structure for a facility
    private struct FacilityTestData
    {
        public string Name;
        public int Level;
        public string CurrentBonus;
        public string NextLevelCost;
        public string NextLevelDuration;
    }

    void Start()
    {
        PopulateWithTestData();
    }

    private void PopulateWithTestData()
    {
        // Clear existing tiles
        foreach (Transform child in contentParent)
        {
            Destroy(child.gameObject);
        }

        // Create test data
        List<FacilityTestData> testData = new List<FacilityTestData>
        {
            new FacilityTestData { Name = "Windkanal", Level = 2, CurrentBonus = "+10% Aero-Forschung", NextLevelCost = "3,000,000 $", NextLevelDuration = "90 Tage" },
            new FacilityTestData { Name = "Fabrik", Level = 3, CurrentBonus = "+15% Fertigungstempo", NextLevelCost = "5,000,000 $", NextLevelDuration = "120 Tage" },
            new FacilityTestData { Name = "Fahrsimulator", Level = 1, CurrentBonus = "+5% Fahrer-XP", NextLevelCost = "1,500,000 $", NextLevelDuration = "60 Tage" },
            new FacilityTestData { Name = "Scouting-Abteilung", Level = 1, CurrentBonus = "Standard-Genauigkeit", NextLevelCost = "750,000 $", NextLevelDuration = "45 Tage" }
        };

        // Instantiate and populate tiles
        foreach (var facility in testData)
        {
            GameObject tileInstance = Instantiate(facilityTilePrefab, contentParent);
            FacilityTileUI tileUI = tileInstance.GetComponent<FacilityTileUI>();

            if (tileUI != null)
            {
                tileUI.SetFacilityData(facility.Name, facility.Level, facility.CurrentBonus, facility.NextLevelCost, facility.NextLevelDuration);
            }
            else
            {
                Debug.LogError("facilityTilePrefab is missing the FacilityTileUI component!");
            }
        }
    }
}
