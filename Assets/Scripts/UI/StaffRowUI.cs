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

    // This method would be called by the StaffOverviewPanel to populate
    // this row with a specific staff member's data.
    public void SetStaffData(string staffName, string staffRole, string topSkill)
    {
        if (nameText != null)
        {
            nameText.text = staffName;
        }

        if (roleText != null)
        {
            roleText.text = staffRole;
        }

        if (topSkillText != null)
        {
            topSkillText.text = topSkill;
        }
    }
}
