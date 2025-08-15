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
}
