using UnityEngine;
using UnityEngine.UI;

// A singleton system to manage the display of a single, shared tooltip.
public class TooltipSystem : MonoBehaviour
{
    public static TooltipSystem Instance { get; private set; }

    [Header("UI References")]
    [SerializeField] private GameObject tooltipPanel;
    [SerializeField] private Text tooltipText;

    private void Awake()
    {
        // Singleton setup
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }

        // Start with the tooltip hidden
        tooltipPanel.SetActive(false);
    }

    // Shows the tooltip with the specified content.
    public void Show(string content)
    {
        tooltipPanel.SetActive(true);
        tooltipText.text = content;
        // The tooltip's RectTransform should be set to follow the mouse.
        // For this prototype, we'll just activate it. A full implementation
        // would update its position in an Update() method.
    }

    // Hides the tooltip.
    public void Hide()
    {
        tooltipPanel.SetActive(false);
    }
}
