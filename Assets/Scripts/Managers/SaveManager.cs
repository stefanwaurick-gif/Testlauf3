using UnityEngine;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

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

    public async Task SaveGameState(GameState state)
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        string json = JsonUtility.ToJson(state, true);
        string path = Path.Combine(Application.persistentDataPath, "gamestate.json");
        await File.WriteAllTextAsync(path, json);

        stopwatch.Stop();
        Debug.Log($"Game state saved to {path}. Time taken: {stopwatch.ElapsedMilliseconds}ms");
    }

    public async Task<GameState> LoadGameState()
    {
        string path = Path.Combine(Application.persistentDataPath, "gamestate.json");
        if (File.Exists(path))
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            string json = await File.ReadAllTextAsync(path);
            GameState state = JsonUtility.FromJson<GameState>(json);

            stopwatch.Stop();
            Debug.Log($"Game state loaded. Time taken: {stopwatch.ElapsedMilliseconds}ms");
            return state;
        }
        else
        {
            Debug.LogWarning("Save file not found.");
            return null;
        }
    }
}
