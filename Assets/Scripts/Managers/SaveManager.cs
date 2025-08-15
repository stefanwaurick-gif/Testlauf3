using UnityEngine;
using System.IO;

public class SaveManager : MonoBehaviour
{
    public static SaveManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SaveGameState(GameState state)
    {
        string json = JsonUtility.ToJson(state, true);
        string path = Path.Combine(Application.persistentDataPath, "gamestate.json");
        File.WriteAllText(path, json);
        Debug.Log($"Game state saved to {path}");
    }

    public GameState LoadGameState()
    {
        string path = Path.Combine(Application.persistentDataPath, "gamestate.json");
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            GameState state = JsonUtility.FromJson<GameState>(json);
            Debug.Log("Game state loaded.");
            return state;
        }
        else
        {
            Debug.LogWarning("Save file not found.");
            return null;
        }
    }
}
