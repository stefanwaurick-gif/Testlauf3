using UnityEngine;
using UnityEngine.UI;

// Holds the UI element references for a single R&D project row.
public class RnDProjectRowUI : MonoBehaviour
{
    [Header("UI Text Fields")]
    [SerializeField] private Text projectNameText;
    [SerializeField] private Text costText;
    [SerializeField] private Text durationText;

    // A public method to populate the fields.
    // This would be called from RnDComponentTab in a full implementation.
    public void SetProjectData(string projectName, int cost, int duration)
    {
        projectNameText.text = projectName;
        costText.text = $"Kosten: {cost:C0}"; // Format as currency
        durationText.text = $"Dauer: {duration} Tage";
    }
}
