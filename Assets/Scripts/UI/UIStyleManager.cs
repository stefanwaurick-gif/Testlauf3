using UnityEngine;

// A static class to manage and provide access to the active UI theme.
public static class UIStyleManager
{
    public static UITheme ActiveTheme { get; private set; }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Initialize()
    {
        // Load the default theme from the Resources folder.
        // In a real game, this could be expanded to load different themes
        // based on user settings.
        ActiveTheme = Resources.Load<UITheme>("UI/DefaultTheme");

        if (ActiveTheme == null)
        {
            Debug.LogError("Could not load default UI Theme! Make sure a UITheme asset exists at 'Resources/UI/DefaultTheme'. Creating a fallback theme.");
            // Create a fallback theme if one isn't found, so the game doesn't crash.
            ActiveTheme = ScriptableObject.CreateInstance<UITheme>();
        }
    }
}
