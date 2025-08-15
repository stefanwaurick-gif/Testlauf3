using System.Collections.Generic;
using UnityEngine;

// This class would be attached to the main panel that displays the list of staff.
public class StaffOverviewPanel : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private GameObject staffRowPrefab; // The prefab for a single row
    [SerializeField] private Transform contentParent;   // The parent object to instantiate rows into (e.g., a Vertical Layout Group)

    // A simple struct to hold test data.
    // In a real project, this would likely be a more complex class,
    // possibly loaded from a game data file.
    private struct StaffTestData
    {
        public string Name;
        public string Role;
        public string TopSkill;
        public float Morale;
        public string MoraleFactors;
    }

    // Start is called before the first frame update
    void Start()
    {
        PopulateWithTestData();
    }

    // Populates the UI with hardcoded test data.
    private void PopulateWithTestData()
    {
        // First, clear any existing children if necessary
        foreach (Transform child in contentParent)
        {
            Destroy(child.gameObject);
        }

        // Create a list of test data
        List<StaffTestData> testData = new List<StaffTestData>
        {
            new StaffTestData { Name = "Jane Doe", Role = "Technischer Direktor", TopSkill = "Aerodynamik (18)", Morale = 92f, MoraleFactors = "+ Gutes Gehalt\n+ Kürzlicher Rennsieg" },
            new StaffTestData { Name = "John Smith", Role = "Chef-Aerodynamiker", TopSkill = "CFD-Analyse (19)", Morale = 65f, MoraleFactors = "+ Gutes Gehalt\n- Hohe Arbeitsbelastung" },
            new StaffTestData { Name = "Peter Jones", Role = "Renningenieur", TopSkill = "Strategie (17)", Morale = 40f, MoraleFactors = "- Gehalt unterdurchschnittlich\n- Schlechtes letztes Rennergebnis" }
        };

        // Instantiate a prefab for each staff member
        foreach (var staffMember in testData)
        {
            if (staffRowPrefab != null && contentParent != null)
            {
                GameObject rowInstance = Instantiate(staffRowPrefab, contentParent);
                StaffRowUI rowUI = rowInstance.GetComponent<StaffRowUI>();

                if (rowUI != null)
                {
                    rowUI.SetStaffData(staffMember.Name, staffMember.Role, staffMember.TopSkill, staffMember.Morale, staffMember.MoraleFactors);
                }
                else
                {
                    Debug.LogError("StaffRowPrefab is missing the StaffRowUI component!");
                }
            }
            else
            {
                Debug.LogError("StaffRowPrefab or ContentParent is not assigned in the inspector!");
            }
        }
    }
}
