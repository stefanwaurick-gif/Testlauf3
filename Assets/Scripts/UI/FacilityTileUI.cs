using UnityEngine;
using UnityEngine.UI;

// Manages the UI elements for a single facility tile.
public class FacilityTileUI : MonoBehaviour
{
    [Header("UI Text Fields")]
    [SerializeField] private Text facilityNameText;
    [SerializeField] private Text levelText;
    [SerializeField] private Text bonusText;
    [SerializeField] private Text upgradeCostText;
    [SerializeField] private Text upgradeDurationText;

    [Header("UI Button")]
    [SerializeField] private Button upgradeButton;

    // Public method to populate the tile with data.
    public void SetFacilityData(string name, int level, string bonus, string cost, string duration)
    {
        facilityNameText.text = name;
        levelText.text = $"Level {level}";
        bonusText.text = $"Bonus: {bonus}";
        upgradeCostText.text = $"Kosten: {cost}";
        upgradeDurationText.text = $"Dauer: {duration}";

        // Add a listener to the button to log a message.
        // In a real game, this would trigger an upgrade confirmation popup.
        upgradeButton.onClick.AddListener(() => OnUpgradeButtonClicked(name));
    }

    private void OnUpgradeButtonClicked(string facilityName)
    {
        Debug.Log($"Upgrade button clicked for {facilityName}!");
        // Here you would typically open a confirmation dialog and then
        // interact with a game manager to start the upgrade process.
    }
}
