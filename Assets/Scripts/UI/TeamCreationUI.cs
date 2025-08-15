using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

// Manages the Team Creation UI screen.
public class TeamCreationUI : MonoBehaviour
{
    [Header("Team Name")]
    [SerializeField] private InputField teamNameInput;

    [Header("Color Selection")]
    [SerializeField] private List<Button> colorSelectionButtons;
    [SerializeField] private Image selectedColorDisplay; // An image to show the chosen color

    [Header("Logo Selection")]
    [SerializeField] private Image logoDisplay;
    [SerializeField] private Button previousLogoButton;
    [SerializeField] private Button nextLogoButton;
    [SerializeField] private List<Sprite> logoOptions; // Assign logos in the Inspector

    [Header("Confirmation")]
    [SerializeField] private Button startCareerButton;

    // Data storage for player choices
    private string teamName;
    private Color teamColor;
    private int selectedLogoIndex = 0;

    void Start()
    {
        // --- Setup Listeners ---
        teamNameInput.onValueChanged.AddListener(OnTeamNameChanged);

        // Add listeners for each color button
        for (int i = 0; i < colorSelectionButtons.Count; i++)
        {
            int index = i;
            colorSelectionButtons[i].onClick.AddListener(() => OnColorSelected(colorSelectionButtons[index].GetComponent<Image>().color));
        }

        previousLogoButton.onClick.AddListener(OnPreviousLogo);
        nextLogoButton.onClick.AddListener(OnNextLogo);
        startCareerButton.onClick.AddListener(OnStartCareer);

        // --- Initial State ---
        // Set initial color (from the first button, for example)
        if (colorSelectionButtons.Count > 0)
        {
            OnColorSelected(colorSelectionButtons[0].GetComponent<Image>().color);
        }
        // Set initial logo
        UpdateLogoDisplay();
    }

    private void OnTeamNameChanged(string newName)
    {
        teamName = newName;
    }

    private void OnColorSelected(Color color)
    {
        teamColor = color;
        selectedColorDisplay.color = color;
    }

    private void OnPreviousLogo()
    {
        selectedLogoIndex--;
        if (selectedLogoIndex < 0)
        {
            selectedLogoIndex = logoOptions.Count - 1;
        }
        UpdateLogoDisplay();
    }

    private void OnNextLogo()
    {
        selectedLogoIndex++;
        if (selectedLogoIndex >= logoOptions.Count)
        {
            selectedLogoIndex = 0;
        }
        UpdateLogoDisplay();
    }

    private void UpdateLogoDisplay()
    {
        if (logoOptions != null && logoOptions.Count > 0)
        {
            logoDisplay.sprite = logoOptions[selectedLogoIndex];
        }
    }

    private void OnStartCareer()
    {
        // In a real game, this would save the data and load the next scene.
        // For this prototype, we just log the choices.
        Debug.Log("--- Starting Career ---");
        Debug.Log($"Team Name: {teamName}");
        Debug.Log($"Team Color: {teamColor}");
        Debug.Log($"Selected Logo: {logoOptions[selectedLogoIndex].name} (Index: {selectedLogoIndex})");
        Debug.Log("-----------------------");
    }
}
