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

        [Tooltip("The current strategic state of the AI team.")]
        public TeamStrategyState CurrentState;

        /// <summary>
        /// Sets an initial state when the game starts.
        /// </summary>
        void Start()
        {
            // Set an initial state randomly.
            UpdateStrategy();
        }

        /// <summary>
        /// Updates the team's strategy to a new random state.
        /// In the future, this will be driven by more complex logic.
        /// </summary>
        public void UpdateStrategy()
        {
            int stateCount = System.Enum.GetNames(typeof(TeamStrategyState)).Length;
            int randomStateIndex = Random.Range(0, stateCount);
            CurrentState = (TeamStrategyState)randomStateIndex;

            Debug.Log("AI Team strategy has been set to: " + CurrentState);
        }
    }
}
