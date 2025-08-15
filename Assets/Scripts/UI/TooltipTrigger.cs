using UnityEngine;
using UnityEngine.EventSystems;

// This component can be attached to any UI element with a Raycast Target.
// It triggers the TooltipSystem on mouse hover.
public class TooltipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [Tooltip("The text to display in the tooltip.")]
    [TextArea(3, 10)] // Makes the string field larger in the Inspector
    public string tooltipText;

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Show the tooltip when the mouse enters the element
        if (!string.IsNullOrEmpty(tooltipText))
        {
            TooltipSystem.Instance.Show(tooltipText);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Hide the tooltip when the mouse exits
        TooltipSystem.Instance.Hide();
    }
}
