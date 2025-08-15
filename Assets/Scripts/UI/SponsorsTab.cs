using UnityEngine;
using System.Collections.Generic;

// Manages the content of the Sponsors tab.
public class SponsorsTab : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private GameObject sponsorRowPrefab;
    [SerializeField] private Transform contentParent;
    [SerializeField] private EventPopupUI eventPopup; // Reference to the popup

    // Test data structure for a sponsor deal
    private struct SponsorTestData
    {
        public string SponsorName;
        public string UpfrontPayment;
        public string RaceBonus;
        public string Goal;
        public float Satisfaction;
    }

    void Start()
    {
        PopulateWithTestData();
    }

    private void PopulateWithTestData()
    {
        // Clear existing rows
        foreach (Transform child in contentParent)
        {
            Destroy(child.gameObject);
        }

        // Create test data
        List<SponsorTestData> testData = new List<SponsorTestData>
        {
            new SponsorTestData { SponsorName = "Hauptsponsor: ChronoDrive Uhren", UpfrontPayment = "5,000,000 $", RaceBonus = "250,000 $ (Podium)", Goal = "Konstrukteurs-WM: Top 5", Satisfaction = 85f },
            new SponsorTestData { SponsorName = "Nebensponsor: Quantum Cola", UpfrontPayment = "1,000,000 $", RaceBonus = "50,000 $ (Punkte)", Goal = "Fahrer-WM: Top 10", Satisfaction = 95f },
            new SponsorTestData { SponsorName = "Nebensponsor: Apex Öle", UpfrontPayment = "750,000 $", RaceBonus = "Kein Rennbonus", Goal = "Kein Saisonziel", Satisfaction = 55f }
        };

        // Instantiate and populate rows
        foreach (var sponsor in testData)
        {
            GameObject rowInstance = Instantiate(sponsorRowPrefab, contentParent);
            SponsorRowUI rowUI = rowInstance.GetComponent<SponsorRowUI>();

            if (rowUI != null)
            {
                rowUI.Setup(sponsor.SponsorName, sponsor.UpfrontPayment, sponsor.RaceBonus, sponsor.Goal, sponsor.Satisfaction, eventPopup);
            }
            else
            {
                Debug.LogError("sponsorRowPrefab is missing the SponsorRowUI component!");
            }
        }
    }
}
