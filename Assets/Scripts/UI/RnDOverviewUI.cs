using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

// Manages the R&D Overview Panel, including its tabs.
public class RnDOverviewUI : MonoBehaviour
{
    [Header("Tab System")]
    [SerializeField] private List<Button> tabButtons;
    [SerializeField] private List<GameObject> tabContents;

    void Start()
    {
        // Add listeners to all tab buttons
        for (int i = 0; i < tabButtons.Count; i++)
        {
            int index = i; // Avoid closure issues
            tabButtons[i].onClick.AddListener(() => SelectTab(index));
        }

        // Select the first tab by default
        if (tabButtons.Count > 0)
        {
            SelectTab(0);
        }

        SetupExperimentalProject();
    }

    // Activates the selected tab and deactivates others.
    public void SelectTab(int tabIndex)
    {
        for (int i = 0; i < tabContents.Count; i++)
        {
            bool isSelected = (i == tabIndex);
            tabContents[i].SetActive(isSelected);
            // Optionally, change the visual state of the button
            tabButtons[i].interactable = !isSelected;
        }

        Debug.Log($"Selected R&D Tab: {tabButtons[tabIndex].name}");
    }

    // In a real implementation, you would populate each tab's content
    // with data from a game manager. For this prototype, the content
    // is assumed to be pre-configured in the scene or handled by
    // other scripts on the tab GameObjects.

    [Header("Experimental Project")]
    [SerializeField] private Button startExperimentalProjectButton;
    [SerializeField] private Text experimentalProjectStatusText;
    [SerializeField] private Button simulateFinishExperimentalProjectButton;
    [SerializeField] private EventPopupUI eventPopup; // Reference to the event popup

    private bool isProjectRunning = false;

    private void SetupExperimentalProject()
    {
        startExperimentalProjectButton.onClick.AddListener(OnStartExperimentalProject);
        simulateFinishExperimentalProjectButton.onClick.AddListener(OnFinishExperimentalProject);

        // Initial state
        experimentalProjectStatusText.text = "Gesperrt";
        startExperimentalProjectButton.interactable = true;
        simulateFinishExperimentalProjectButton.gameObject.SetActive(false);
    }

    private void OnStartExperimentalProject()
    {
        isProjectRunning = true;
        experimentalProjectStatusText.text = "Projekt läuft... Analyse unklar.";
        startExperimentalProjectButton.interactable = false;
        simulateFinishExperimentalProjectButton.gameObject.SetActive(true);
    }

    private void OnFinishExperimentalProject()
    {
        if (!isProjectRunning) return;

        // Randomly determine the outcome
        int outcome = Random.Range(0, 3); // 0: Success, 1: Breakthrough, 2: Failure
        EventData resultEvent = new EventData();

        switch (outcome)
        {
            case 0: // Success
                resultEvent.Title = "Experiment erfolgreich!";
                resultEvent.Description = "Das experimentelle Teil hat die erwartete Leistung erbracht. Es ist eine solide, aber nicht weltbewegende Verbesserung.";
                resultEvent.Choices = new List<string> { "Großartig!" };
                break;
            case 1: // Breakthrough
                resultEvent.Title = "Durchbruch!";
                resultEvent.Description = "Unglaublich! Das Teil übertrifft alle Erwartungen und könnte uns einen entscheidenden Vorteil verschaffen!";
                resultEvent.Choices = new List<string> { "Fantastisch!" };
                break;
            case 2: // Failure
                resultEvent.Title = "Kompletter Fehlschlag!";
                resultEvent.Description = "Das Design war fehlerhaft. Das Teil ist unbrauchbar und die investierten Ressourcen sind verloren.";
                resultEvent.Choices = new List<string> { "Ärgerlich." };
                break;
        }

        // Show the result in the popup
        eventPopup.ShowEvent(resultEvent);

        // Reset the slot
        isProjectRunning = false;
        experimentalProjectStatusText.text = "Gesperrt";
        startExperimentalProjectButton.interactable = true;
        simulateFinishExperimentalProjectButton.gameObject.SetActive(false);
    }
}
