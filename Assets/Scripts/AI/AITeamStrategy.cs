using UnityEngine;

namespace RacingManager.AI
{
    /// <summary>
    /// Manages the strategic state for an AI-controlled team.
    /// </summary>
    public class AITeamStrategy : MonoBehaviour
    {
        /// <summary>
        /// Defines the possible strategic states for an AI team.
        /// </summary>
        public enum TeamStrategyState
        {
            /// <summary>
            /// Prioritize spending on R&D for aggressive development.
            /// </summary>
            AggressiveDevelopment,

            /// <summary>
            /// A balanced approach between spending and saving.
            /// </summary>
            Balanced,

            /// <summary>
            /// Focus on saving money, minimal spending.
            /// </summary>
            SaveMoney
        }

        [Header("Team Strategy")]
        [Tooltip("The current strategic state of the AI team.")]
        public TeamStrategyState CurrentState;

        [Header("Pit Stop Strategy")]
        [Tooltip("The tire wear percentage at which a pit stop is considered.")]
        [Range(0, 100)]
        public float pitTireWearThreshold = 75.0f;

        [Tooltip("The fuel level (in laps) at which a pit stop is considered.")]
        public float pitFuelLevelThreshold = 2.0f;

        // --- PLACEHOLDER DATA ---
        // This data should be provided by other systems (e.g., CarPhysics, RaceManager)
        // once they are implemented.
        [Header("Placeholder Car & Race Data")]
        [Tooltip("Current average tire wear percentage.")]
        [Range(0, 100)]
        public float currentTireWear = 0.0f;

        [Tooltip("Current fuel level in laps.")]
        public float currentFuelLaps = 20.0f;

        [Tooltip("Is the safety car currently active?")]
        public bool isSafetyCarActive = false;
        // --- END OF PLACEHOLDER DATA ---

        // TODO: Uncomment this when CarPhysics.cs is available.
        // private CarPhysics carPhysics;

        void Start()
        {
            // Set an initial team strategy
            UpdateTeamStrategy();

            // TODO: Uncomment this when CarPhysics.cs is available.
            // carPhysics = GetComponent<CarPhysics>();
            // if (carPhysics == null)
            // {
            //     Debug.LogError("AITeamStrategy requires a CarPhysics component on the same GameObject.");
            // }
        }

        void Update()
        {
            // In a real scenario, you might not check this every single frame.
            EvaluatePitStopStrategy();
        }

        /// <summary>
        /// Updates the team's overall strategy to a new random state.
        /// </summary>
        public void UpdateTeamStrategy()
        {
            int stateCount = System.Enum.GetNames(typeof(TeamStrategyState)).Length;
            int randomStateIndex = Random.Range(0, stateCount);
            CurrentState = (TeamStrategyState)randomStateIndex;

            Debug.Log("AI Team strategy has been set to: " + CurrentState);
        }

        /// <summary>
        /// Evaluates the current game state to decide if a pit stop is necessary.
        /// </summary>
        public void EvaluatePitStopStrategy()
        {
            // --- DATA WIRING ---
            // When CarPhysics is available, update placeholder variables here.
            // currentTireWear = carPhysics.TireWear;
            // currentFuelLaps = carPhysics.FuelLevel;
            // isSafetyCarActive = RaceManager.Instance.IsSafetyCarDeployed;
            // ---

            bool shouldPit = false;
            string reason = "";

            // Rule 1: Pit if tire wear is critical
            if (currentTireWear >= pitTireWearThreshold)
            {
                shouldPit = true;
                reason = "critical tire wear";
            }

            // Rule 2: Pit if fuel is critical
            if (currentFuelLaps <= pitFuelLevelThreshold)
            {
                shouldPit = true;
                reason = "low fuel";
            }

            // Rule 3: Consider pitting under safety car (strategic opportunity)
            if (isSafetyCarActive)
            {
                // More complex logic would go here, e.g., checking lap number,
                // track position, etc. For now, we'll just assume it's a good idea.
                shouldPit = true;
                reason = "strategic opportunity under safety car";
            }

            if (shouldPit)
            {
                RequestPitStop(reason);
            }
        }

        /// <summary>
        /// Executes the pit stop request.
        /// </summary>
        private void RequestPitStop(string reason)
        {
            // In a real implementation, this would trigger a sequence in the game.
            // For now, it just logs the decision.
            Debug.Log("AI requests pit stop due to: " + reason);

            // To prevent spamming the log, we could add a cooldown or a flag.
            // For this example, we'll just reset the placeholder values.
            currentTireWear = 0;
            currentFuelLaps = 50; // Refueled
        }

        [Header("R&D Strategy")]
        [Tooltip("A value from 0 to 1 representing the team's desperation. Higher values increase the chance of using risky parts.")]
        [Range(0, 1)]
        public float desperation = 0.1f; // Default to low desperation

        /// <summary>
        /// Decides whether the team should develop or install a risky part based on desperation.
        /// </summary>
        /// <returns>True if a risky part should be used, false otherwise.</returns>
        public bool ShouldUseRiskyPart()
        {
            // In a real scenario, the 'desperation' value would be dynamically calculated
            // based on championship standing, recent results, etc.

            float chance = Random.value; // A random value between 0.0 and 1.0
            bool shouldUse = chance < desperation;

            if (shouldUse)
            {
                Debug.Log($"AI decided to use a risky part. (Desperation: {desperation}, Rolled: {chance})");
            }

            return shouldUse;
        }
    }
}
