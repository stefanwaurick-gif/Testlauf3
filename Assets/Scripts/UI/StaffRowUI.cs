using UnityEngine;
using UnityEngine.UI; // Required for UI elements like Text

// This script would be attached to a prefab that represents a single row
// in the staff list. It holds references to the UI elements in that row.
public class StaffRowUI : MonoBehaviour
{
    [Header("UI Text Fields")]
    [SerializeField] private Text nameText;
    [SerializeField] private Text roleText;
    [SerializeField] private Text topSkillText;

    [Header("Morale Display")]
    [SerializeField] private Image moraleIndicator;
    [SerializeField] private Button moraleDetailsButton; // Button to show tooltip info

    // This method would be called by the StaffOverviewPanel to populate
    // this row with a specific staff member's data.
    public void SetStaffData(string staffName, string staffRole, string topSkill, float morale, string moraleFactors)
    {
        if (nameText != null) nameText.text = staffName;
        if (roleText != null) roleText.text = staffRole;
        if (topSkillText != null) topSkillText.text = topSkill;

        // Update morale visual
        UpdateMoraleVisual(morale);

        // Setup tooltip simulation
        if (moraleDetailsButton != null)
        {
            moraleDetailsButton.onClick.RemoveAllListeners(); // Clear previous listeners
            moraleDetailsButton.onClick.AddListener(() => ShowMoraleTooltip(moraleFactors));
        }
    }

    private void UpdateMoraleVisual(float morale)
    {
        if (moraleIndicator == null) return;

        // Morale is 1-100
        if (morale > 80)
        {
            moraleIndicator.color = Color.green; // Excellent
        }
        else if (morale > 50)
        {
            moraleIndicator.color = Color.yellow; // Good
        }
        else if (morale > 20)
        {
            moraleIndicator.color = new Color(1.0f, 0.5f, 0.0f); // Orange for average/poor
        }
        else
        {
            moraleIndicator.color = Color.red; // Very Poor
        }
    }

    private void ShowMoraleTooltip(string factors)
    {
        // In a real UI, this would show a tooltip panel.
        // For this prototype, we just log the information.
        Debug.Log($"Morale Factors for {nameText.text}:\n{factors}");
    }
}
