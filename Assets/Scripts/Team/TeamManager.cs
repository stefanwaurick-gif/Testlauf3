using UnityEngine;

namespace RacingManager.Team
{
    public class TeamManager : MonoBehaviour
    {
        public static TeamManager Instance { get; private set; }

        [Header("Team Stats")]
        [Range(0, 100)]
        public float TeamPrestige = 50; // Starting prestige

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
                DontDestroyOnLoad(gameObject); // Optional: if this manager should persist across scenes
            }
        }

        /// <summary>
        /// Adds a specified amount to the team's prestige.
        /// </summary>
        /// <param name="amount">The amount of prestige to add.</param>
        public void AddPrestige(float amount)
        {
            TeamPrestige = Mathf.Clamp(TeamPrestige + amount, 0, 100);
            Debug.Log($"Prestige increased by {amount}. New prestige: {TeamPrestige}");
        }

        /// <summary>
        /// Removes a specified amount from the team's prestige.
        /// </summary>
        /// <param name="amount">The amount of prestige to remove.</param>
        public void RemovePrestige(float amount)
        {
            TeamPrestige = Mathf.Clamp(TeamPrestige - amount, 0, 100);
            Debug.Log($"Prestige decreased by {amount}. New prestige: {TeamPrestige}");
        }
    }
}
