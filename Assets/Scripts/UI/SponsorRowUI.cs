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

    [Header("Sponsor Satisfaction")]
    [SerializeField] private Image satisfactionBar;
    [SerializeField] private Button specialRequestButton; // To simulate a request

    private EventPopupUI eventPopup;
    private string sponsorName;

    // Public method to populate the fields with data.
    public void Setup(string name, string upfront, string bonus, string goal, float satisfaction, EventPopupUI popup)
    {
        this.sponsorName = name;
        this.eventPopup = popup;

        sponsorNameText.text = name;
        upfrontPaymentText.text = $"Vorauszahlung: {upfront}";
        raceBonusText.text = $"Rennbonus: {bonus}";
        goalText.text = $"Saisonziel: {goal}";

        // Update satisfaction bar
        satisfactionBar.fillAmount = satisfaction / 100f;

        // Add listener for special request button
        specialRequestButton.onClick.RemoveAllListeners();
        specialRequestButton.onClick.AddListener(OnSpecialRequest);
    }

    private void OnSpecialRequest()
    {
        if (eventPopup == null) return;

        EventData requestEvent = new EventData
        {
            Title = "Spezialanfrage von " + sponsorName,
            Description = "Unser Sponsor bittet darum, dass wir beim nächsten Rennen einen Fahrer aus ihrer Heimatregion für ein PR-Event einsetzen. Dies könnte die Moral des anderen Fahrers beeinträchtigen.",
            Choices = new System.Collections.Generic.List<string> { "Anfrage annehmen", "Höflich ablehnen" }
        };

        eventPopup.ShowEvent(requestEvent);
    }
}
