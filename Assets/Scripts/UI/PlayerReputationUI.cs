using UnityEngine;
using UnityEngine.UI;
using System.Linq; // Required for Max()

// Manages the Player Reputation UI panel.
public class PlayerReputationUI : MonoBehaviour
{
    // The four reputation archetypes
    public enum ReputationArchetype { Pragmatiker, Innovator, Showman, Stratege }

    [Header("UI References")]
    [SerializeField] private Text dominantReputationTitle;

    // A simple container to link archetypes to their UI elements
    [System.Serializable]
    public struct ReputationUIMapping
    {
        public ReputationArchetype archetype;
        public Image bar;
        public Text label;
    }
    [SerializeField] private ReputationUIMapping[] reputationUIs;


    void Start()
    {
        // Example test data (values from 0 to 100)
        float[] testReputationValues = { 65f, 85f, 30f, 50f };
        UpdateReputationDisplay(testReputationValues);
    }

    // Updates the entire reputation display based on new values.
    public void UpdateReputationDisplay(float[] reputationValues)
    {
        if (reputationValues.Length != reputationUIs.Length)
        {
            Debug.LogError("The number of reputation values does not match the number of UI mappings.");
            return;
        }

        // Update the bars
        for (int i = 0; i < reputationValues.Length; i++)
        {
            // Normalize the 0-100 value to 0-1 for the fillAmount
            reputationUIs[i].bar.fillAmount = reputationValues[i] / 100f;
        }

        // Find and display the dominant reputation
        float maxValue = reputationValues.Max();
        int maxIndex = System.Array.IndexOf(reputationValues, maxValue);
        ReputationArchetype dominantArchetype = (ReputationArchetype)maxIndex;

        dominantReputationTitle.text = $"Dominanter Archetyp: {dominantArchetype}";
    }
}
