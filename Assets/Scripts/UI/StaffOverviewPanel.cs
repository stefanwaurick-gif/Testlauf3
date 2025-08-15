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
        public StaffRole Role;
        public string TopSkill;
        public float Morale;
        public string MoraleFactors;
        public List<Trait> Traits;
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
            new StaffTestData { Name = "Max Verstappen", Role = StaffRole.Fahrer, TopSkill = "Aggressivität (20)", Morale = 88f, MoraleFactors = "+ Top-Fahrer-Status",
                Traits = new List<Trait> { new Trait { Name = "Regenmeister", Description = "Fährt bei Nässe 5% schneller." }, new Trait { Name = "Reifenflüsterer", Description = "Reduziert Reifenverschleiß um 10%." } } },
            new StaffTestData { Name = "Jane Doe", Role = StaffRole.TechnischerDirektor, TopSkill = "Aerodynamik (18)", Morale = 92f, MoraleFactors = "+ Gutes Gehalt\n+ Kürzlicher Rennsieg", Traits = null },
            new StaffTestData { Name = "John Smith", Role = StaffRole.ChefAerodynamiker, TopSkill = "CFD-Analyse (19)", Morale = 65f, MoraleFactors = "+ Gutes Gehalt\n- Hohe Arbeitsbelastung", Traits = null },
            new StaffTestData { Name = "Peter Jones", Role = StaffRole.Renningenieur, TopSkill = "Strategie (17)", Morale = 40f, MoraleFactors = "- Gehalt unterdurchschnittlich\n- Schlechtes letztes Rennergebnis", Traits = null }
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
                    rowUI.SetStaffData(staffMember.Name, staffMember.Role, staffMember.TopSkill, staffMember.Morale, staffMember.MoraleFactors, staffMember.Traits);
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
