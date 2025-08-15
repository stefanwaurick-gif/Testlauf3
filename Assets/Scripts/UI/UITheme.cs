using UnityEngine;

// A ScriptableObject to hold UI theme data (colors, fonts, etc.).
// This allows designers to create and tweak UI themes as assets in the project.
[CreateAssetMenu(fileName = "UITheme", menuName = "RacingManager/UI Theme", order = 1)]
public class UITheme : ScriptableObject
{
    [Header("Colors")]
    public Color primaryButtonColor = Color.blue;
    public Color secondaryButtonColor = Color.gray;
    public Color textColor = Color.white;
    public Color panelBackgroundColor = new Color(0.1f, 0.1f, 0.1f, 0.9f);

    [Header("Font Sizes")]
    public int headerFontSize = 24;
    public int bodyFontSize = 16;
    public int buttonFontSize = 18;
}
