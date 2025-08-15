using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

// Manages the Finance Panel, including its tabs for Overview and Sponsors.
public class FinanceUI : MonoBehaviour
{
    [Header("Tab System")]
    [SerializeField] private List<Button> tabButtons; // Should have 2 buttons: Overview, Sponsors
    [SerializeField] private List<GameObject> tabContents; // Should have 2 content panels

    void Start()
    {
        // Add listeners to all tab buttons
        for (int i = 0; i < tabButtons.Count; i++)
        {
            int index = i; // Avoid closure issues
            tabButtons[i].onClick.AddListener(() => SelectTab(index));
        }

        // Select the first tab (Overview) by default
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
            tabButtons[i].interactable = !isSelected;
        }

        Debug.Log($"Selected Finance Tab: {tabButtons[tabIndex].name}");
    }
}
