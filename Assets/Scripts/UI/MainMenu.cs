using UnityEngine;
using UnityEngine.UI; // Required for UI elements like Button

// This class would be attached to a GameObject in the MainMenu scene.
// It would hold references to the UI buttons and handle their click events.
public class MainMenu : MonoBehaviour
{
    // In the Unity Editor, you would drag the Button objects from your scene
    // onto these fields.

    [Header("UI Buttons")]
    [SerializeField] private Button startCareerButton;
    [SerializeField] private Button loadGameButton;
    [SerializeField] private Button saveGameButton; // Added for testing
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button exitButton;

    // Start is called before the first frame update
    void Start()
    {
        // Here you would add listeners to the buttons, for example:
        startCareerButton.onClick.AddListener(StartCareer);
        loadGameButton.onClick.AddListener(LoadGame);
        saveGameButton.onClick.AddListener(SaveGame); // Added for testing
        settingsButton.onClick.AddListener(OpenSettings);
        exitButton.onClick.AddListener(ExitGame);

        Debug.Log("MainMenu script started. UI elements should be linked.");
    }

    // --- Placeholder Methods for Button Clicks ---

    private void StartCareer()
    {
        Debug.Log("Start Career button clicked!");
        // SceneManager.LoadScene("CareerModeScene"); // Example of what would go here
    }

    private void SaveGame()
    {
        Debug.Log("Save Game button clicked!");
        GameState state = new GameState
        {
            TeamName = "My Racing Team",
            Budget = 1000000f
        };
        SaveManager.Instance.SaveGameState(state);
    }

    private void LoadGame()
    {
        Debug.Log("Load Game button clicked!");
        GameState state = SaveManager.Instance.LoadGameState();
        if (state != null)
        {
            Debug.Log($"Loaded Team: {state.TeamName}, Budget: {state.Budget}");
        }
    }

    private void OpenSettings()
    {
        Debug.Log("Settings button clicked!");
        // Code to open a settings panel would go here.
    }

    private void ExitGame()
    {
        Debug.Log("Exit button clicked!");
        // Application.Quit(); // This would close the application.
    }
}
