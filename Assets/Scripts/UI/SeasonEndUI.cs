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

    void Awake()
    {
        ApplyTheme();
        AddTooltips();
    }

    private void ApplyTheme()
    {
        if (UIStyleManager.ActiveTheme == null) return;

        // Style summary text
        seasonText.fontSize = UIStyleManager.ActiveTheme.headerFontSize;
        seasonText.color = UIStyleManager.ActiveTheme.textColor;
        constructorsPositionText.color = UIStyleManager.ActiveTheme.textColor;
        driversPositionText.color = UIStyleManager.ActiveTheme.textColor;
        winsText.color = UIStyleManager.ActiveTheme.textColor;
        selectedFocusText.color = UIStyleManager.ActiveTheme.textColor;

        // Style buttons
        StyleButton(aeroFocusButton);
        StyleButton(engineFocusButton);
        StyleButton(chassisFocusButton);
        StyleButton(reliabilityFocusButton);
        StyleButton(continueButton, true); // Make continue button primary
    }

    private void StyleButton(Button button, bool isPrimary = false)
    {
        if (button == null) return;
        button.GetComponent<Image>().color = isPrimary ? UIStyleManager.ActiveTheme.primaryButtonColor : UIStyleManager.ActiveTheme.secondaryButtonColor;
        button.GetComponentInChildren<Text>().fontSize = UIStyleManager.ActiveTheme.buttonFontSize;
    }

    private void AddTooltips()
    {
        aeroFocusButton.gameObject.AddComponent<TooltipTrigger>().tooltipText = "Startet die nächste Saison mit einem Bonus auf alle Aerodynamik-Forschungsprojekte.";
        engineFocusButton.gameObject.AddComponent<TooltipTrigger>().tooltipText = "Gewährt einen anfänglichen Leistungsschub für den Motor in der neuen Saison.";
        chassisFocusButton.gameObject.AddComponent<TooltipTrigger>().tooltipText = "Verbessert das anfängliche Chassis-Layout und reduziert das Gewicht des Autos.";
        reliabilityFocusButton.gameObject.AddComponent<TooltipTrigger>().tooltipText = "Erhöht die allgemeine Zuverlässigkeit aller Standardteile zu Beginn der neuen Saison.";
    }
}
