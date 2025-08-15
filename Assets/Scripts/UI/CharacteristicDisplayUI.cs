using UnityEngine;
using UnityEngine.UI;

// Manages a single UI element that displays a track characteristic.
public class CharacteristicDisplayUI : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private Image iconImage;
    [SerializeField] private Text descriptionText;

    // Sets the data for this UI element.
    public void SetData(Sprite icon, string description)
    {
        iconImage.sprite = icon;
        descriptionText.text = description;
    }
}
