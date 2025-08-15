using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections; // Required for coroutines

// A simple data structure to hold event information.
public class EventData
{
    public string Title;
    public string Description;
    public List<string> Choices;
}

// Manages the modal event pop-up window.
public class EventPopupUI : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private GameObject popupPanel; // The entire popup object
    [SerializeField] private Text titleText;
    [SerializeField] private Text descriptionText;
    [SerializeField] private Transform choicesParent; // The container for the choice buttons
    [SerializeField] private GameObject choiceButtonPrefab;

    void Start()
    {
        // Start hidden
        popupPanel.SetActive(false);

        // --- Test Harness ---
        // This is a simple way to test the popup without an external manager.
        // It will show a test event after a 3-second delay.
        StartCoroutine(ShowTestEventAfterDelay(3f));
    }

    private IEnumerator ShowTestEventAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        EventData testEvent = new EventData
        {
            Title = "Schwerer Motorschaden!",
            Description = "Der Motor von Fahrer 1 ist im Training explodiert! Eine Reparatur ist teuer, aber ein Ausfall im Rennen wäre eine Katastrophe.",
            Choices = new List<string> { "Teuer reparieren (-1M$)", "Risiko eingehen" }
        };
        ShowEvent(testEvent);
    }

    void Awake()
    {
        ApplyTheme();
    }

    private void ApplyTheme()
    {
        if (UIStyleManager.ActiveTheme == null) return;

        popupPanel.GetComponent<Image>().color = UIStyleManager.ActiveTheme.panelBackgroundColor;
        titleText.fontSize = UIStyleManager.ActiveTheme.headerFontSize;
        titleText.color = UIStyleManager.ActiveTheme.textColor;
        descriptionText.fontSize = UIStyleManager.ActiveTheme.bodyFontSize;
        descriptionText.color = UIStyleManager.ActiveTheme.textColor;
    }

    public void ShowEvent(EventData eventData)
    {
        // Show the panel
        popupPanel.SetActive(true);

        // Populate text
        titleText.text = eventData.Title;
        descriptionText.text = eventData.Description;

        // Clear old choices
        foreach (Transform child in choicesParent)
        {
            Destroy(child.gameObject);
        }

        // Create new choice buttons
        for (int i = 0; i < eventData.Choices.Count; i++)
        {
            GameObject buttonInstance = Instantiate(choiceButtonPrefab, choicesParent);
            // Set button text
            Text buttonText = buttonInstance.GetComponentInChildren<Text>();
            buttonText.text = eventData.Choices[i];

            // Apply theme to the new button
            if (UIStyleManager.ActiveTheme != null)
            {
                buttonInstance.GetComponent<Image>().color = UIStyleManager.ActiveTheme.secondaryButtonColor;
                buttonText.fontSize = UIStyleManager.ActiveTheme.buttonFontSize;
            }

            int choiceIndex = i; // Avoid closure issues
            buttonInstance.GetComponent<Button>().onClick.AddListener(() => OnChoiceMade(choiceIndex));
        }
    }

    private void OnChoiceMade(int choiceIndex)
    {
        Debug.Log($"Player made choice {choiceIndex}.");
        Hide();
    }

    private void Hide()
    {
        popupPanel.SetActive(false);
    }
}
