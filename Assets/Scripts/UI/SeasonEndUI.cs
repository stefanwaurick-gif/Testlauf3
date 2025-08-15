using UnityEngine;
using UnityEngine.UI;

// Manages the End of Season UI screen.
public class SeasonEndUI : MonoBehaviour
{
    [Header("Season Summary")]
    [SerializeField] private Text seasonText;
    [SerializeField] private Text constructorsPositionText;
    [SerializeField] private Text driversPositionText;
    [SerializeField] private Text winsText;

    [Header("R&D Focus Choices")]
    [SerializeField] private Button aeroFocusButton;
    [SerializeField] private Button engineFocusButton;
    [SerializeField] private Button chassisFocusButton;
    [SerializeField] private Button reliabilityFocusButton;

    [Header("Confirmation")]
    [SerializeField] private Button continueButton;
    [SerializeField] private Text selectedFocusText;

    private string selectedFocus;

    void Start()
    {
        // 1. Populate Summary with Test Data
        seasonText.text = "Saison 2026";
        constructorsPositionText.text = "Konstrukteurs-WM: Platz 4";
        driversPositionText.text = "Fahrer-WM: Platz 5 & 9";
        winsText.text = "Saisonsiege: 2";

        // 2. Setup Button Listeners
        aeroFocusButton.onClick.AddListener(() => OnFocusSelected("Aerodynamik"));
        engineFocusButton.onClick.AddListener(() => OnFocusSelected("Motorleistung"));
        chassisFocusButton.onClick.AddListener(() => OnFocusSelected("Chassis"));
        reliabilityFocusButton.onClick.AddListener(() => OnFocusSelected("Zuverlässigkeit"));

        continueButton.onClick.AddListener(OnContinue);

        // 3. Set Initial State
        continueButton.interactable = false;
        selectedFocusText.text = "Wähle einen F&E-Fokus für die nächste Saison.";
    }

    private void OnFocusSelected(string focusName)
    {
        selectedFocus = focusName;
        selectedFocusText.text = $"Gewählter Fokus: {selectedFocus}";
        Debug.Log($"Player selected R&D Focus: {selectedFocus}");

        // Deselect other buttons visually (optional, but good UX)
        // This part is harder to implement without more complex button logic,
        // but we can enable the continue button.
        continueButton.interactable = true;
    }

    private void OnContinue()
    {
        Debug.Log($"Proceeding to next season with focus on {selectedFocus}.");
        // Here you would trigger the game's logic to advance to the new season.
        // For the prototype, we can just deactivate this screen.
        gameObject.SetActive(false);
    }
}
