using UnityEngine;

namespace RacingManager.Player
{
    public enum ReputationArchetype
    {
        Pragmatist,  // Pragmatiker
        Innovator,   // Innovator
        Showman,     // Entertainer
        Leader       // Anführer
    }

    public class ReputationManager : MonoBehaviour
    {
        public static ReputationManager Instance { get; private set; }

        [Header("Reputation Scores")]
        [Range(0, 100)] public float PragmatistScore;
        [Range(0, 100)] public float InnovatorScore;
        [Range(0, 100)] public float ShowmanScore;
        [Range(0, 100)] public float LeaderScore;

        private void Awake()
        {
            // Singleton pattern
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
            }
            else
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
        }

        /// <summary>
        /// Adds a specified amount to a reputation archetype.
        /// </summary>
        public void AddReputation(ReputationArchetype archetype, float amount)
        {
            switch (archetype)
            {
                case ReputationArchetype.Pragmatist:
                    PragmatistScore = Mathf.Clamp(PragmatistScore + amount, 0, 100);
                    break;
                case ReputationArchetype.Innovator:
                    InnovatorScore = Mathf.Clamp(InnovatorScore + amount, 0, 100);
                    break;
                case ReputationArchetype.Showman:
                    ShowmanScore = Mathf.Clamp(ShowmanScore + amount, 0, 100);
                    break;
                case ReputationArchetype.Leader:
                    LeaderScore = Mathf.Clamp(LeaderScore + amount, 0, 100);
                    break;
            }
            Debug.Log($"Reputation for {archetype} changed by {amount}.");
        }
    }
}
