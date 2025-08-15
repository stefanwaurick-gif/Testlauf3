using UnityEngine;
using UnityEngine.UI;

// Manages the player's car status display (Tires, Fuel, ERS).
public class PlayerStatsUI : MonoBehaviour
{
    [Header("Fuel")]
    [SerializeField] private Image fuelBar;
    [SerializeField] private Text fuelText;

    [Header("ERS")]
    [SerializeField] private Image ersBar;
    [SerializeField] private Text ersText;

    [Header("Tires")]
    [SerializeField] private Image frontLeftTire;
    [SerializeField] private Image frontRightTire;
    [SerializeField] private Image rearLeftTire;
    [SerializeField] private Image rearRightTire;
    [SerializeField] private Text tireCompoundText;

    [Header("Strategy")]
    [SerializeField] private Dropdown ersModeDropdown;
    [SerializeField] private Button holdPositionButton;
    [SerializeField] private Button swapPositionsButton;

    // Enum for ERS modes for clarity
    private enum ERSMode { Overtake, Neutral, Recharge, Defend, Hotlap }

    // Test values
    private float fuelLevel = 80.5f; // kg
    private float ersLevel = 95.0f; // %
    private float[] tireWear = { 10f, 12f, 8f, 9f }; // % wear

    void Start()
    {
        // Initial update with test data
        UpdateStats(fuelLevel, ersLevel, tireWear, "Soft");
        SetupStrategyControls();

        // Example of how button interactability would be controlled
        SetTeamOrderButtonsInteractable(false);
    }

    private void SetupStrategyControls()
    {
        // Populate ERS dropdown
        ersModeDropdown.ClearOptions();
        List<string> options = new List<string>();
        foreach (string mode in System.Enum.GetNames(typeof(ERSMode)))
        {
            options.Add(mode);
        }
        ersModeDropdown.AddOptions(options);
        ersModeDropdown.onValueChanged.AddListener(OnERSModeChanged);

        // Add button listeners
        holdPositionButton.onClick.AddListener(OnHoldPositionClicked);
        swapPositionsButton.onClick.AddListener(OnSwapPositionsClicked);
    }

    // This method would be called periodically by a RaceManager with live data.
    public void UpdateStats(float fuel, float ers, float[] wear, string compound)
    {
        // --- Fuel ---
        // Assuming max fuel is 110kg. Normalize to 0-1 range for the fill bar.
        fuelBar.fillAmount = fuel / 110.0f;
        fuelText.text = $"{fuel:F1} kg";

        // --- ERS ---
        // Normalize to 0-1 range.
        ersBar.fillAmount = ers / 100.0f;
        ersText.text = $"{ers:F0}%";

        // --- Tires ---
        // Tire wear is inverted for the visual. 100% wear = 0% fill.
        // We can also color the tires based on wear.
        frontLeftTire.fillAmount = 1.0f - (wear[0] / 100.0f);
        frontLeftTire.color = GetTireColor(wear[0]);

        frontRightTire.fillAmount = 1.0f - (wear[1] / 100.0f);
        frontRightTire.color = GetTireColor(wear[1]);

        rearLeftTire.fillAmount = 1.0f - (wear[2] / 100.0f);
        rearLeftTire.color = GetTireColor(wear[2]);

        rearRightTire.fillAmount = 1.0f - (wear[3] / 100.0f);
        rearRightTire.color = GetTireColor(wear[3]);

        tireCompoundText.text = compound;
    }

    private Color GetTireColor(float wearPercentage)
    {
        if (wearPercentage > 70) return Color.red;
        if (wearPercentage > 40) return Color.yellow;
        return Color.green;
    }

    // --- Strategy Methods ---

    public void SetTeamOrderButtonsInteractable(bool interactable)
    {
        holdPositionButton.interactable = interactable;
        swapPositionsButton.interactable = interactable;
        Debug.Log($"Team order buttons interactable state set to: {interactable}");
    }

    private void OnERSModeChanged(int index)
    {
        ERSMode selectedMode = (ERSMode)index;
        Debug.Log($"ERS Mode changed to: {selectedMode}");
        // In a real game, this would send a command to the CarController
    }

    private void OnHoldPositionClicked()
    {
        Debug.Log("Team Order: Hold Position clicked!");
        // Logic to send command to RaceManager
    }

    private void OnSwapPositionsClicked()
    {
        Debug.Log("Team Order: Swap Positions clicked!");
        // Logic to send command to RaceManager
    }
}
