using UnityEngine;
using UnityEngine.UI;

// Holds UI element references for a single sponsor row.
public class SponsorRowUI : MonoBehaviour
{
    [Header("UI Text Fields")]
    [SerializeField] private Text sponsorNameText;
    [SerializeField] private Text upfrontPaymentText;
    [SerializeField] private Text raceBonusText;
    [SerializeField] private Text goalText;

    // Public method to populate the fields with data.
    public void SetSponsorData(string name, string upfront, string bonus, string goal)
    {
        sponsorNameText.text = name;
        upfrontPaymentText.text = $"Vorauszahlung: {upfront}";
        raceBonusText.text = $"Rennbonus: {bonus}";
        goalText.text = $"Saisonziel: {goal}";
    }
}
