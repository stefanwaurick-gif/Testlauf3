using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

// Manages the content of a single R&D component tab (e.g., Aero, Chassis).
public class RnDComponentTab : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private Text installedPartText;
    [SerializeField] private GameObject projectRowPrefab;
    [SerializeField] private Transform projectsParent;

    // A simple struct for R&D project test data
    private struct RnDProjectTestData
    {
        public string ProjectName;
        public int Cost;
        public int DurationDays;
    }

    void Start()
    {
        // This is an example. The actual part name would come from a game manager.
        // The name of the GameObject is used to differentiate the tabs.
        string componentType = gameObject.name;
        PopulateTab(componentType);
    }

    // Populates the tab with test data based on the component type.
    private void PopulateTab(string componentType)
    {
        // 1. Set the installed part text
        installedPartText.text = $"Installiert: {componentType} Mark II";

        // 2. Clear any old project rows
        foreach (Transform child in projectsParent)
        {
            Destroy(child.gameObject);
        }

        // 3. Create and populate project rows with test data
        List<RnDProjectTestData> projects = GetTestDataFor(componentType);
        foreach (var projectData in projects)
        {
            GameObject rowInstance = Instantiate(projectRowPrefab, projectsParent);
            RnDProjectRowUI rowUI = rowInstance.GetComponent<RnDProjectRowUI>();

            if (rowUI != null)
            {
                rowUI.SetProjectData(projectData.ProjectName, projectData.Cost, projectData.DurationDays);
            }
            else
            {
                Debug.LogError("projectRowPrefab is missing the RnDProjectRowUI component!");
            }
        }
    }

    // Returns a list of test projects for a given component type.
    private List<RnDProjectTestData> GetTestDataFor(string type)
    {
        if (type.Contains("Aero"))
        {
            return new List<RnDProjectTestData>
            {
                new RnDProjectTestData { ProjectName = "Neuer Frontflügel", Cost = 500000, DurationDays = 30 },
                new RnDProjectTestData { ProjectName = "Überarbeiteter Unterboden", Cost = 750000, DurationDays = 45 }
            };
        }
        if (type.Contains("Chassis"))
        {
            return new List<RnDProjectTestData>
            {
                new RnDProjectTestData { ProjectName = "Gewichtsreduktion", Cost = 1000000, DurationDays = 60 },
                new RnDProjectTestData { ProjectName = "Steifigkeits-Analyse", Cost = 400000, DurationDays = 25 }
            };
        }
        // Default empty list
        return new List<RnDProjectTestData>();
    }
}
