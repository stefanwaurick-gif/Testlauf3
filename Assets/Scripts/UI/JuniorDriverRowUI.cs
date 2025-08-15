using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

// Manages a single row in the Driver Academy list.
public class JuniorDriverRowUI : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private Text nameText;
    [SerializeField] private Text ageText;
    [SerializeField] private Text potentialText;
    [SerializeField] private Dropdown trainingFocusDropdown;

    private string driverName;
    private List<string> trainingOptions = new List<string> { "Pace", "Konstanz", "Überholen", "Reifenmanagement" };

    // Sets the data for this driver row.
    public void SetData(string name, int age, string potential, int focusIndex)
    {
        driverName = name;
        nameText.text = name;
        ageText.text = $"Alter: {age}";
        potentialText.text = $"Potenzial: {potential}";

        // Setup the dropdown
        trainingFocusDropdown.ClearOptions();
        trainingFocusDropdown.AddOptions(trainingOptions);

        // Set initial value without triggering the listener
        trainingFocusDropdown.SetValueWithoutNotify(focusIndex);

        // Add listener for when the user changes the focus
        trainingFocusDropdown.onValueChanged.AddListener(OnTrainingFocusChanged);
    }

    private void OnTrainingFocusChanged(int newIndex)
    {
        Debug.Log($"Training focus for {driverName} changed to: {trainingOptions[newIndex]}");
        // Here, you would typically update a central game data object.
    }
}
