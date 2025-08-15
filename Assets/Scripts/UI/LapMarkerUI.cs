using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

// Manages a single lap marker in the strategy timeline.
public class LapMarkerUI : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private Text lapNumberText;
    [SerializeField] private Button stopButton; // The main button for the marker
    [SerializeField] private Image stopIndicator; // A visual element to show a stop is planned
    [SerializeField] private Dropdown tireDropdown;

    private RaceStrategyUI controller;
    private int lapNumber;
    private bool isStopping = false;

    // Called by the RaceStrategyUI to initialize this marker.
    public void Setup(RaceStrategyUI strategyController, int lap)
    {
        controller = strategyController;
        lapNumber = lap;
        lapNumberText.text = lap.ToString();

        // Add listeners
        stopButton.onClick.AddListener(OnStopButtonClicked);
        tireDropdown.onValueChanged.AddListener(OnTireSelectionChanged);

        // Populate dropdown
        tireDropdown.ClearOptions();
        List<string> options = new List<string>();
        foreach (string compound in System.Enum.GetNames(typeof(TireCompound)))
        {
            options.Add(compound);
        }
        tireDropdown.AddOptions(options);

        // Initial state
        tireDropdown.gameObject.SetActive(false);
        stopIndicator.enabled = false;
    }

    private void OnStopButtonClicked()
    {
        isStopping = !isStopping;

        // Update visuals
        stopIndicator.enabled = isStopping;
        tireDropdown.gameObject.SetActive(isStopping);

        // Notify the controller
        TireCompound selectedCompound = (TireCompound)tireDropdown.value;
        controller.UpdatePitStop(lapNumber, isStopping, selectedCompound);
    }

    private void OnTireSelectionChanged(int index)
    {
        // This only matters if a stop is already planned for this lap.
        if (isStopping)
        {
            TireCompound selectedCompound = (TireCompound)index;
            // Notify the controller of the change
            controller.UpdatePitStop(lapNumber, isStopping, selectedCompound);
        }
    }
}
